using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class NarudzbaStavke
    {
        public int NarudzbaStavkaId { get; set; }
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }

        public virtual Narudzbe Narudzba { get; set; }
        public virtual Proizvodi Proizvod { get; set; }
    }
}
