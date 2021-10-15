using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSpartanX.Requests
{
    public partial class NarudzbaStavkeInsertRequest
    {
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }
    }
}
