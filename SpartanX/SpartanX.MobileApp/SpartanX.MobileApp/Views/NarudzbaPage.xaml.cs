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

        private void Button_Clicked(object sender, EventArgs e)
        {
            model.NarudzbaLista.Clear();
            Services.KosaricaService.Cart.Clear();
            App.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste otkazali narudzbu", "OK");
            BrArt.Text = "Broj artikala: 0";
            Iznos.Text = "Iznos narudžbe: 0";

        }
    }
}