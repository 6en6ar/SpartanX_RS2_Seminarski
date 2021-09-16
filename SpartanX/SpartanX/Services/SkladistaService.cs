using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class SkladistaService : BaseReadService<Model.Skladista, Database.Skladistum, object>, ISkladistaService
    {
        public SkladistaService(SpartanXContext _context, IMapper _mapper) : base(_context, _mapper)
        {

        }
    }
}
