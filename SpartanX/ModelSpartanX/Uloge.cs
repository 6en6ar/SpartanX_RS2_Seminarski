using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSpartanX
{
    public class Uloge
    {
        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public List<int> listauloga { get; set; } = new List<int>();
    }
}
