using SpartanX.Model.Search;
using SpartanX.WinUI.Korisnici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpartanX.WinUI.Skladista
{
    public partial class SkladistaPrikaz : Form
    {
        APIService _apiservice = new APIService("Skladista");
        public SkladistaPrikaz()
        {
            InitializeComponent();
        }

        private async void SkladistaPrikaz_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSkladista.DataSource = await _apiservice.Get<List<Model.Skladista>>(null);
            }
            catch
            {
                throw new Exception();
            }
        }

        private async void btnPrikaziSkl_Click(object sender, EventArgs e)
        {
            SkladistaSearchObject req = new SkladistaSearchObject()
            {
                Naziv = txtSkladista.Text
            };
            dgvSkladista.DataSource = await _apiservice.Get<List<Model.Skladista>>(req);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Skladista.frmSkladisteDetalji frm = new Skladista.frmSkladisteDetalji();
            frm.Show();
        }

        private void dgvSkladista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var skladiste = dgvSkladista.SelectedRows[0].DataBoundItem;// grab a user
            frmSkladisteDetalji forma = new frmSkladisteDetalji(skladiste as Model.
                Skladista);
            forma.ShowDialog();
        }
    }
}
