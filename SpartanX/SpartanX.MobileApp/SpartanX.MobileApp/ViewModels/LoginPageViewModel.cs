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
        private readonly APIService service = new APIService("Korisnici");
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
            APIService.username = username;
            APIService.password = password;
            try
            {
                await service.Get<dynamic>(null);
                App.Current.MainPage = new AboutPage();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
