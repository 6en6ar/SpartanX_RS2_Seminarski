using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            KorisnikUloges = new HashSet<KorisnikUloge>();
            Nabavkas = new HashSet<Nabavka>();
            Racuns = new HashSet<Racun>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<KorisnikUloge> KorisnikUloges { get; set; }
        public virtual ICollection<Nabavka> Nabavkas { get; set; }
        public virtual ICollection<Racun> Racuns { get; set; }
    }
}
