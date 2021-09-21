using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> : BaseCRUDService<T, TDb, TSearch>, ICRUDService<T, TSearch, TInsert, TUpdate> where T : class where TSearch : class where TDb : class where TInsert : class where TUpdate : class
    {
        public BaseCRUDService(SpartanXContext _context, IMapper _mapper) : base(_context, _mapper)
        {
        }

        T ICRUDService<T, TSearch, TInsert, TUpdate>.Insert(TInsert insertReq)
        {
            var dbset = context.Set<TDb>();

            var entity = mapper.Map<TDb>(insertReq);
            dbset.Add(entity);
            context.SaveChanges();
            return mapper.Map<T>(entity);
        }

        T ICRUDService<T, TSearch, TInsert, TUpdate>.Update(int id, TUpdate updateReq)
        {
            var dbset = context.Set<TDb>();
            var entity = dbset.Find(id);
            mapper.Map(updateReq, entity);
            context.SaveChanges();
            return mapper.Map<T>(entity);

        }
    }
}
