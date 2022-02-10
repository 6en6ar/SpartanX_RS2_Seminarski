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
    //[Authorize]
    public class DobavljaciController : BaseCRUDController<ModelSpartanX.Dobavljaci, ModelSpartanX.Search.DobavljaciSearchObject, ModelSpartanX.Requests.DobavljaciInsertRequest, object>
    {
        public DobavljaciController(IDobavljaciService _service) : base(_service)
        {

        }
    }
}
