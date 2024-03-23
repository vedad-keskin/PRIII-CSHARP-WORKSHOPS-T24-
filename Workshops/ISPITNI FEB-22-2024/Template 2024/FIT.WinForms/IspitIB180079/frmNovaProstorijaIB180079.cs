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

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var oznaka = txtOznaka.Text;
                var naziv = txtNaziv.Text;
                var kapacitet = int.Parse(txtKapacitet.Text);
                var logo = Ekstenzije.ToByteArray(pbLogo.Image);

                if(odabranaProstorija != null) // kada editujemo
                {
                    odabranaProstorija.Logo = logo;
                    odabranaProstorija.Naziv = naziv;
                    odabranaProstorija.Oznaka = oznaka;
                    odabranaProstorija.Kapacitet = kapacitet;

                    db.Entry(odabranaProstorija).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                else // kada dodajemo novu prostoriju
                {

                    var NovaProstorija = new ProstorijeIB180079()
                    {
                        Naziv = naziv,
                        Oznaka = oznaka,
                        Kapacitet = kapacitet,
                        Logo = logo
                    };

                    db.ProstorijeIB180079.Add(NovaProstorija);

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
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmNovaProstorijaIB180079_Load(object sender, EventArgs e)
        {
            if(odabranaProstorija != null) // load podataka odabrane prostorije
            {
                pbLogo.Image = Ekstenzije.ToImage(odabranaProstorija.Logo);
                txtKapacitet.Text = odabranaProstorija.Kapacitet.ToString();
                txtNaziv.Text = odabranaProstorija.Naziv;
                txtOznaka.Text = odabranaProstorija.Oznaka;
            }
        }
    }
}
