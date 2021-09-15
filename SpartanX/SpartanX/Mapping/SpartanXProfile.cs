using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Mapping
{
    public class SpartanXProfile : Profile
    {
        public SpartanXProfile()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
        }
    }
}
