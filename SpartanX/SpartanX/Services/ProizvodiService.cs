using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using SpartanX.Database;
using SpartanX.Model.Requests;
using SpartanX.Model.Search;
using SpartanX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class ProizvodiService : IProizvodiService
    {
        private readonly SpartanXContext _context;
        private readonly IMapper _mapper;
        public ProizvodiService(SpartanXContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ModelSpartanX.Proizvodi> Get(ModelSpartanX.Search.ProizvodiSearchObject search = null)
        {
            var DBset = _context.Set<Database.Proizvodi>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                DBset = DBset.Where(x => x.Naziv.Contains(search.Naziv));
            }
            // if ..
            if (search.Id.HasValue)
            {
                DBset = DBset.Where(x => x.VrstaId == search.Id);
            }
            if (search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    DBset = DBset.Include(item);
                }
            }

            var lista = DBset.ToList();
            var modeli = _mapper.Map<List<ModelSpartanX.Proizvodi>>(lista);
            return modeli;
        }
        public ModelSpartanX.Proizvodi GetById(int id)
        {
            var entity = _context.Proizvodis.Find(id);

            return _mapper.Map<ModelSpartanX.Proizvodi>(entity);
        }
        public ModelSpartanX.Proizvodi Update(int id, ModelSpartanX.Requests.ProizvodiUpdateRequest req)
        {
            var proizvodi = _context.Proizvodis.Find(id);
            _mapper.Map(req, proizvodi);
            _context.SaveChanges();
            return _mapper.Map<ModelSpartanX.Proizvodi>(proizvodi);
        }
        public ModelSpartanX.Proizvodi Insert(ModelSpartanX.Requests.ProizvodiInsertRequest request)
        {
            var proizvod = _mapper.Map<Database.Proizvodi>(request);

            _context.Proizvodis.Add(proizvod);
            _context.SaveChanges();
            return _mapper.Map<ModelSpartanX.Proizvodi>(proizvod);

        }
        public class Copurchase_prediction
        {
            public float Score { get; set; }
        }

        public class ProductEntry
        {
            [KeyType(count: 15)]
            public uint ProductID { get; set; }

            [KeyType(count: 15)] 
            public uint CoPurchaseProductID { get; set; }
            public float Label { get; set; }
        }
        private static MLContext _MLcontext = null;
        private static ITransformer model;
        public List<ModelSpartanX.Proizvodi> Recommend(int id)
        {
            if(_MLcontext == null)
            {
                _MLcontext = new MLContext();
                var narudzbaStavke = _context.Narudzbes.Include("NarudzbaStavkes").ToList();
                var data = new List<ProductEntry>();
                foreach (var nS in narudzbaStavke)
                {
                    if(nS.NarudzbaStavkes.Count > 1)
                    {
                        var ProId = nS.NarudzbaStavkes.Select(x => x.ProizvodId).ToList();
                        ProId.ForEach(y =>
                        {
                            var relatedItems = nS.NarudzbaStavkes.Where(z => z.ProizvodId != y);
                            foreach (var item in relatedItems)
                            {
                                data.Add(new ProductEntry()
                                {
                                    ProductID = (uint)y,
                                    CoPurchaseProductID = (uint)item.ProizvodId
                                });
                                
                            }
                        });
                    }
                }
                //train the data
                var dataToTrain = _MLcontext.Data.LoadFromEnumerable(data);

                MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
                options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
                options.LabelColumnName = "Label";
                options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                options.Alpha = 0.01;
                options.Lambda = 0.025;
                options.NumberOfIterations = 100;

                options.C = 0.00001;

                //Step 4: Call the MatrixFactorization trainer by passing options.
                var est = _MLcontext.Recommendation().Trainers.MatrixFactorization(options);

                model = est.Fit(dataToTrain);
            }
            var sviProizvodi = _context.Proizvodis.Where(x => x.ProizvodId != id);

            var predictionResult = new List<Tuple<Database.Proizvodi, float>>();

            foreach (var item in sviProizvodi)
            {
                var predictionEngine = _MLcontext.Model.CreatePredictionEngine<ProductEntry,Copurchase_prediction>(model);

                var prediction = predictionEngine.Predict(new ProductEntry()
                {
                    ProductID = (uint)id,
                    CoPurchaseProductID = (uint)item.ProizvodId
                });
                //add to result
                predictionResult.Add(new Tuple<Database.Proizvodi, float>(item, prediction.Score));

            }

            var final = predictionResult.OrderByDescending(x => x.Item2).Select(x => x.Item1).Take(3).ToList();
            return _mapper.Map<List<ModelSpartanX.Proizvodi>>(final);
        }

    }
}
