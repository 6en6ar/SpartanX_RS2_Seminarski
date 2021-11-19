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

    public class KupciController : ControllerBase
    {
        private readonly IKupciService _service;
        public KupciController(IKupciService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("Authenticate/{username},{password}")]
        public ModelSpartanX.Kupci Authenticate(string username, string password)
        {
            return _service.Authenticate(username, password);
        }
        [HttpGet]
        [Authorize]
        public List<ModelSpartanX.Kupci> Get([FromQuery] ModelSpartanX.Search.KupciSearchObject request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        [Authorize]
        public ModelSpartanX.Kupci GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public ModelSpartanX.Kupci Insert(ModelSpartanX.Requests.KupciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPost("{id}/{username},{password}")]
        public ModelSpartanX.Kupci Update(int id,[FromBody] ModelSpartanX.Requests.KupciUpdateRequest request, string username, string password)
        {
            return _service.Update(id, request, username, password);
        }
    }
}
