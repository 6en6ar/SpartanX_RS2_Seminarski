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
    public partial class frmProizvodiPrikaz : Form
    {
        APIService _vrstaPro = new APIService("VrstaProizvoda");
        public frmProizvodiPrikaz()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void frmProizvodiPrikaz_Load(object sender, EventArgs e)
        {
            await LoadVrstaProizvoda();
        }
        private async Task LoadVrstaProizvoda()
        {
            var result = await _vrstaPro.Get<List<Model.VrstaProizvoda>>(null);
            cmbvrsta.DataSource = result;
            cmbvrsta.DisplayMember = "Naziv";
            cmbvrsta.ValueMember = "VrstaId";
        }
    }
}
