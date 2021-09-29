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
        private Model.Skladista _skladiste;
        public frmSkladisteDetalji(Model.Skladista skladiste = null)
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
                SkladisteInsertRequest req = new SkladisteInsertRequest()
                {
                   Naziv = txtNaziv.Text,
                   Adresa = txtAdresa.Text,
                   Opis = txtOpis.Text
                };
                var result = await _skladisteService.Insert<Model.Skladista>(req);
            }
            else
            {
                SkladisteUpdateRequest req = new SkladisteUpdateRequest()
                {
                    Naziv = txtNaziv.Text,
                    Adresa = txtAdresa.Text,
                    Opis = txtOpis.Text
                };
                var result = await _skladisteService.Update<Model.Skladista>(_skladiste.SkladisteId, req);
            }
        }
    }
}
