using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class ProizvodjaciService : BaseCRUDService<ModelSpartanX.Proizvodjaci,Database.Proizvodjaci, ModelSpartanX.Search.ProizvodjaciSearchObject>, IProizvodjaciService
    {
        public ProizvodjaciService(SpartanXContext _context, IMapper _mapper)
           : base(_context, _mapper)
        {

        }
        public override IEnumerable<ModelSpartanX.Proizvodjaci> Get(ModelSpartanX.Search.ProizvodjaciSearchObject search = null)
        {
            var DBset = context.Set<Database.Proizvodjaci>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                DBset = DBset.Where(x => x.Naziv.Contains(search.Naziv));
            }
            // if ..

            var lista = DBset.ToList();
            var modeli = mapper.Map<List<ModelSpartanX.Proizvodjaci>>(DBset);
            return modeli;
        }
    }
}
