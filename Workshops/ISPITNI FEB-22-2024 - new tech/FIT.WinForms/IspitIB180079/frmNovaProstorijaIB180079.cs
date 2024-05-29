using FIT.Data;
using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
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
        private ProstorijeIB180079 odabranaProstorija; // null je ako kreiramo novu prostoriju

        public frmNovaProstorijaIB180079()
        {
            InitializeComponent();
        }

        public frmNovaProstorijaIB180079(ProstorijeIB180079 odabranaProstorija)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var naziv = txtNaziv.Text;
                var kapacitet = int.Parse(txtKapacitet.Text);
                var oznaka = txtOznaka.Text;
                var logo = Ekstenzije.ToByteArray(pbLogo.Image);

                if(odabranaProstorija == null) // dodavanje
                {
                    var novaProstorija = new ProstorijeIB180079()
                    {

                        Naziv = naziv,
                        Oznaka = oznaka,
                        Logo = logo,
                        Kapacitet = kapacitet

                    };

                    db.ProstorijeIB180079.Add(novaProstorija);

                }
                else // modifikacija
                {
                    odabranaProstorija.Oznaka = oznaka;
                    odabranaProstorija.Naziv = naziv;
                    odabranaProstorija.Kapacitet = kapacitet;
                    odabranaProstorija.Logo = logo;



                    db.Entry(odabranaProstorija).State = EntityState.Modified;
                    // db.Entry(odabranaProstorija).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                }


                db.SaveChanges();

                DialogResult = DialogResult.OK;

            }

        }



        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(pbLogo, err, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(txtKapacitet, err, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(txtOznaka, err, Kljucevi.ReqiredValue);
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // C:\Users\ASUS\Desktop\C# Repos\Slike helpers\slika.jpg     
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmNovaProstorijaIB180079_Load(object sender, EventArgs e)
        {
            UcitajInfo();
        }

        private void UcitajInfo()
        {
            if(odabranaProstorija != null) // odabrana prostorija nije null ako radimo edit
            {
                txtKapacitet.Text = odabranaProstorija.Kapacitet.ToString();
                txtNaziv.Text = odabranaProstorija.Naziv;
                txtOznaka.Text = odabranaProstorija.Oznaka;
                pbLogo.Image = Ekstenzije.ToImage(odabranaProstorija.Logo);
                // pbLogo.Image = odabranaProstorija.Logo.ToImage();

            }

        }
    }
}
