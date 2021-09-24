using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanX.Model
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

       // public virtual ICollection<KorisnikUloge> KorisnikUloges { get; set; }
 


    }
}
