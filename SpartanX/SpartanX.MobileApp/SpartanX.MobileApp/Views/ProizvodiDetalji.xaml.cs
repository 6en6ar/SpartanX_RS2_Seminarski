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
    public partial class ProizvodiDetalji : ContentPage
    {
        private ProizvodiDetaljiViewModel model = null;
        public ProizvodiDetalji( ModelSpartanX.Proizvodi _proizvod)
        {
            InitializeComponent();
            BindingContext = model = new ProizvodiDetaljiViewModel() {proizvod = _proizvod };
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if(model.Kolicina > 0)
            {
                App.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste dodali artikal u košaricu", "OK");
            }

        }

        private void preporuceniProizvodi_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NarudzbaPage());
        }
    }
}