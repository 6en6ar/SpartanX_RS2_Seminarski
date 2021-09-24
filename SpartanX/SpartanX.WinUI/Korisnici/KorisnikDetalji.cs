using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpartanX.WinUI.Korisnici
{
    public partial class KorisnikDetalji : Form
    {
        APIService service = new APIService("Korisnici");
        private Model.Korisnici _korisnik;
        public KorisnikDetalji(Model.Korisnici korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void KorisnikDetalji_Load(object sender, EventArgs e)
        {
            if(_korisnik != null)
            {
                //fill the form
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtUsername.Text = _korisnik.KorisnickoIme;
                txtEmail.Text = _korisnik.Email;
                cbStatus.Checked = _korisnik.Status.GetValueOrDefault(false);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
