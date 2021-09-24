using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class UlogeService : BaseCRUDService<Model.Uloge, Database.Uloge, object>, IUlogeService
    {
        public UlogeService(SpartanXContext _context, IMapper _mapper) : base(_context, _mapper)
        {

        }
    }
}
