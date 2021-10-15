using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelSpartanX.Requests
{
   public partial class KupciInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false)]
        public DateTime DatumRegistracije { get; set; }
        [EmailAddress]
        [Required]
        [MinLength(5)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(5)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(5)]
        public string PasswordPotvrda { get; set; }
        public bool Status { get; set; }
    }
}
