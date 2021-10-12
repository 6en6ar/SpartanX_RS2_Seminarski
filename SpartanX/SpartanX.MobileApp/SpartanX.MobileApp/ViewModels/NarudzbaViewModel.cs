using SpartanX.MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SpartanX.MobileApp.ViewModels
{
    public class NarudzbaViewModel : BaseViewModel
    {
        public ObservableCollection<ProizvodiDetaljiViewModel> NarudzbaLista { get; set; } = new ObservableCollection<ProizvodiDetaljiViewModel>();
        decimal brojProizvoda = 0;

        public ICommand PovecajKolicinuKomanda { get; set; }
        public NarudzbaViewModel()
        {
            //PovecajKolicinuKomanda = new Command(() => Kolicina += 1);
        }

        public decimal BrojProizvoda
        {
            get { return brojProizvoda; }
            set { SetProperty(ref brojProizvoda, value); }
        }
        decimal puniiznos = 0;

        public decimal PuniIznos
        {
            get { return puniiznos; }
            set { SetProperty(ref puniiznos, value); }
        }
        public void Init()
        {
            NarudzbaLista.Clear();
            foreach (var item in KosaricaService.Cart)
            {
                NarudzbaLista.Add(item.Value);
            }
            puniiznos = 0;
            foreach (var item in NarudzbaLista)
            {
                puniiznos += item.Kolicina * item.proizvod.Cijena;
            }
            BrojProizvoda = NarudzbaLista.Count;
            KosaricaService.Cart.Clear();
        }
        


    }
}
