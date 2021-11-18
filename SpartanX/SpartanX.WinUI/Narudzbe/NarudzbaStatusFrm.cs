using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpartanX.WinUI.Narudzbe
{
    public partial class NarudzbaStatusFrm : Form
    {
        private ModelSpartanX.Narudzbe narudzba;
        private ModelSpartanX.Requests.NarudzbeUpdateRequest updateNar = new ModelSpartanX.Requests.NarudzbeUpdateRequest(); 
        private readonly APIService _service = new APIService("Narudzbe");
        public NarudzbaStatusFrm(ModelSpartanX.Narudzbe _narudzba)
        {
            InitializeComponent();
            narudzba = _narudzba;
        }

        private void NarudzbaStatusFrm_Load(object sender, EventArgs e)
        {
            cbStatus.Checked = narudzba.Status;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            updateNar.Status = cbStatus.Checked;
            await _service.Update<ModelSpartanX.Narudzbe>(narudzba.NarudzbaId,updateNar);
            MessageBox.Show("Uspješno ste promjenili status pošiljke!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IzvještajForma frm = new IzvještajForma();
            frm.Hide();
            frm.lblBrojN.Text = narudzba.BrojNarudzbe.ToString();
            frm.lblDatum.Text = narudzba.DatumNarudzbe.ToString();
            if (narudzba.Otkazano == true)
            {
                frm.lblStatus.Text = "Otkazano";
            }
            else
            {
                frm.lblStatus.Text = "U obradi";
            }
            frm.lblIznosSPdv.Text = narudzba.IznosSaPdv.ToString();
            
            frm.Show();
        }
    }
}
