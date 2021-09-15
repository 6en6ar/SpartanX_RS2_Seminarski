using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class Kupci
    {
        public Kupci()
        {
            Komentars = new HashSet<Komentar>();
            Narudzbes = new HashSet<Narudzbe>();
            Racuns = new HashSet<Racun>();
        }

        public int KupacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Komentar> Komentars { get; set; }
        public virtual ICollection<Narudzbe> Narudzbes { get; set; }
        public virtual ICollection<Racun> Racuns { get; set; }
    }
}
