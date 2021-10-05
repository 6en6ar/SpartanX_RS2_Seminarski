using SpartanX.MobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SpartanX.MobileApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}