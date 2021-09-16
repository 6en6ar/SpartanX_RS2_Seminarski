using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanX.Model
{
    public partial class Skladista
    {
        public int SkladisteId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Opis { get; set; }
    }
}
