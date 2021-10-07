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
        private readonly APIService _Pservice = new APIService("Proizvodi");
        private readonly APIService _VPservice = new APIService("VrsteProizvoda");
        public ObservableCollection<ModelSpartanX.Proizvodi> ListaProizvoda { get; set; } = new ObservableCollection<ModelSpartanX.Proizvodi>();
        public ObservableCollection<ModelSpartanX.VrstaProizvoda> ListaVrsteProizvoda { get; set; } = new ObservableCollection<ModelSpartanX.VrstaProizvoda>();
        public ICommand komanda { get; set; }
        public async Task Init()
        {
            if(ListaVrsteProizvoda.Count == 0)
            {
                var VPlista = await _VPservice.Get<IEnumerable<ModelSpartanX.VrstaProizvoda>>(null);

                foreach (var item in VPlista)
                {
                    ListaVrsteProizvoda.Add(item);
                }
            }
           
            var Plista = await _Pservice.Get<IEnumerable<ModelSpartanX.Proizvodi>>(null);
            //prvo cistimo proizvode prije refresha
            ListaProizvoda.Clear();
            foreach (var item in Plista)
            {
                ListaProizvoda.Add(item);
            }
        }
        
    }
}
