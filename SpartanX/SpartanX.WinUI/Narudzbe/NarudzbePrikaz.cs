using SpartanX.WinUI.Proizvodi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpartanX.WinUI.Narudzbe
{
    public partial class NarudzbePrikaz : Form
    {
        APIService _service = new APIService("Narudzbe");
        public NarudzbePrikaz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void NarudzbePrikaz_Load(object sender, EventArgs e)
        {
            dgvNarudzbe.DataSource = await _service.Get<List<ModelSpartanX.Narudzbe>>(null);
            dgvNarudzbe.Columns["NarudzbaId"].Visible = false;
            dgvNarudzbe.Columns["KupacId"].Visible = false;
            dgvNarudzbe.Columns["SkladisteId"].Visible = false;
            dgvNarudzbe.Columns["PosiljkaOpis"].Visible = false;
            dgvNarudzbe.Columns["Kupac"].Visible = false;
            dgvNarudzbe.Columns["NarudzbaStavkes"].Visible = false;
        }

        private void dgvNarudzbe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNarudzbe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var narudzba = dgvNarudzbe.SelectedRows[0].DataBoundItem as ModelSpartanX.Narudzbe;
            NarudzbaStatusFrm forma = new NarudzbaStatusFrm(narudzba);
            forma.ShowDialog();
        }
    }
}
