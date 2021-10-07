using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SpartanX.MobileApp.ViewModels
{
    public class ProizvodiViewModel
    {
        public ProizvodiViewModel()
        {
            komanda = new Command(async () => await Init());
        }
        private readonly APIService _service = new APIService("Proizvodi");
        public ObservableCollection<ModelSpartanX.Proizvodi> ListaProizvoda { get; set; } = new ObservableCollection<ModelSpartanX.Proizvodi>();
        public ICommand komanda { get; set; }
        public async Task Init()
        {
            var lista = await _service.Get<IEnumerable<ModelSpartanX.Proizvodi>>(null);
            //prvo cistimo proizvode prije refresha
            ListaProizvoda.Clear();
            foreach (var item in lista)
            {
                ListaProizvoda.Add(item);
            }
        }
        
    }
}
