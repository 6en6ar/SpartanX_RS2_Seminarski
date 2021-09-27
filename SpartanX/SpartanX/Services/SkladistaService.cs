using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class SkladistaService : BaseCRUDService<Model.Skladista, Database.Skladistum, Model.Search.SkladistaSearchObject>, ISkladistaService
    {
        public SkladistaService(SpartanXContext _context, IMapper _mapper) : base(_context, _mapper)
        {

        }
        public override IEnumerable<Model.Skladista> Get(Model.Search.SkladistaSearchObject search = null)
        {
            var DBset = context.Set<Database.Skladistum>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                DBset = DBset.Where(x => x.Naziv.Contains(search.Naziv));
            }
            // if ..

            var lista = DBset.ToList();
            var modeli = mapper.Map<List<Model.Skladista>>(DBset);
            return modeli;
        }
    }
}
