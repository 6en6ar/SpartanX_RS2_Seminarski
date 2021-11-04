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
    [Authorize]
    public class UlogeController : BaseReadController<ModelSpartanX.Uloge, object>
    {
        
        public UlogeController(IUlogeService _service) : base(_service)
        {

        }
    }
}
