using AutoMapper;
using SpartanX.Database;
using SpartanX.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class DobavljaciService : BaseCRUDService<ModelSpartanX.Dobavljaci, Database.Dobavljaci, ModelSpartanX.Search.DobavljaciSearchObject, ModelSpartanX.Requests.DobavljaciInsertRequest, object>, IDobavljaciService
    {
        public DobavljaciService(SpartanXContext _context, IMapper _mapper) : base(_context, _mapper)
        {
        }
        public override IEnumerable<ModelSpartanX.Dobavljaci> Get(ModelSpartanX.Search.DobavljaciSearchObject search = null)
        {
            var DBset = context.Set<Database.Dobavljaci>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                DBset = DBset.Where(x => x.Naziv.Contains(search.Naziv));
            }
            var lista = DBset.ToList();
            var modeli = mapper.Map<List<ModelSpartanX.Dobavljaci>>(lista);
            return modeli;
        }
    }
}
