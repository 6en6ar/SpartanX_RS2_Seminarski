using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSpartanX.Search
{
    public class ProizvodiSearchObject
    {
        public int? Id { get; set; }
        public string Naziv  { get; set; } 
        public string[] IncludeList { get; set; }
    }
}
