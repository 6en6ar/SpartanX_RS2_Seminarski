using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SpartanX.MobileApp.ViewModels
{
    public class UrediProfilViewmodel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Kupci");
        public UrediProfilViewmodel()
        {
            UrediKomanda = new Command(async () => await Uredi());
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
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        public ICommand UrediKomanda { get; set; }
        public async Task Uredi()
        {
            try
            {
                ModelSpartanX.Requests.KupciUpdateRequest request = new ModelSpartanX.Requests.KupciUpdateRequest();
                request.KorisnickoIme = KorisnickoIme;
                request.Email = Email;
                request.Password = Password;
                request.PasswordPotvrda = Potvrda;
                if(Password != Potvrda)
                {
                    throw new Exception("Passwordi se ne poklapaju");
                }


                await _service.Update<ModelSpartanX.Kupci>(GlobalKorisnik.GlobalKorisnik.Prijavljeni.KupacId, request, APIService.username,APIService.password);


                //await App.Current.MainPage.Navigation.PopAsync();
                await App.Current.MainPage.DisplayAlert("Uspjeh", "Uspjesno promjenjeni podaci", "OK");
            }
            catch(Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Greska", $"Došlo je do greške prilikom mijenjanja podataka --> {ex.Message}", "OK");
            }
        }
    }
}
