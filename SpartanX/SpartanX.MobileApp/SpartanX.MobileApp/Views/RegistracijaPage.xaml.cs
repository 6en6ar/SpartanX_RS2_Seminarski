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
    public partial class RegistracijaPage : ContentPage
    {
        APIService service = new APIService("Kupci");
        RegistracijaViewModel model = null;
        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = model = new RegistracijaViewModel();
        }
        private async void RegistracijaClicked(object sender, EventArgs e)
        {
            //List<ModelSpartanX.Kupci> lista = await service.GetKupce<List<ModelSpartanX.Kupci>>(null, APIService.username, APIService.password);
            List<ModelSpartanX.Kupci> lista = await service.Get<List<ModelSpartanX.Kupci>>(null);
            if(lista != null)
            {
                bool vecPostojiIme = false;
                bool vecPostojiMail = false;
                foreach (var item in lista)
                {
                    if (item.KorisnickoIme.Equals(inputKIme.Text) == true)
                    {
                        vecPostojiIme = true;
                    }
                    if (item.Email.Equals(inputMail.Text) == true)
                    {
                        vecPostojiMail = true;
                    }
                }

                if (ProvjeriRegistraciju())
                    {
                        if (vecPostojiIme)
                        {
                            await DisplayAlert("Greska", "Korisnik sa tim korisnickim imenom vec postoji", "OK");
                            KimeError.Text = "Korisnicko ime je vec registrovano!";
                            KimeError.IsVisible = true;
                        }
                        else if (vecPostojiMail)
                        {
                            await DisplayAlert("Greska", "Korisnik sa tim emailom vec postoji", "OK");
                            mailError.Text = "Email vec registrovan!";
                            mailError.IsVisible = true;

                        }
                        else
                        {

                            await model.Registracija();
                        }
                    }
                    else
                    {
                        await DisplayAlert("Greska", "Podaci nisu ispravni", "OK");

                    }

                
            }

        }
        private bool ProvjeriRegistraciju()
        {
            bool provjeri = true;

            if (ProvjeriIme() == false)
                provjeri = false;
            if (ProvjeriPrezime() == false)
                provjeri = false;
            if (ProvjeriKorIme() == false)
                provjeri = false;
            if (ProvjerLozinku() == false)
                provjeri = false;
            if (ProvjeriPotvrdu() == false)
                provjeri = false;

            if (provjeri == false)
            {
                return false;
            }
            else
            {
                return true;
            };
        }
        private bool ProvjeriIme()
        {
            if (inputIme.Text == "")
            {

                imeError.Text = "Molimo unesite ime!";
                imeError.IsVisible = true;
                return false;
            }
            else
            {

                imeError.IsVisible = false;
                imeError.Text = "";
                return true;
            }
        }
        private bool ProvjeriPrezime()
        {
            if (inputPrezime.Text == "")
            {
                prezimeError.Text = "Molimo unesite prezime!";
                prezimeError.IsVisible = true;
                return false;
            }
            else
            {

                prezimeError.IsVisible = false;
                prezimeError.Text = "";
                return true;
            }
        }
        private bool ProvjeriKorIme()
        {
            if (inputKIme.Text == "")
            {
                KimeError.Text = "Korisničko ime obavezno!";
                KimeError.IsVisible = true;
                return false;
            }
            return true;
        }
        private bool ProvjerLozinku()
        {
            if (inputPassword.Text == "")
            {

                lozinkaError.Text = "Lozinka obavezna!";
                lozinkaError.IsVisible = true;
                return false;
            }
            if (inputPassword.Text.Count() < 6)
            {

                lozinkaError.Text = "Lozinka treba imati najmanje 6 karaktera!";
                lozinkaError.IsVisible = true;
                return false;
            }
            if (inputPassword.Text == inputKIme.Text)
            {

                lozinkaError.Text = "Lozinka i korisnicko ime su isti!";
                lozinkaError.IsVisible = true;
                return false;
            }
            else
            {

                lozinkaError.IsVisible = false;
                lozinkaError.Text = "";
                return true;
            }
        }
        private bool ProvjeriPotvrdu()
        {
            if (inputPassword.Text != inputPotvrda.Text)
            {

                potvrdaError.Text = "Loznike nisu iste!";
                potvrdaError.IsVisible = true;
                return false;
            }
            else
            {
                potvrdaError.Text = "";
                potvrdaError.IsVisible = false;
                return true;
            }
        }

    }
}