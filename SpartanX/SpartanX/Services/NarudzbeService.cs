using AutoMapper;
using ModelSpartanX.Requests;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class NarudzbeService : INarudzbeService
    {
        private readonly SpartanXContext _context;
        private readonly IMapper _mapper;
        public NarudzbeService(SpartanXContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ModelSpartanX.Narudzbe> Get(object search = null)
        {
            var DBset = _context.Set<Database.Narudzbe>().AsQueryable();
            var lista = DBset.ToList();
            var modeli = _mapper.Map<List<ModelSpartanX.Narudzbe>>(DBset);
            return modeli;
        }

        public ModelSpartanX.Narudzbe GetById(int id)
        {
            var entity = _context.Narudzbes.Find(id);

            return _mapper.Map<ModelSpartanX.Narudzbe>(entity);
        }

        public ModelSpartanX.Narudzbe Insert(NarudzbeInsertRequest request)
        {
            var narudzba = _mapper.Map<Database.Narudzbe>(request);

            _context.Narudzbes.Add(narudzba);
            _context.SaveChanges();
            return _mapper.Map<ModelSpartanX.Narudzbe>(narudzba);
        }


        public ModelSpartanX.Narudzbe Update(int id, NarudzbeUpdateRequest request)
        {
            var narudzba = _context.Narudzbes.Find(id);
            _mapper.Map(request, narudzba);
            _context.SaveChanges();
            return _mapper.Map<ModelSpartanX.Narudzbe>(narudzba);
        }
    }
}
