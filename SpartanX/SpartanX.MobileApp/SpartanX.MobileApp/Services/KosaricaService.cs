using SpartanX.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpartanX.MobileApp.Services
{
   public class KosaricaService
    {
        public static Dictionary<int, ProizvodiDetaljiViewModel> Cart { get; set; } = new Dictionary<int, ProizvodiDetaljiViewModel>();

    }
}
