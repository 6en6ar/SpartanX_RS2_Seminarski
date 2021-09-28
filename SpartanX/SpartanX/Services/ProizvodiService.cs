using AutoMapper;
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
    public class ProizvodiService : BaseCRUDService<Model.Proizvodi, Database.Proizvodi,Model.Search.ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>, IProizvodiService
    {
        public ProizvodiService(SpartanXContext _context, IMapper _mapper)
            : base(_context, _mapper)
        {

        }
        public override IEnumerable<Model.Proizvodi> Get(ProizvodiSearchObject search = null)
        {
            var DBset = context.Set<Database.Proizvodi>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                DBset = DBset.Where(x => x.Naziv.Contains(search.Naziv));
            }
            // if ..
            if (search.Id.HasValue)
            {
                DBset = DBset.Where(x => x.VrstaId == search.Id);
            }

            var lista = DBset.ToList();
            var modeli = mapper.Map<List<Model.Proizvodi>>(DBset);
            return modeli;
        }

    }
}
