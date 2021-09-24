﻿using SpartanX.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpartanX.WinUI.Korisnici
{
    public partial class KorisnikDetalji : Form
    {
        APIService service = new APIService("Korisnici");
        APIService Ulservice = new APIService("Uloge");
        private Model.Korisnici _korisnik;
        public KorisnikDetalji(Model.Korisnici korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }
        public async Task LoadUloge()
        {
            var ulogeList = await Ulservice.Get<List<Model.Uloge>>(null);

            clbUloge.DataSource = ulogeList;
            clbUloge.DisplayMember = "Naziv";
        }
        private async void KorisnikDetalji_Load(object sender, EventArgs e)
        {
            await LoadUloge();
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

        private async void button2_Click(object sender, EventArgs e)
        {
            
            if(_korisnik != null)
            {
                KorisniciInsertRequest req = new KorisniciInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme  = txtUsername.Text,
                    Password = txtPassword.Text,
                    PasswordPotvrda =txtPotvrdiPass.Text,
                    Email  = txtEmail.Text,
                    Status  =cbStatus.Checked
                    
                    //dodati telefon
                    //Telefon = txtTelefon.Text
                };
                var result = await service.Insert<Model.Korisnici>(req);
            }
            else
            {
                KorisniciUpdateRequest req = new KorisniciUpdateRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Status=cbStatus.Checked,
                    KorisnickoIme = txtUsername.Text
                };
                var result = await service.Update<Model.Korisnici>(_korisnik.KorisnikId,req);
            }
        }

        private void clBoxUloge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}