using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelSpartanX.Requests
{
    public class KorisniciUpdateRequest
    {
        //[Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }
        //[Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        [EmailAddress]
        //[Required]
        //[MinLength(5)]
        public string Email { get; set; }
        //[Required(AllowEmptyStrings = false)]
        //public string Telefon { get; set; }
        //[Required(AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }
        public bool? Status { get; set; }

    }
}
