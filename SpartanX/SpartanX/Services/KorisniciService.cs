using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class KorisniciService : IKorisniciService
    {
        public SpartanXContext context { get; set; }
        protected readonly IMapper mapper;
        public KorisniciService(SpartanXContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }
        public IList<Model.Korisnici> Get()
        {
            return context.Korisnicis.ToList().Select(x => mapper.Map<Model.Korisnici>(x)).ToList();
        }
    }
}
