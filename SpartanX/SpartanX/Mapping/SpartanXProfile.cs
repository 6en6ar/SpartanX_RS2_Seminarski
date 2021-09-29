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
            CreateMap<Database.Korisnici, Model.Requests.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnici, Model.Requests.KorisniciUpdateRequest>().ReverseMap();
            CreateMap<Database.Proizvodi, Model.Proizvodi>();
            CreateMap<Database.Skladistum, Model.Skladista>().ReverseMap();
            CreateMap<Database.Skladistum,Model.Requests.SkladisteInsertRequest>().ReverseMap();
            CreateMap<Database.Skladistum,Model.Requests.SkladisteUpdateRequest>().ReverseMap();

            CreateMap<Database.Dobavljaci, Model.Dobavljaci>();
            CreateMap<Database.VrstaProizvodum, Model.VrstaProizvoda>();
            CreateMap<Database.Proizvodjaci, Model.Proizvodjaci>();
            CreateMap<Database.Komentar, Model.Komentar>();
            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Model.Requests.ProizvodiUpdateRequest, Database.Proizvodi>();
            CreateMap<Model.Requests.ProizvodiInsertRequest, Database.Proizvodi>();
        }
    }
}
