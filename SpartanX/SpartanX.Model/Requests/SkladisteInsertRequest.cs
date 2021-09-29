using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpartanX.Model.Requests
{
    public class SkladisteInsertRequest
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
