using SpartanX.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SpartanX.MobileApp.ViewModels
{
    public class LoginPageViewModel :BaseViewModel
    {
        string username = string.Empty;
        private readonly APIService service = new APIService("Kupci");
        public LoginPageViewModel()
        {
            LoginCommand = new Command(async () =>
            {
            await Login();
            });
        }
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }
        string password = string.Empty;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }
        public ICommand LoginCommand { get; set; }


        async Task Login()
        {
            try
            {
                ModelSpartanX.Kupci klijent = await service.Authenticate<ModelSpartanX.Kupci>(username, password);
                if (klijent != null)
                    
                {
                    GlobalKorisnik.GlobalKorisnik.Prijavljeni = klijent;
                    APIService.username = username;
                    APIService.password = password;
                    await App.Current.MainPage.DisplayAlert("Uspjeh!", "Dobrodosli ", "OK");
                    App.Current.MainPage = new AppShell();
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Greska!", "Pogresan username ili password", "OK");
                }
               

            }
            catch(Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Greska", ex.Message, "OK");

            }
        }
    }
}
