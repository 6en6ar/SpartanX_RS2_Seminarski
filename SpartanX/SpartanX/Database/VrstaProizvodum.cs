using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class VrstaProizvodum
    {
        public VrstaProizvodum()
        {
            Proizvodis = new HashSet<Proizvodi>();
        }

        public int VrstaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvodi> Proizvodis { get; set; }
    }
}
