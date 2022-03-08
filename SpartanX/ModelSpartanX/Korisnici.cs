using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSpartanX
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            //KorisnikUloges = new HashSet<KorisnikUloge>();

        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public bool? Status { get; set; }

        public List<KorisniciUloge> KorisnikUloges { get; set; } // change to ICollection virtual
 


    }
}
