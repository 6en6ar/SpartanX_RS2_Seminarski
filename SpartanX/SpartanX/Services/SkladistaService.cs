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

        public List<Model.Skladista> Get(Model.Search.SkladistaSearchObject search = null)
        {
            var DBset = _context.Set<Database.Skladistum>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                DBset = DBset.Where(x => x.Naziv.Contains(search.Naziv));
            }
            // if ..

            var lista = DBset.ToList();
            var modeli = _mapper.Map<List<Model.Skladista>>(DBset);
            return modeli;
        }
        public Model.Skladista GetById(int id)
        {
            var entity = _context.Skladista.Find(id);

            return _mapper.Map<Model.Skladista>(entity);

        }
        public void Insert(Model.Requests.SkladisteInsertRequest request)
        {
            var skladiste = _mapper.Map<Database.Skladistum>(request);

            _context.Skladista.Add(skladiste);
            _context.SaveChanges();

        }
        public Model.Skladista Update(int id, Model.Requests.SkladisteUpdateRequest request)
        {
            var skladiste = _context.Skladista.Find(id);
            _mapper.Map(request, skladiste);
            _context.SaveChanges();
            return _mapper.Map<Model.Skladista>(skladiste);

        }
    }
}
