using Microsoft.AspNetCore.Mvc;
using SpartanX.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseReadController<T, TSearch> : ControllerBase where T:class where TSearch:class
    {
        protected readonly IReadService<T, TSearch> service;
        public BaseReadController(IReadService<T, TSearch> _service)
        {
            service = _service;
        }
        [HttpGet]
        public virtual IEnumerable<T> Get([FromQuery] TSearch search)
        {
            return service.Get(search);
        }
        [HttpGet("{id}")]
        public virtual T GetById(int id)
        {
            return service.GetById(id);
        }
    }
}
