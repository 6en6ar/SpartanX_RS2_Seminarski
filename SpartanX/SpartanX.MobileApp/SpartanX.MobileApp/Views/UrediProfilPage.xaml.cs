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
    public partial class UrediProfilPage : ContentPage
    {
        APIService service = new APIService("Kupci");
        public UrediProfilViewmodel model { get; set; }
        public UrediProfilPage()
        {
            InitializeComponent();
            BindingContext = model = new UrediProfilViewmodel();

        }

        private async void Update_Clicked(object sender, EventArgs e)
        {
            //List<ModelSpartanX.Kupci> lista = await service.Get<List<ModelSpartanX.Kupci>>(null);
            //bool vecPostojiIme = false;
            //bool vecPostojiMail = false;
            //foreach (var item in lista)
            //{
            //    if (item.KorisnickoIme.Equals(inputKorIme.Text) == true && APIService.username != inputKorIme.Text)
            //    {
            //        vecPostojiIme = true;
            //    }
            //    if (item.Email.Equals(inputMail.Text) == true)
            //    {
            //        vecPostojiMail = true;
            //    }
            //}
            //if (vecPostojiIme || vecPostojiMail)
            //{
            //    await DisplayAlert("Greska", "Korisnik sa tim korisnickim imenom ili mailom vec postoji", "OK");
            //    KImeError.Text = "Korisnicko ime je vec registrovano!";
            //    KImeError.IsVisible = true;
            //}
            ////else if (vecPostojiMail)
            ////{
            ////    await DisplayAlert("Greska", "Korisnik sa tim emailom vec postoji", "OK");
            ////    erroMail.Text = "Email vec registrovan!";
            ////    erroMail.IsVisible = true;

            ////}
            //else
            //{

                await model.Uredi();
            //}
        }
    }
}