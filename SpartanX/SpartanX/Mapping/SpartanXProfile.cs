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
            CreateMap<Database.Korisnici, ModelSpartanX.Korisnici>().ReverseMap();
            CreateMap<Database.Korisnici, ModelSpartanX.Requests.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnici, ModelSpartanX.Requests.KorisniciUpdateRequest>().ReverseMap();
            CreateMap<Database.Proizvodi, ModelSpartanX.Proizvodi>();
            CreateMap<Database.Skladistum, ModelSpartanX.Skladista>().ReverseMap();
            CreateMap<Database.Skladistum, ModelSpartanX.Requests.SkladisteInsertRequest>().ReverseMap();
            CreateMap<Database.Skladistum, ModelSpartanX.Requests.SkladisteUpdateRequest>().ReverseMap();
            CreateMap<Database.Dobavljaci, ModelSpartanX.Dobavljaci>();
            CreateMap<Database.Kupci, ModelSpartanX.Kupci>().ReverseMap();
            CreateMap<Database.VrstaProizvodum, ModelSpartanX.VrstaProizvoda>();
            CreateMap<Database.Proizvodjaci, ModelSpartanX.Proizvodjaci>();
            CreateMap<Database.Komentar, ModelSpartanX.Komentar>();
            CreateMap<Database.Uloge, ModelSpartanX.Uloge>();
            CreateMap<Database.KorisnikUloge, ModelSpartanX.KorisniciUloge>();
            CreateMap<ModelSpartanX.Requests.ProizvodiUpdateRequest, Database.Proizvodi>();
            CreateMap<ModelSpartanX.Requests.ProizvodiInsertRequest, Database.Proizvodi>();
            CreateMap<ModelSpartanX.Requests.DobavljaciInsertRequest, Database.Dobavljaci>();
            CreateMap<ModelSpartanX.Requests.KupciInsertRequest, Database.Kupci>();
        }
    }
}
