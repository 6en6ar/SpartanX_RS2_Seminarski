using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class KorisnikUloge
    {
        public int KorisnikUlogaId { get; set; }
        public int? KorisnikId { get; set; }
        public int? UlogaId { get; set; }
        public DateTime? Datum { get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual Uloge Uloga { get; set; }
    }
}
