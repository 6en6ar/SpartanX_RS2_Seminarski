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
    [Authorize]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.Korisnici> Get([FromQuery] Model.Search.KorisniciSearchObject request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public Model.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        [Authorize(Roles ="Administrator")]
        public Model.Korisnici Insert(Model.Requests.KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "Administrator")]
        public Model.Korisnici Update(int id, [FromBody] Model.Requests.KorisniciInsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
