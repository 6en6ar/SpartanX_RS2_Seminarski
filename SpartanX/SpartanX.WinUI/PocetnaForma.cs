using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpartanX.WinUI
{
    public partial class PocetnaForma : Form
    {
        private int childFormNumber = 0;

        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void prikazKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnici.frmKorisniciPrikaz frm = new Korisnici.frmKorisniciPrikaz();
            frm.MdiParent = this;
            frm.Show();
        }

        private void klijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dodajNovogKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnici.KorisnikDetalji frm = new Korisnici.KorisnikDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {

        }

        private void prikazProizvodaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Skladista.SkladistaPrikaz frm = new Skladista.SkladistaPrikaz();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazDobavljacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dobavljaci.DobavljacIPrikazfrm frm = new Dobavljaci.DobavljacIPrikazfrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proizvodi.frmProizvodiPrikaz frm = new Proizvodi.frmProizvodiPrikaz();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajNoviProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proizvodi.frmProizvodiDetalji frm = new Proizvodi.frmProizvodiDetalji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajSkladisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Skladista.frmSkladisteDetalji frm = new Skladista.frmSkladisteDetalji();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
