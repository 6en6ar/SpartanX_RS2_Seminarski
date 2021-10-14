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
    //[Authorize]
    public class NarudzbeController : BaseCRUDController<ModelSpartanX.Narudzbe, object, ModelSpartanX.Requests.NarudzbeInsertRequest, object>
    {
        public NarudzbeController(INarudzbeService _service) : base(_service)
        {

        }
    }
}
