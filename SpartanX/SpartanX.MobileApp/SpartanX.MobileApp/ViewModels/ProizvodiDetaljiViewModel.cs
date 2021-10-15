using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SpartanX.MobileApp.ViewModels
{
    public class ProizvodiDetaljiViewModel : BaseViewModel
    {
        public ICommand PovecajKolicinuKomanda { get; set; }
        public ICommand PreporuciKomanda { get; set; }
        public ICommand NaruciKomanda { get; set; }
        private readonly APIService _Pservice = new APIService("Proizvodi");
        public ObservableCollection<ModelSpartanX.Proizvodi> PreporuceniProizvodiLista { get; set; } = new ObservableCollection<ModelSpartanX.Proizvodi>();

        public ModelSpartanX.Proizvodi proizvod { get; set; }
        public ProizvodiDetaljiViewModel()
        {
            PovecajKolicinuKomanda = new Command(() => Kolicina += 1);
            NaruciKomanda = new Command(Naruci);
            PreporuciKomanda = new Command(async () => await Recommend());
        }
        int kolicina = 0;
        public int Kolicina
        {
            get { return kolicina; }
            set { SetProperty(ref kolicina, value); }
        }       
        private void Naruci()
        {
            if(Kolicina > 0)
            {
                if (Services.KosaricaService.Cart.ContainsKey(proizvod.ProizvodId))
                {
                    Services.KosaricaService.Cart.Remove(proizvod.ProizvodId);
                }
                Services.KosaricaService.Cart.Add(proizvod.ProizvodId, this);
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Greška", "Molimo unesite validnu količinu", "OK");
            }
        }
        private async Task Recommend()
        {
            var listaPreproucenih = await _Pservice.Recommend<IEnumerable<ModelSpartanX.Proizvodi>>(proizvod.ProizvodId);
            foreach (var item in listaPreproucenih)
            {
                PreporuceniProizvodiLista.Add(item);
            }

        }
    }
}
