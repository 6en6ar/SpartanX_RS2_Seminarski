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
    public partial class ProizvodiDetalji : ContentPage
    {
        ProizvodiDetaljiViewModel model = null;
        public ProizvodiDetalji( ModelSpartanX.Proizvodi _proizvod)
        {
            InitializeComponent();
            BindingContext = model = new ProizvodiDetaljiViewModel() {proizvod = _proizvod };
        }
    }
}