using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSpartanX
{
   public partial class Narudzbe
    {
        public Narudzbe()
        {
           // NarudzbaStavkes = new HashSet<NarudzbaStavke>();
           // Racuns = new HashSet<Racun>();
        }

        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public int KupacId { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int SkladisteId { get; set; }
        public string PosiljkaOpis { get; set; }

        public virtual Kupci Kupac { get; set; }
        
        //public virtual Skladistum Skladiste { get; set; }
        public virtual ICollection<NarudzbaStavke> NarudzbaStavkes { get; set; }
        //public virtual ICollection<Racun> Racuns { get; set; }

    }
}
