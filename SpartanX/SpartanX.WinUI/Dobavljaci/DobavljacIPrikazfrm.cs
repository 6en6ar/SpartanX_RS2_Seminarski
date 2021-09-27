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
            dgvDobavljaci.DataSource = await _apiservice.Get<List<Model.Dobavljaci>>(null);
        }
    }
}
