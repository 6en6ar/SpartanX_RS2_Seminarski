using SpartanX.Model.Requests;
using SpartanX.Model.Search;
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
            KorisniciSearchObject req = new KorisniciSearchObject()
            {
                Ime = txtIme.Text
            };
            dgvKorisniciPrikaz.DataSource = await _apiservice.Get<List<Model.Korisnici>>(req);

        }

        private async void frmKorisniciPrikaz_Load(object sender, EventArgs e)
        {
            dgvKorisniciPrikaz.DataSource = await _apiservice.Get<List<Model.Korisnici>>(null);
        }

        private void dgvKorisniciPrikaz_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var korisnik = dgvKorisniciPrikaz.SelectedRows[0].DataBoundItem;// grab a user
            KorisnikDetalji forma = new KorisnikDetalji(korisnik as Model.Korisnici);
            forma.ShowDialog();
        }

        private void Dodajbutton_Click(object sender, EventArgs e)
        {
            KorisnikDetalji forma = new KorisnikDetalji();
            forma.ShowDialog();
        }

        private void dgvKorisniciPrikaz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
