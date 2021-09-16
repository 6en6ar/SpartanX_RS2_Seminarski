using AutoMapper;
using SpartanX.Database;
using SpartanX.Model.Search;
using SpartanX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class ProizvodiService : BaseReadService<Model.Proizvodi, Database.Proizvodi,Model.Search.ProizvodiSearchObject>, IProizvodiService
    {
        public ProizvodiService(SpartanXContext _context, IMapper _mapper)
            : base(_context, _mapper)
        {

        }
        public override IEnumerable<Model.Proizvodi> Get(ProizvodiSearchObject search = null)
        {
            var DBset = context.Set<Database.Proizvodi>();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                var pro = DBset.Where(x => x.Naziv.Contains(search.Naziv));
            }
            // if ..

            var modeli = mapper.Map<List<Model.Proizvodi>>(DBset);
            return modeli;
        }

    }
}
