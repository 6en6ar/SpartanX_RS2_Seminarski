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

    public class KupciController : ControllerBase
    {
        private readonly IKupciService _service;
        public KupciController(IKupciService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<ModelSpartanX.Kupci> Get(ModelSpartanX.Search.KupciSearchObject request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ModelSpartanX.Kupci GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public ModelSpartanX.Kupci Insert(ModelSpartanX.Requests.KupciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public ModelSpartanX.Kupci Update(int id, [FromBody] ModelSpartanX.Requests.KupciInsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
