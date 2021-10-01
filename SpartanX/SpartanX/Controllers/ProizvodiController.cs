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
    public class ProizvodiController : BaseCRUDController<Model.Proizvodi, Model.Search.ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
        public ProizvodiController(IProizvodiService  _service) : base(_service)
        {

        }
        [HttpGet("Recmmend/{id}")]
        public List<Model.Proizvodi> Recommend(int id)
        {
            return (_service as IProizvodiService).Recommend(id);
        }

    }
}
