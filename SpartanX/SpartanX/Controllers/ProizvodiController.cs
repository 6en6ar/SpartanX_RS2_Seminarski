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
    public class ProizvodiController : BaseCRUDController<ModelSpartanX.Proizvodi, ModelSpartanX.Search.ProizvodiSearchObject, ModelSpartanX.Requests.ProizvodiInsertRequest, ModelSpartanX.Requests.ProizvodiUpdateRequest>
    {
        public ProizvodiController(IProizvodiService  _service) : base(_service)
        {

        }
        [HttpGet("Recommend/{id}")]
        public List<ModelSpartanX.Proizvodi> Recommend(int id)
        {
            return (_service as IProizvodiService).Recommend(id);
        }

    }
}
