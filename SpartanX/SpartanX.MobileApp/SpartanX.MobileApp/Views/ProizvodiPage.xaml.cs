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
    public partial class ProizvodiPage : ContentPage
    {
        private ProizvodiViewModel model;
        public ProizvodiPage()
        {
            InitializeComponent();
            BindingContext = model = new ProizvodiViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
             await model.Init();
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = e.SelectedItem as ModelSpartanX.Proizvodi;
            await Navigation.PushAsync(new ProizvodiDetalji(selectedItem));
        }
    }
   
}