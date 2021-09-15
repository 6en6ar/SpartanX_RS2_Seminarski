using System;
using System.Collections.Generic;

#nullable disable

namespace SpartanX.Database
{
    public partial class Nabavka
    {
        public Nabavka()
        {
            NabavkaStavkes = new HashSet<NabavkaStavke>();
        }

        public int NabavkaId { get; set; }
        public string BrojNabavke { get; set; }
        public DateTime DatumNabavke { get; set; }
        public decimal IznosRacuna { get; set; }
        public decimal Pdv { get; set; }
        public string Napomena { get; set; }
        public int SkladisteId { get; set; }
        public int KorisnikId { get; set; }
        public int DobavljacId { get; set; }

        public virtual Dobavljaci Dobavljac { get; set; }
        public virtual Korisnici Korisnik { get; set; }
        public virtual Skladistum Skladiste { get; set; }
        public virtual ICollection<NabavkaStavke> NabavkaStavkes { get; set; }
    }
}
