using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpartanX.WinUI.Korisnici
{
    public partial class frmKorisniciPrikaz : Form
    {
        APIService _apiservice = new APIService("Korisnici");
        public frmKorisniciPrikaz()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dgvKorisniciPrikaz.DataSource = await _apiservice.Get<List<Model.Korisnici>>();
        }
    }
}
