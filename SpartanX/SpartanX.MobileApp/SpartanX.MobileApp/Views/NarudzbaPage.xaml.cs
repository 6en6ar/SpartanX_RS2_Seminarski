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
        private decimal PDV = 0.17M;
        private APIService _NarudzbaService = new APIService("Narudzbe");
        private APIService _KupciService = new APIService("Kupci");
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
            try
            {
                ModelSpartanX.Kupci kupac = await _KupciService.Authenticate<ModelSpartanX.Kupci>(APIService.username, APIService.password);
                if (kupac == null)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska!", "Niste autentifikovani", "OK");
                }
                else
                {
                    //get sve narudzbe
                    var lista = await _NarudzbaService.Get<List<ModelSpartanX.Narudzbe>>(null);
                    int najveci = int.MinValue;
                    foreach (var item in lista)
                    {

                        if (item.NarudzbaId > najveci)
                        {
                            najveci = item.NarudzbaId;
                        }
                    }
                    int BrojN = najveci + 1;
                    string novaNarudzba = Helper.NarudzbaGenerator.Generator(BrojN);
                    // kreirati narudzbu
                    ModelSpartanX.Requests.NarudzbeInsertRequest req = new ModelSpartanX.Requests.NarudzbeInsertRequest();
                    req.BrojNarudzbe = novaNarudzba;
                    req.DatumNarudzbe = DateTime.Now;
                    req.KupacId = GlobalKorisnik.GlobalKorisnik.Prijavljeni.KupacId;
                    req.SkladisteId = 1;
                    req.Otkazano = false;
                    req.Status = true;
                    foreach (var item in model.NarudzbaLista)
                    {
                        ModelSpartanX.Requests.NarudzbaStavkeInsertRequest requestStavka = new ModelSpartanX.Requests.NarudzbaStavkeInsertRequest();

                        requestStavka.Cijena = item.proizvod.Cijena;
                        requestStavka.ProizvodId = item.proizvod.ProizvodId;
                        requestStavka.Kolicina = item.Kolicina;
                        //dodati bodove lojalnosti
                        requestStavka.Popust = 0;
                        req.IznosBezPdv += requestStavka.Cijena * requestStavka.Kolicina;
                        req.IznosSaPdv += req.IznosBezPdv + req.IznosBezPdv * PDV;

                        req.stavke.Add(requestStavka);

                    }
                    //insert narudzbu
                    await _NarudzbaService.Insert<ModelSpartanX.Narudzbe>(req);


                    //display success
                    model.NarudzbaLista.Clear();
                    Services.KosaricaService.Cart.Clear();
                    await App.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste napravili narudzbu", "OK");
                    BrArt.Text = "Broj artikala: 0";
                    Iznos.Text = "Iznos narudžbe: 0";
                    //preusmjeri na stripe
                    await Navigation.PushAsync(new StripePaymentGatewayPage(model.PuniIznos));

                }
            }
            catch
            {

            }
           
        }
    }
}