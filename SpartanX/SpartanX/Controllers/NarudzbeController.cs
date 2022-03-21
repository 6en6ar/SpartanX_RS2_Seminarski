using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpartanX.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        [Authorize]
        public List<ModelSpartanX.Narudzbe> Get([FromQuery] object search = null)
        {
            return _service.Get(search);
        }
        [HttpGet("{username},{password}")]
        public List<ModelSpartanX.Narudzbe> GetNarudzbe(string username, string password, [FromQuery] object search = null)
        {
            if( _service.GetNarudzbe(username, password, search) == null)
            {
                return null;
            }
            else
            {
                return _service.GetNarudzbe(username, password, search);
            }
        }
        [HttpGet("{id}")]
        [Authorize]
        public ModelSpartanX.Narudzbe GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        [Authorize]
        public void Insert(ModelSpartanX.Requests.NarudzbeInsertRequest request)
        {
           _service.Insert(request);
        }
        [HttpPost("{username},{password}")]
        //[Authorize]
        public void InsertNarudzba(ModelSpartanX.Requests.NarudzbeInsertRequest request, string username, string password)
        {
            _service.InsertNarudzba(request, username, password);
        }
        [HttpPut("{id}")]
        [Authorize]
        public ModelSpartanX.Narudzbe Update(int id, [FromBody] ModelSpartanX.Requests.NarudzbeUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
