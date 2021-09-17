using Microsoft.AspNetCore.Mvc;
using SpartanX.Model;
using SpartanX.Model.Search;
using SpartanX.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProizvodjaciController : BaseReadController<Model.Proizvodjaci, Model.Search.ProizvodjaciSearchObject>
    {
        public ProizvodjaciController(IProizvodjaciService _service) : base(_service)
        {
        }
    }
}
