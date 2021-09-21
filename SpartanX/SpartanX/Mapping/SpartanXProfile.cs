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
            CreateMap<Database.Korisnici, Model.Korisnici>().ReverseMap();
            CreateMap<Database.Proizvodi, Model.Proizvodi>();
            CreateMap<Database.Skladistum, Model.Skladista>();
            CreateMap<Database.VrstaProizvodum, Model.VrstaProizvoda>();
            CreateMap<Database.Proizvodjaci, Model.Proizvodjaci>();
            CreateMap<Database.Komentar, Model.Komentar>();
            CreateMap<Model.Requests.ProizvodiUpdateRequest, Database.Proizvodi>();
            CreateMap<Model.Requests.ProizvodiInsertRequest, Database.Proizvodi>();
        }
    }
}
