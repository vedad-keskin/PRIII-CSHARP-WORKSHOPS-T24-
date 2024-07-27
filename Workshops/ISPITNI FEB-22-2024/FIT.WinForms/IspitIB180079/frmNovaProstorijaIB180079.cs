using FIT.Data;
using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB180079
{
    public partial class frmNovaProstorijaIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private ProstorijeIB180079 odabranaProstorija;

        public frmNovaProstorijaIB180079()
        {
            InitializeComponent();
        }

        public frmNovaProstorijaIB180079(ProstorijeIB180079 odabranaProstorija)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //             C:\Users\ASUS\Desktop\C# Repos\Slike helpers\Google_Classroom_Logo.jpg
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {

                var naziv = txtNaziv.Text;
                var oznaka = txtOznaka.Text;
                var kapacitet = int.Parse(txtKapacitet.Text);
                var logo = Ekstenzije.ToByteArray(pbLogo.Image);


                if(odabranaProstorija != null) // radimo editovanje
                {

                    odabranaProstorija.Naziv = naziv;
                    odabranaProstorija.Oznaka = oznaka;
                    odabranaProstorija.Kapacitet = kapacitet;
                    odabranaProstorija.Logo = logo;

                    db.Entry(odabranaProstorija).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                }
                else
                {

                    var novaProstorija = new ProstorijeIB180079()
                    {
                        Naziv = naziv,
                        Logo = logo,
                        Kapacitet = kapacitet,
                        Oznaka = oznaka

                    };

                    db.ProstorijeIB180079.Add(novaProstorija);
                }

                db.SaveChanges();

                DialogResult = DialogResult.OK;



            }
        }

        private bool Validiraj()
        {
            return Helpers.Validator.ProvjeriUnos(txtKapacitet, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtOznaka, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(pbLogo, err, Kljucevi.ReqiredValue);
        }

        private void frmNovaProstorijaIB180079_Load(object sender, EventArgs e)
        {

            if(odabranaProstorija != null) // ako radimo editovanje
            {

                txtKapacitet.Text = odabranaProstorija.Kapacitet.ToString();
                txtNaziv.Text = odabranaProstorija.Naziv;
                txtOznaka.Text = odabranaProstorija.Oznaka;
                //pbLogo.Image = Ekstenzije.ToImage(odabranaProstorija.Logo);
                pbLogo.Image = odabranaProstorija.Logo.ToImage();
            }

        }
    }
}
