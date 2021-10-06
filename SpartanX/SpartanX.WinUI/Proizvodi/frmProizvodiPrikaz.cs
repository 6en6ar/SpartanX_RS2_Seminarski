using SpartanX.Model.Search;
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
        APIService _vrstaPro = new APIService("VrsteProizvoda");
        APIService _proizvodi = new APIService("Proizvodi");
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
            await LoadProizvodi();
           
        }

        private async Task LoadProizvodi(int VrstaProId = 0)
        {
            ModelSpartanX.Search.ProizvodiSearchObject req = new ModelSpartanX.Search.ProizvodiSearchObject();
            req.IncludeList = new string[]
            {
                "Proizvodjac",
                "Vrsta"
            };
            if (VrstaProId != 0)
            {
                req.Id = VrstaProId;
            }
            //dgvProizvodi.AutoGenerateColumns = false;
            
            dgvProizvodi.DataSource = await _proizvodi.Get<List<ModelSpartanX.Proizvodi>>(req);
            //var result = await _proizvodi.Get<List<Model.Proizvodi>>(null);
            //dgvProizvodi.DataSource = result;
        }

        private async Task LoadVrstaProizvoda()
        {
            var result = await _vrstaPro.Get<List<ModelSpartanX.VrstaProizvoda>>(null);
            result.Insert(0, new ModelSpartanX.VrstaProizvoda());
            cmbvrsta.DataSource = result;
            cmbvrsta.DisplayMember = "Naziv";
            cmbvrsta.ValueMember = "VrstaId";
        }

        private async void btnProizvodi_Click(object sender, EventArgs e)
        {
            ModelSpartanX.Search.ProizvodiSearchObject req = new ModelSpartanX.Search.ProizvodiSearchObject()
            {
                Naziv = txtProizvodi.Text
            };
            dgvProizvodi.DataSource = await _proizvodi.Get<List<ModelSpartanX.Proizvodi>>(req);
        }

        private void btnNoviPro_Click(object sender, EventArgs e)
        {
            frmProizvodiDetalji form = new frmProizvodiDetalji();
            form.ShowDialog();
        }

        private async void cmbvrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = cmbvrsta.SelectedValue;
            if(int.TryParse(value.ToString(), out int id))
            {
                await LoadProizvodi(id);
            }

        }

        private void dgvProizvodi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var proizvod = dgvProizvodi.SelectedRows[0].DataBoundItem as ModelSpartanX.Proizvodi;// grab a user
            frmProizvodiDetalji forma = new frmProizvodiDetalji(proizvod);
            forma.ShowDialog();
        }

        private void dgvProizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
