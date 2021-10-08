using SpartanX.MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SpartanX.MobileApp.ViewModels
{
    public class NarudzbaViewModel : BaseViewModel
    {
        public ObservableCollection<ProizvodiDetaljiViewModel> ProizvodiLista { get; set; } = new ObservableCollection<ProizvodiDetaljiViewModel>();
        public void Init()
        {
            ProizvodiLista.Clear();
            foreach (var item in KosaricaService.Cart)
            {
                ProizvodiLista.Add(item.Value);
            }
        }
        public ModelSpartanX.Proizvodi Proizvod { get; set; }


    }
}
