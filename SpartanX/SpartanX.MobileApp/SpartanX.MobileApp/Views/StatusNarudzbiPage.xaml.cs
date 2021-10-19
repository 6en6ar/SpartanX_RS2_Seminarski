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
    public partial class StatusNarudzbiPage : ContentPage
    {
        private StatusNarudzbiViewModle model;
        public StatusNarudzbiPage()
        {
            InitializeComponent();
            BindingContext = model = new StatusNarudzbiViewModle();
        }
        protected async override void OnAppearing()
        {
            
            base.OnAppearing();
            await model.Init();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}