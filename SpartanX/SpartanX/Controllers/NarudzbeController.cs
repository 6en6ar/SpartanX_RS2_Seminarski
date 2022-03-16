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
    public class NarudzbeController : ControllerBase
    {
        private readonly INarudzbeService _service;
        public NarudzbeController(INarudzbeService service)
        {
            _service = service;
        }      
        [HttpGet]
        public List<ModelSpartanX.Narudzbe> Get([FromQuery] object search = null)
        {
            return _service.Get(search);
        }
        [HttpGet("{id}")]
        public ModelSpartanX.Narudzbe GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        //[Authorize]
        public ModelSpartanX.Narudzbe Insert(ModelSpartanX.Requests.NarudzbeInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        //[Authorize]
        public ModelSpartanX.Narudzbe Update(int id, [FromBody] ModelSpartanX.Requests.NarudzbeUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
