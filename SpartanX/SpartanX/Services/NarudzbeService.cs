using AutoMapper;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class NarudzbeService : BaseCRUDService<ModelSpartanX.Narudzbe, Database.Narudzbe, object, ModelSpartanX.Requests.NarudzbeInsertRequest, ModelSpartanX.Requests.NarudzbeUpdateRequest>, INarudzbeService
    {
        public NarudzbeService(SpartanXContext _context, IMapper _mapper)
           : base(_context, _mapper)
        {

        }
    }
}
