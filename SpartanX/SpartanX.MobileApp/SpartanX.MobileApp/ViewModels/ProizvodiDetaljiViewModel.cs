using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SpartanX.MobileApp.ViewModels
{
    public class ProizvodiDetaljiViewModel : BaseViewModel
    {
        public ICommand PovecajKolicinuKomanda { get; set; }
        public ICommand NaruciKomanda { get; set; }
        public ModelSpartanX.Proizvodi proizvod { get; set; }
        public ProizvodiDetaljiViewModel()
        {
            PovecajKolicinuKomanda = new Command(() => Kolicina += 1);
            //NaruciKomanda = new Command(Naruci);
        }
        decimal kolicina = 0;
        public decimal Kolicina
        {
            get { return kolicina; }
            set { SetProperty(ref kolicina, value); }
        }       
        private void Naruci()
        {
        }
    }
}
