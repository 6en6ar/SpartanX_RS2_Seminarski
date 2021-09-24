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
    public class UlogeController : BaseReadController<Model.Uloge, object>
    {
        public UlogeController(IUlogeService _service) : base(_service)
        {

        }
    }
}
