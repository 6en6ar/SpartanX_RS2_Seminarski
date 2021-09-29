using SpartanX.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpartanX.WinUI.Proizvodi
{
    public partial class frmProizvodiDetalji : Form
    {
        APIService _proizvodjaci = new APIService("Proizvodjaci");
        APIService _vrste = new APIService("VrsteProizvoda");
        APIService _servicePro = new APIService("Proizvodi");
        private Model.Proizvodi _proizvod;
        public frmProizvodiDetalji(Model.Proizvodi proizvod = null)
        {
            InitializeComponent();
            _proizvod = proizvod;
        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        private async void frmProizvodiDetalji_Load(object sender, EventArgs e)
        {
            await LoadData();
            if(_proizvod != null)
            {

                txtBodovi.Text = _proizvod.BodoviLojalnosti.ToString();
                txtNaziv.Text = _proizvod.Naziv;
                txtKod.Text = _proizvod.Kod;
                txtKod.Text = _proizvod.Kod.ToString();
                txtCijena.Text = _proizvod.Cijena.ToString();
                cmbProizvodjaci.SelectedIndex = _proizvod.VrstaId;
                cmbVrsta.SelectedIndex = _proizvod.ProizvodjacId;
                pbSlika.Image = byteArrayToImage(_proizvod.SlikaThumb);

            }
        }

        private async Task LoadData()
        {
            
             await LoadVrsteProizvoda();
            await LoadProizvodjace();

        }
        private async Task LoadProizvodjace()
        {
            var result = await _proizvodjaci.Get<List<Model.Proizvodjaci>>(null);
            result.Insert(0, new Model.Proizvodjaci());
            cmbProizvodjaci.DataSource = result;
            cmbProizvodjaci.DisplayMember = "Naziv";
            cmbProizvodjaci.ValueMember = "ProizvodjacId";
        }
        private async Task LoadVrsteProizvoda()
        {
            var result = await _vrste.Get<List<Model.VrstaProizvoda>>(null);
            result.Insert(0, new Model.VrstaProizvoda());
            cmbVrsta.DataSource = result;
            cmbVrsta.DisplayMember = "Naziv";
            cmbVrsta.ValueMember = "VrstaId";
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            var slika = ofdSlika.ShowDialog();
            if(slika == DialogResult.OK)
            {
                var fname = ofdSlika.FileName;
                var file = File.ReadAllBytes(fname); 
                txtSlika.Text = fname;
                pbSlika.Image = Image.FromFile(fname);
            }
        }
        ProizvodiInsertRequest insertPro = new ProizvodiInsertRequest();
        ProizvodiUpdateRequest updatePro = new ProizvodiUpdateRequest();

        public static byte[] ImageToByteArray(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;

        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_proizvod == null)
            {
                var vrstaPro = cmbVrsta.SelectedValue;
                if (int.TryParse(vrstaPro.ToString(), out int VrstaId))
                {
                    insertPro.VrstaId = VrstaId;
                }
                var proizvodjac = cmbVrsta.SelectedValue;
                if (int.TryParse(proizvodjac.ToString(), out int ProizvodjacId))
                {
                    insertPro.ProizvodjacId = ProizvodjacId;
                }
                insertPro.Kod = txtKod.Text;
                insertPro.Naziv = txtNaziv.Text;

                if (decimal.TryParse(txtCijena.Text, out decimal cijena))
                {
                    insertPro.Cijena = cijena;
                }
                if (pbSlika.Image != null)
                {
                    Image i = pbSlika.Image;
                    insertPro.Slika = ImageToByteArray(i);
                    Image thumb = i.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                    insertPro.SlikaThumb = ImageToByteArray(thumb);

                }
                await _servicePro.Insert<Model.Proizvodi>(insertPro);
            }
            else
            {
                var vrstaPro = cmbVrsta.SelectedValue;
                if (int.TryParse(vrstaPro.ToString(), out int VrstaId))
                {
                    updatePro.VrstaId = VrstaId;
                }
                var proizvodjac = cmbVrsta.SelectedValue;
                if (int.TryParse(proizvodjac.ToString(), out int ProizvodjacId))
                {
                    updatePro.ProizvodjacId = ProizvodjacId;
                }
                updatePro.Naziv = txtNaziv.Text;

                if (decimal.TryParse(txtCijena.Text, out decimal cijena))
                {
                    updatePro.Cijena = cijena;
                }
                await _servicePro.Insert<Model.Proizvodi>(updatePro);
            }
        }
    }
}
