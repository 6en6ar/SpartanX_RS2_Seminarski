using SpartanX.Model.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpartanX.WinUI.Dobavljaci
{
    public partial class DobavljacIPrikazfrm : Form
    {
        APIService _apiservice = new APIService("Dobavljaci");
        public DobavljacIPrikazfrm()
        {
            InitializeComponent();
        }

        private async void DobavljacIPrikazfrm_Load(object sender, EventArgs e)
        {
            dgvDobavljaci.DataSource = await _apiservice.Get<List<ModelSpartanX.Dobavljaci>>(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajDobavljace frm = new DodajDobavljace();
            frm.Show();
        }

        private async void btnPrikaziDob_Click(object sender, EventArgs e)
        {
            ModelSpartanX.Search.DobavljaciSearchObject req = new ModelSpartanX.Search.DobavljaciSearchObject()
            {
                Naziv = txtDobavljaci.Text
            };
            dgvDobavljaci.DataSource = await _apiservice.Get<List<ModelSpartanX.Dobavljaci>>(req);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
