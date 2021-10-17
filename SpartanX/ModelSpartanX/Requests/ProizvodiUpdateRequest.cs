using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSpartanX.Requests
{
    public class ProizvodiUpdateRequest
    {
        public string Naziv { get; set; }
        public string Kod { get; set; }
        public decimal Cijena { get; set; }
        public int VrstaId { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool Status { get; set; }
        public int ProizvodjacId { get; set; }
        public int BodoviLojalnosti { get; set; }
    }
}
