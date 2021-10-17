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
        }
    }
}
