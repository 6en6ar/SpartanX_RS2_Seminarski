using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class Skladistum
    {
        public Skladistum()
        {
            Nabavkas = new HashSet<Nabavka>();
            Narudzbes = new HashSet<Narudzbe>();
        }

        public int SkladisteId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Nabavka> Nabavkas { get; set; }
        public virtual ICollection<Narudzbe> Narudzbes { get; set; }
    }
}
