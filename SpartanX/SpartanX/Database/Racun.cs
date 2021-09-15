using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class Racun
    {
        public string RacunId { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime DatumRacuna { get; set; }
        public int KorisnikId { get; set; }
        public bool Zakljucen { get; set; }
        public int NarudzbaId { get; set; }
        public bool Poslano { get; set; }
        public int KupacId { get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual Kupci Kupac { get; set; }
        public virtual Narudzbe Narudzba { get; set; }
    }
}
