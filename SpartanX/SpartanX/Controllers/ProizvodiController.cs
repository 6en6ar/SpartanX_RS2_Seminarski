using Microsoft.AspNetCore.Mvc;
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
    public class ProizvodiController : BaseReadController<Model.Proizvodi, Model.Search.ProizvodiSearchObject>
    {
        public ProizvodiController(IProizvodiService  _service) : base(_service)
        {

        }

    }
}
