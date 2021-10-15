using SpartanX.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpartanX.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NarudzbaPage : ContentPage
    {
        NarudzbaViewModel model = null;
        private APIService _NarudzbaService = new APIService("Narudzbe");
        public NarudzbaPage()
        {
           
            InitializeComponent();
            BindingContext = model = new NarudzbaViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        private async void Otkazi_Clicked(object sender, EventArgs e)
        {
            model.NarudzbaLista.Clear();
            Services.KosaricaService.Cart.Clear();
            await App.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste otkazali narudzbu", "OK");
            BrArt.Text = "Broj artikala: 0";
            Iznos.Text = "Iznos narudžbe: 0";

        }

        private async void Zakljuci_Clicked(object sender, EventArgs e)
        {
            //get sve narudzbe
            var lista = await _NarudzbaService.Get<List<ModelSpartanX.Narudzbe>>(null);
            // kreirati narudzbu

            //display success
            model.NarudzbaLista.Clear();
            Services.KosaricaService.Cart.Clear();
            await App.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste napravili narudzbu", "OK");
            BrArt.Text = "Broj artikala: 0";
            Iznos.Text = "Iznos narudžbe: 0";
            //preusmjeri na stripe

        }
    }
}