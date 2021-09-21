﻿using Microsoft.AspNetCore.Mvc;
using SpartanX.Database;
using SpartanX.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : BaseReadController<Model.Korisnici, object>
    { 
        public KorisniciController(IKorisniciService _service) : base(_service)
        {
          
        }
    }
}