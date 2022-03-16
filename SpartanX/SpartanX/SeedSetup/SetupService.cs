using Microsoft.EntityFrameworkCore;
using SpartanX.Database;
using SpartanX.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.SeedSetup
{
    public class SetupService
    {
        public void Init(SpartanX.Database.SpartanXContext context)
        {
            context.Database.Migrate();
            //dodavanje podataka
            if (!context.Skladista.Any(x=>x.Naziv == "Sarajevo"))
            {
                context.Skladista.Add(new Database.Skladistum { Naziv = "Sarajevo", Adresa = "Ložionička 17", Opis = "Skladište za elite opremu" });
            }
            if (!context.Skladista.Any(x => x.Naziv == "Zenica"))
            {
                context.Skladista.Add(new Database.Skladistum { Naziv = "Zenica", Adresa = "Industrijska zona 12", Opis = "Skladište fitnes opreme" });
            }
            if (!context.Skladista.Any(x => x.Naziv == "Tuzla"))
            {
                context.Skladista.Add(new Database.Skladistum { Naziv = "Tuzla", Adresa = "Industrijska zona 10", Opis = "Skladište spartan nutrition prehrambenih proizvoda" });
            }
            if (!context.Uloges.Any(x => x.Naziv == "Administrator"))
            {
                context.Uloges.Add(new Database.Uloge { Naziv = "Administrator", Opis = "Administratorske privilegije"});
            }
            if (!context.Uloges.Any(x => x.Naziv == "Menadžer"))
            {
                context.Uloges.Add(new Database.Uloge { Naziv = "Menadžer", Opis = "Upravljanje desktop aplikacijom" });
            }
            if (!context.VrstaProizvoda.Any(x => x.Naziv == "Ostalo"))
            {
                context.VrstaProizvoda.Add(new Database.VrstaProizvodum { Naziv = "Ostalo"});
            }
            if (!context.VrstaProizvoda.Any(x => x.Naziv == "Bjelancevine"))
            {
                context.VrstaProizvoda.Add(new Database.VrstaProizvodum { Naziv = "Bjelancevine" });
            }
            if (!context.VrstaProizvoda.Any(x => x.Naziv == "Fitness oprema"))
            {
                context.VrstaProizvoda.Add(new Database.VrstaProizvodum { Naziv = "Fitness oprema" });
            }
            if (!context.VrstaProizvoda.Any(x => x.Naziv == "Vitamini i dodaci"))
            {
                context.VrstaProizvoda.Add(new Database.VrstaProizvodum { Naziv = "Vitamini i dodaci" });
            }
            if (!context.Proizvodjacis.Any(x => x.Naziv == "SpartanX"))
            {
                context.Proizvodjacis.Add(new Database.Proizvodjaci { Naziv = "SpartanX" });
            }
            if (!context.Proizvodjacis.Any(x => x.Naziv == "Elite nutrition"))
            {
                context.Proizvodjacis.Add(new Database.Proizvodjaci { Naziv = "Elite nutrition" });
            }
            if (!context.Proizvodjacis.Any(x => x.Naziv == "Impact"))
            {
                context.Proizvodjacis.Add(new Database.Proizvodjaci { Naziv = "Impact" });
            }
            if (!context.Proizvodjacis.Any(x => x.Naziv == "Mammut"))
            {
                context.Proizvodjacis.Add(new Database.Proizvodjaci { Naziv = "Mammut" });
            }
            if (context.Korisnicis.Count() == 0)
            {
                var salt = KorisniciService.GenerateSalt();
                var passHash = KorisniciService.GenerateHash(salt, "admin123");
                var tip = new List<Korisnici>
                {
                    //new Korisnici { Ime="Admin", Prezime="Admin",Email="admin@leet.com"  ,KorisnickoIme="admin", LozinkaHash =passHash ,LozinkaSalt = salt },
                    new Korisnici { Ime="Gengar", Prezime="Pokemon",Email="gengar@leet.com",  KorisnickoIme="6en6ar", LozinkaHash =passHash ,LozinkaSalt = salt },
                };

                foreach (var item in tip)
                {
                    context.Korisnicis.Add(item);
                }
                context.SaveChanges();
            }
            if (context.Kupcis.Count() == 0)
            {
                var salt = KupciService.GenerateSalt();
                var passHash = KupciService.GenerateHash(salt, "johndoe123");
                var tip = new List<Kupci>
                {
                    new Kupci { Ime="John", Prezime="Doe",Email="johndoe@leet.com",DatumRegistracije=DateTime.Now,  KorisnickoIme="john", LozinkaHash =passHash ,LozinkaSalt = salt },
                };

                foreach (var item in tip)
                {
                    context.Kupcis.Add(item);
                }
                context.SaveChanges();
            }
            if (context.KorisnikUloges.Count() == 0)
            {
                var tip = new List<KorisnikUloge>
                {
                    new KorisnikUloge {KorisnikId=1, Datum=DateTime.Now, UlogaId=1}
                };
                foreach (var item in tip)
                {
                    context.KorisnikUloges.Add(item);
                }
                context.SaveChanges();
            }
            context.SaveChanges();

        }
    }
}
