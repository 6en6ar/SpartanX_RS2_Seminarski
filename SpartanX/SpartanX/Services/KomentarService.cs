using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class KomentarService : BaseCRUDService<Model.Komentar, Database.Komentar, object>, IKomentarService
    {
        public KomentarService(SpartanXContext _context, IMapper _mapper) : base(_context, _mapper)
        {
        }
    }
}
