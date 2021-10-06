using SpartanX.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpartanX.WinUI.Dobavljaci
{
    public partial class DodajDobavljace : Form
    {
        APIService _dobavljaci = new APIService("Dobavljaci");
        public DodajDobavljace()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            ModelSpartanX.Requests.DobavljaciInsertRequest req = new ModelSpartanX.Requests.DobavljaciInsertRequest()
            {
                Telefon = txtTelefon.Text,
                Adresa = txtAdresa.Text,
                Naziv = txtNaziv.Text,
                Napomena = txtNapomena.Text,
                Status = cbAktivan.Checked,
                Email = txtEmail.Text,
                Fax = txtFax.Text,
                KontaktOsoba = txtKontakt.Text,
                Web = txtWeb.Text,
                ZiroRacuni = txtZiro.Text


            };
            try
            {
                var res = await _dobavljaci.Insert<ModelSpartanX.Dobavljaci>(req);
                MessageBox.Show("Dobavljac uspjesno dodat");
            }
            catch
            {
                throw new Exception();
            }

        }

        private void DodajDobavljace_Load(object sender, EventArgs e)
        {

        }
    }
}
