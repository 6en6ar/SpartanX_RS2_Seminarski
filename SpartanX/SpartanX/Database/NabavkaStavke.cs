using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class NabavkaStavke
    {
        public int NabavkaStavkeId { get; set; }
        public int NabavkaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }

        public virtual Nabavka Nabavka { get; set; }
        public virtual Proizvodi Proizvod { get; set; }
    }
}
