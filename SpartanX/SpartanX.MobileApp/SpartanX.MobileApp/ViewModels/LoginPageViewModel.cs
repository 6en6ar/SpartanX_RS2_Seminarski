using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SpartanX.MobileApp.ViewModels
{
    public class LoginPageViewModel :BaseViewModel
    {
        string username = string.Empty;
        public LoginPageViewModel()
        {
            LoginCommand = new Command(() =>
            {
                Username = "Changed";
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
    }
}
