using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class DobavljaciService : BaseCRUDService<Model.Dobavljaci, Database.Dobavljaci, object>, IDobavljaciService
    {
        public DobavljaciService(SpartanXContext _context, IMapper _mapper) : base(_context, _mapper)
        {
        }
    }
}
