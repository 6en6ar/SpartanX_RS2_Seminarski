using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SpartanX.MobileApp.ViewModels
{
    public class RegistracijaViewModel :BaseViewModel
    {
        private readonly APIService _service = new APIService("Kupci");
        public RegistracijaViewModel()
        {
            RegistrujKomanda  = new Command(async () =>
            {
                await Registracija();
            });
        }
        public ICommand RegistrujKomanda { get; set; }
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _korisnickoime = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoime; }
            set { SetProperty(ref _korisnickoime, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        string _potvrda = string.Empty;
        public string Potvrda
        {
            get { return _potvrda; }
            set { SetProperty(ref _potvrda, value); }
        }



        public async Task Registracija()
        {
            try
            {
                ModelSpartanX.Requests.KupciInsertRequest request = new ModelSpartanX.Requests.KupciInsertRequest();
                request.DatumRegistracije = DateTime.Now;
                request.Ime = Ime;
                request.Prezime = Prezime;
                request.KorisnickoIme = KorisnickoIme;
                request.Email = Email;
                request.Status = true;
                request.Password = Password;
                request.PasswordPotvrda = Potvrda;


                await _service.Insert<ModelSpartanX.Kupci>(request);


                await App.Current.MainPage.Navigation.PopAsync();
                await App.Current.MainPage.DisplayAlert("Uspjeh", "Uspjesna registracija", "OK");
            }
            catch(Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");
            }



        }
    }
}
