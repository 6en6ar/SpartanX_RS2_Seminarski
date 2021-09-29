using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class SkladistaController :ControllerBase
    {
        private readonly ISkladistaService _service;
        public SkladistaController(ISkladistaService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Skladista> Get([FromQuery] Model.Search.SkladistaSearchObject request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Skladista GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public void Insert(Model.Requests.SkladisteInsertRequest request)
        {
            _service.Insert(request);
        }
        [HttpPut("{id}")]
        public Model.Skladista Update(int id, [FromBody] Model.Requests.SkladisteUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
