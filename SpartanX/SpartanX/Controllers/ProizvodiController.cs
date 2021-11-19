using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpartanX.Model.Requests;
using SpartanX.Models;
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
    public class ProizvodiController : ControllerBase
    {
        private readonly IProizvodiService _service;
        public ProizvodiController(IProizvodiService  service)
        {
            _service = service;
        }
        [HttpGet("Recommend/{id}")]
        public List<ModelSpartanX.Proizvodi> Recommend(int id)
        {
            return (_service as IProizvodiService).Recommend(id);
        }
        [HttpGet]
        public List<ModelSpartanX.Proizvodi> Get([FromQuery] ModelSpartanX.Search.ProizvodiSearchObject request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ModelSpartanX.Proizvodi GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        [Authorize]
        public ModelSpartanX.Proizvodi Insert(ModelSpartanX.Requests.ProizvodiInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        //[Authorize(Roles = "Menadzer")]
        [Authorize]
        public ModelSpartanX.Proizvodi Update(int id, [FromBody] ModelSpartanX.Requests.ProizvodiUpdateRequest request)
        {
            return _service.Update(id, request);
        }

    }
}
