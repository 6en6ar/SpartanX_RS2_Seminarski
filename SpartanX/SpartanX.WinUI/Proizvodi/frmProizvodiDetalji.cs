using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpartanX.WinUI.Proizvodi
{
    public partial class frmProizvodiDetalji : Form
    {
        APIService _proizvodjaci = new APIService("Proizvodjaci");
        APIService _vrste = new APIService("VrsteProizvoda");// kreirati controller i service!
        public frmProizvodiDetalji()
        {
            InitializeComponent();
        }

        private async void frmProizvodiDetalji_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
             await LoadProizvodjace();
             await LoadVrsteProizvoda();
            
        }
        private async Task LoadProizvodjace()
        {
            var result = await _proizvodjaci.Get<List<Model.Proizvodjaci>>(null);
            result.Insert(0, new Model.Proizvodjaci());
            cmbProizvodjaci.DataSource = result;
            cmbProizvodjaci.DisplayMember = "Naziv";
            cmbProizvodjaci.ValueMember = "ProizvodjacId";
        }
        private async Task LoadVrsteProizvoda()
        {
            var result = await _proizvodjaci.Get<List<Model.VrstaProizvoda>>(null);
            result.Insert(0, new Model.VrstaProizvoda());
            cmbVrsta.DataSource = result;
            cmbVrsta.DisplayMember = "Naziv";
            cmbVrsta.ValueMember = "VrstaId";
        }
    }
}
