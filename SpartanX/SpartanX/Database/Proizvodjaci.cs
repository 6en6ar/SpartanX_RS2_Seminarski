using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class Proizvodjaci
    {
        public Proizvodjaci()
        {
            Proizvodis = new HashSet<Proizvodi>();
        }

        public int ProizvodjacId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvodi> Proizvodis { get; set; }
    }
}
