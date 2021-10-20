using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SpartanX.MobileApp.ViewModels
{
   public class StatusNarudzbiViewModle : BaseViewModel
    {
        public StatusNarudzbiViewModle()
        {
            InitCommand = new Command(async () => await Init());
        }
        private readonly APIService _NarudzbeSer = new APIService("Narudzbe");
        public ObservableCollection<ModelSpartanX.Narudzbe> ListaNarudzbi { get; set; } = new ObservableCollection<ModelSpartanX.Narudzbe>();
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
           List<ModelSpartanX.Narudzbe> lista = await  _NarudzbeSer.Get<List<ModelSpartanX.Narudzbe>>(null);
            ListaNarudzbi.Clear();
            foreach (var item in lista)
            {
                //za logiranog korisnika narudzbe
                if(item.KupacId == GlobalKorisnik.GlobalKorisnik.Prijavljeni.KupacId)
                {
                    if (item.Status)
                    {
                        item.PosiljkaOpis = "Posiljka je na putu";
                    }
                    else
                    {
                        item.PosiljkaOpis = "Posiljka je još u obradi!";
                    }
                    ListaNarudzbi.Add(item);
                    
                }
              
            }
        }
      
    }
}
