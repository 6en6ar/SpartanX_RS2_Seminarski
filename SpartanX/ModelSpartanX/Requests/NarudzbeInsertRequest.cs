using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSpartanX.Requests
{
    public partial class NarudzbeInsertRequest
    {
        public string BrojNarudzbe { get; set; }
        public int KupacId { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int SkladisteId { get; set; }
        public List<NarudzbaStavkeInsertRequest> stavke { get; set; } = new List<NarudzbaStavkeInsertRequest>();
    }
}
