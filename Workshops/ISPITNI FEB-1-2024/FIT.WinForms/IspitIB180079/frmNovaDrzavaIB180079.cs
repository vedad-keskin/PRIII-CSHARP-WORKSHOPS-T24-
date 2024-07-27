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
    public partial class frmNovaDrzavaIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private DrzaveIB180079 odabranaDrzava;

        public frmNovaDrzavaIB180079()
        {
            InitializeComponent();
        }

        public frmNovaDrzavaIB180079(DrzaveIB180079 odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var naziv = txtNaziv.Text;
                var zastava = Ekstenzije.ToByteArray(pbZastava.Image);
                var aktivan = chbAktivan.Checked;

                if (odabranaDrzava == null)
                {
                    var novaDrzava = new DrzaveIB180079()
                    {
                        Naziv = naziv,
                        Zastava = zastava,
                        Status = aktivan
                    };

                    db.DrzaveIB180079.Add(novaDrzava);

                }
                else
                {
                    odabranaDrzava.Zastava = zastava;
                    odabranaDrzava.Status = aktivan;
                    odabranaDrzava.Naziv = naziv;

                    db.DrzaveIB180079.Update(odabranaDrzava);
                }


                db.SaveChanges();
                DialogResult = DialogResult.OK;

            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(pbZastava, err, Kljucevi.ReqiredValue);
        }

        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmNovaDrzavaIB180079_Load(object sender, EventArgs e)
        {
            UcitajDrzavu();
        }

        private void UcitajDrzavu()
        {
            if (odabranaDrzava != null)
            {
                pbZastava.Image = Ekstenzije.ToImage(odabranaDrzava.Zastava);
                txtNaziv.Text = odabranaDrzava.Naziv;
                chbAktivan.Checked = odabranaDrzava.Status;
            }
        }
    }
}
