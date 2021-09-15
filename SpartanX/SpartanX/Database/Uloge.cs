using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class Uloge
    {
        public Uloge()
        {
            KorisnikUloges = new HashSet<KorisnikUloge>();
        }

        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<KorisnikUloge> KorisnikUloges { get; set; }
    }
}
