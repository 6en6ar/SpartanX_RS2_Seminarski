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
    public class ProizvodiController : ControllerBase
    {
        public IProizvodiService proizvodiService { get; set; }

        public ProizvodiController(IProizvodiService _proizvodiService)
        {
            proizvodiService = _proizvodiService;
        }
        [HttpGet]
        public IEnumerable<Proizvod> Get()
        {
            return proizvodiService.Get();
        }
        [HttpGet("{id}")]
        public Proizvod GetById(int id)
        {
            return proizvodiService.GetById(id);
        }
        [HttpPost]
        public Proizvod Insert(Proizvod proizvod)
        {
            return proizvodiService.Insert(proizvod);

        }
        [HttpPut("{id}")]
        public Proizvod Update(int id, Proizvod proizvod)
        {
            return proizvodiService.Update(id, proizvod);
        }
        [HttpDelete("{id}")]
        public IEnumerable<Proizvod> Delete(int id)
        {
            return proizvodiService.Delete(id);
        }
    }
}
