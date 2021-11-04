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
    //[Authorize]
    public class SkladistaController :ControllerBase
    {
        private readonly ISkladistaService _service;
        public SkladistaController(ISkladistaService service)
        {
            _service = service;
        }
        [HttpGet]
        [Authorize]
        public List<ModelSpartanX.Skladista> Get([FromQuery] ModelSpartanX.Search.SkladistaSearchObject request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        [Authorize]
        public ModelSpartanX.Skladista GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        [Authorize]
        public void Insert(ModelSpartanX.Requests.SkladisteInsertRequest request)
        {
            _service.Insert(request);
        }
        [HttpPut("{id}")]
        [Authorize]
        public ModelSpartanX.Skladista Update(int id, [FromBody] ModelSpartanX.Requests.SkladisteUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
