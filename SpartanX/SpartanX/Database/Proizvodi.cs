using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class Proizvodi
    {
        public Proizvodi()
        {
            Komentars = new HashSet<Komentar>();
            NabavkaStavkes = new HashSet<NabavkaStavke>();
            NarudzbaStavkes = new HashSet<NarudzbaStavke>();
        }

        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public string Kod { get; set; }
        public decimal Cijena { get; set; }
        public int VrstaId { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool Status { get; set; }
        public int ProizvodjacId { get; set; }
        public int BodoviLojalnosti { get; set; }

        public virtual Proizvodjaci Proizvodjac { get; set; }
        public virtual VrstaProizvodum Vrsta { get; set; }
        public virtual ICollection<Komentar> Komentars { get; set; }
        public virtual ICollection<NabavkaStavke> NabavkaStavkes { get; set; }
        public virtual ICollection<NarudzbaStavke> NarudzbaStavkes { get; set; }
    }
}
