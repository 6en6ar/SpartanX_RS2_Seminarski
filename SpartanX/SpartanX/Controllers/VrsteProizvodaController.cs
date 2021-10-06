using Microsoft.AspNetCore.Mvc;
using SpartanX.Model;
using SpartanX.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VrsteProizvodaController : BaseReadController<ModelSpartanX.VrstaProizvoda, object>
    {
        public VrsteProizvodaController(IVrsteProizvodaService _service) : base(_service)
        {

        }
    }
}
