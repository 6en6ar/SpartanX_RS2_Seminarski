using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelSpartanX.Requests
{
    public class DobavljaciInsertRequest
    {

        [Required]
        [MinLength(3)]
        public string Naziv { get; set; }
        [Required]
        public string KontaktOsoba { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public string ZiroRacuni { get; set; }
        public string Napomena { get; set; }
        public bool Status { get; set; }
    }
}
