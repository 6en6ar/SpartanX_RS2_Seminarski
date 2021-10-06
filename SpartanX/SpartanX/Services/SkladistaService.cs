using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class SkladistaService : ISkladistaService
    {
        private readonly SpartanXContext _context;
        private readonly IMapper _mapper;
        public SkladistaService(SpartanXContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ModelSpartanX.Skladista> Get(ModelSpartanX.Search.SkladistaSearchObject search = null)
        {
            var DBset = _context.Set<Database.Skladistum>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                DBset = DBset.Where(x => x.Naziv.Contains(search.Naziv));
            }
            // if ..

            var lista = DBset.ToList();
            var modeli = _mapper.Map<List<ModelSpartanX.Skladista>>(DBset);
            return modeli;
        }
        public ModelSpartanX.Skladista GetById(int id)
        {
            var entity = _context.Skladista.Find(id);

            return _mapper.Map<ModelSpartanX.Skladista>(entity);

        }
        public void Insert(ModelSpartanX.Requests.SkladisteInsertRequest request)
        {
            var skladiste = _mapper.Map<Database.Skladistum>(request);

            _context.Skladista.Add(skladiste);
            _context.SaveChanges();

        }
        public ModelSpartanX.Skladista Update(int id, ModelSpartanX.Requests.SkladisteUpdateRequest request)
        {
            var skladiste = _context.Skladista.Find(id);
            _mapper.Map(request, skladiste);
            _context.SaveChanges();
            return _mapper.Map<ModelSpartanX.Skladista>(skladiste);

        }
    }
}
