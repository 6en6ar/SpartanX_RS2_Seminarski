using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class Komentar
    {
        public int KomentarId { get; set; }
        public int ProizvodId { get; set; }
        public int KupacId { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public int Ocjena { get; set; }

        public virtual Kupci Kupac { get; set; }
        public virtual Proizvodi Proizvod { get; set; }
    }
}
