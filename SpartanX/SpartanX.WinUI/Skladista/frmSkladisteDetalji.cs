using SpartanX.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpartanX.WinUI.Skladista
{
    public partial class frmSkladisteDetalji : Form
    {
        APIService _skladisteService = new APIService("Skladista");
        private ModelSpartanX.Skladista _skladiste;
        public frmSkladisteDetalji(ModelSpartanX.Skladista skladiste = null)
        {
            InitializeComponent();
            _skladiste = skladiste;
        }

        private void frmSkladisteDetalji_Load(object sender, EventArgs e)
        {
            if (_skladiste != null)
            {
                txtNaziv.Text = _skladiste.Naziv;
                txtAdresa.Text = _skladiste.Adresa;
                txtOpis.Text = _skladiste.Opis;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (_skladiste == null)
            {
                ModelSpartanX.Requests.SkladisteInsertRequest req = new ModelSpartanX.Requests.SkladisteInsertRequest()
                {
                   Naziv = txtNaziv.Text,
                   Adresa = txtAdresa.Text,
                   Opis = txtOpis.Text
                };
                var result = await _skladisteService.Insert<ModelSpartanX.Skladista>(req);
                MessageBox.Show("Uspješno ste dodali skladište!");
            }
            else
            {
                ModelSpartanX.Requests.SkladisteUpdateRequest req = new ModelSpartanX.Requests.SkladisteUpdateRequest()
                {
                    Naziv = txtNaziv.Text,
                    Adresa = txtAdresa.Text,
                    Opis = txtOpis.Text
                };
                var result = await _skladisteService.Update<ModelSpartanX.Skladista>(_skladiste.SkladisteId, req);
                MessageBox.Show("Uspješno ste editovali skladište!");
            }
        }
    }
}
