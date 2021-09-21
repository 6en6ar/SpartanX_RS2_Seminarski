using AutoMapper;
using SpartanX.Database;
using SpartanX.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class KorisniciService : BaseCRUDService<Model.Korisnici, Database.Korisnici, Model.Search.KorisniciSearchObject, object, object>, IKorisniciService
    {
      
        public KorisniciService(SpartanXContext _context, IMapper _mapper): base(_context, _mapper)
        {
          
        }
        public override IEnumerable<Model.Korisnici> Get(KorisniciSearchObject search = null)
        {
            var DBset = context.Set<Database.Korisnici>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                DBset = DBset.Where(x => x.Ime.Contains(search.Ime));
            }
            // if ..

            var lista = DBset.ToList();
            var modeli = mapper.Map<List<Model.Korisnici>>(lista);
            return modeli;
        }

    }
}
