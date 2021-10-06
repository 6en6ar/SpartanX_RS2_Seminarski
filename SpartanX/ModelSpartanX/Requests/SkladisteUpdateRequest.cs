using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelSpartanX.Requests
{
     public class SkladisteUpdateRequest
    {
        [Required]
        [MinLength(3)]
        public string Naziv { get; set; }
        [Required]
        [MinLength(3)]
        public string Adresa { get; set; }
        public string Opis { get; set; }
    }
}
