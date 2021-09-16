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
    public class SkladistaController : BaseReadController<Model.Skladista, object>
    {
        public SkladistaController(ISkladistaService _service) : base(_service)
        {

        }
    }
}
