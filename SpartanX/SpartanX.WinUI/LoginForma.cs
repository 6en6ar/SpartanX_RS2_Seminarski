using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpartanX.WinUI
{
    public partial class LoginForma : Form
    {
        private readonly APIService _service = new APIService("Korisnici");
        public LoginForma()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            APIService.username = txtUsername.Text;
            APIService.password = txtPassword.Text;
            try
            {
                var auth =  await _service.Get<List<ModelSpartanX.Korisnici>>(null);

                PocetnaForma frm = new PocetnaForma();
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Pogresan username ili password");
            }
        }

        private void LoginForma_Load(object sender, EventArgs e)
        {

        }
    }
}
