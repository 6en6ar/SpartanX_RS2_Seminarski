using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class BaseReadService<T, TDb, TSearch> : IReadService<T, TSearch> where T:class where TDb: class where TSearch: class
    {
        public SpartanXContext context { get; set; }
        protected readonly IMapper mapper;
        public BaseReadService(SpartanXContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var DBset = context.Set<TDb>();
            var modeli = mapper.Map<List<T>>(DBset);
            return modeli;
        }

        public virtual  T GetById(int id)
        {
            var DBset = context.Set<TDb>();
            var model = DBset.Find(id);
            return mapper.Map<T>(model);
        }
    }
}
