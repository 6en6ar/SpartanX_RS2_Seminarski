using Microsoft.AspNetCore.Mvc;
using SpartanX.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert,TUpdate> : BaseReadController<T,TSearch> where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        protected readonly ICRUDService<T, TSearch, TInsert, TUpdate> _service;
       public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) :base(service)
        {
            _service = service;
        }

        [HttpPost]
        public T Insert([FromBody] TInsert req)
        {
            return _service.Insert(req);
        }
        [HttpPut("{id}")]
        public T Update(int id, [FromBody] TUpdate req)
        {
            return _service.Update(id,req);
        }
    }
}
