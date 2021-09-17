using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class VrsteProizvodaService : BaseReadService<Model.VrstaProizvoda, Database.VrstaProizvodum, object>, IVrsteProizvodaService
    {
        public VrsteProizvodaService(SpartanXContext _context, IMapper _mapper)
           : base(_context, _mapper)
        {

        }
    }
}
