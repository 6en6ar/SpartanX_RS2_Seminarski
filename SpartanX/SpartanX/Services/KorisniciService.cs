using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class KorisniciService : BaseReadService<Model.Korisnici, Database.Korisnici, object>, IKorisniciService
    {
      
        public KorisniciService(SpartanXContext _context, IMapper _mapper): base(_context, _mapper)
        {
          
        }
        
    }
}
