using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpartanX.Database;
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
    
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<ModelSpartanX.Korisnici> Get([FromQuery] ModelSpartanX.Search.KorisniciSearchObject request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ModelSpartanX.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        //[Authorize(Roles ="Administrator")]
        public ModelSpartanX.Korisnici Insert(ModelSpartanX.Requests.KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        //[Authorize(Roles = "Administrator")]
        public ModelSpartanX.Korisnici Update(int id, [FromBody] ModelSpartanX.Requests.KorisniciUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
