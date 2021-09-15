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
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService service;
        public KorisniciController(IKorisniciService _service)
        {
            service = _service;
        }
        [HttpGet]
        public IList<Model.Korisnici> Get()
        {
            return service.Get();
        }
    }
}
