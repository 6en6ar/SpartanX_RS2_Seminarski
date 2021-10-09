using System;
using System.Collections.Generic;
using System.Text;

namespace ModelSpartanX.Requests
{
   public partial class KupciInsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }
        public bool Status { get; set; }
    }
}
