using SpartanX.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpartanX.WinUI.Korisnici
{
    public partial class KorisnikDetalji : Form
    {
        APIService service = new APIService("Korisnici");
        APIService Ulservice = new APIService("Uloge");
        private ModelSpartanX.Korisnici _korisnik;
        public KorisnikDetalji(ModelSpartanX.Korisnici korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }
        public async Task LoadUloge()
        {
            var ulogeList = await Ulservice.Get<List<ModelSpartanX.Uloge>>(null);

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
        private bool txtIme_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, "Obavezno polje");
                return false;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
                return true;
            }
        }

        private bool txtPrezime_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
               
                errorProvider.SetError(txtPrezime, "Obavezno polje");
                return false;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
                return true;
            }
        }

        private bool txtEmail_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
               
                errorProvider.SetError(txtEmail, "Obavezno polje");
                return false;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
                return true;
            }
        }

        private bool txtUsername_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text.Length < 3)
            {
                errorProvider.SetError(txtUsername, "Obavezno polje");
                return false;
            }
            else
            {
                errorProvider.SetError(txtUsername, null);
                return true;
            }
        }
        private bool Validiraj()
        {
            bool provjeri = true;
            if (txtIme_Validating()==false)
            {
                provjeri = false;
            }
            if (txtPrezime_Validating() == false)
            {
                provjeri = false;
            }
            if (txtEmail_Validating() == false)
            {
                provjeri = false;
            }
            if (txtUsername_Validating() == false)
            {
                provjeri = false;
            }
            if(provjeri == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {


                
                if (_korisnik == null)
                {
                    var listauloga = clbUloge.CheckedItems.Cast<ModelSpartanX.Uloge>().Select(x => x.UlogaId).ToList();
                    ModelSpartanX.Requests.KorisniciInsertRequest req = new ModelSpartanX.Requests.KorisniciInsertRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        KorisnickoIme = txtUsername.Text,
                        Password = txtPassword.Text,
                        PasswordPotvrda = txtPotvrdiPass.Text,
                        Email = txtEmail.Text,
                        Status = cbStatus.Checked,
                        Uloge = listauloga

                        //dodati telefon
                        //Telefon = txtTelefon.Text
                    };
                    var result = await service.Insert<ModelSpartanX.Korisnici>(req);
                    MessageBox.Show("Uspješno ste dodali korisnika!");
                }
                else
                {
                    ModelSpartanX.Requests.KorisniciUpdateRequest req = new ModelSpartanX.Requests.KorisniciUpdateRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Status = cbStatus.Checked,
                        KorisnickoIme = txtUsername.Text,
                        Email = txtEmail.Text

                    };
                    try
                    {
                        var result = await service.Update<ModelSpartanX.Korisnici>(_korisnik.KorisnikId, req);
                        MessageBox.Show("Uspješno ste editovali korisnika!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Došlo je do greške!");
                        throw ex;
                    }

                }
            }
        }

        private void clBoxUloge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
