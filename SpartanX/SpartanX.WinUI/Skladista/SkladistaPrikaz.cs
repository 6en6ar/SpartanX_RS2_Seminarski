using SpartanX.Model.Search;
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
            dgvSkladista.DataSource = await _apiservice.Get<List<Model.Skladista>>(null);
        }

        private async void btnPrikaziSkl_Click(object sender, EventArgs e)
        {
            SkladistaSearchObject req = new SkladistaSearchObject()
            {
                Naziv = txtSkladista.Text
            };
            dgvSkladista.DataSource = await _apiservice.Get<List<Model.Skladista>>(req);
        }
    }
}
