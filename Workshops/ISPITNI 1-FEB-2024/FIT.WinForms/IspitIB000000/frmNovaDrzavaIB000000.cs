using FIT.Data.IspitIB0000000;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB000000
{
    public partial class frmNovaDrzavaIB000000 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaDrzavaIB000000()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofd.FileName);
            }
        }


        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var slika = Helpers.Ekstenzije.ToByteArray(pbSlika.Image);
                var naziv = txtNaziv.Text;
                var novaDrzava = new DrzavaIB000000()
                {
                    Zastava = slika,
                    Naziv = naziv
                };

                db.DrzaveIB000000.Add(novaDrzava);
                db.SaveChanges();

                DialogResult = DialogResult.OK;

                MessageBox.Show($"Uspijesno dodana drzava {naziv}");
            }
        }

        private bool Validiraj()
        {
            return Helpers.Validator.ProvjeriUnos(pbSlika, err, "Obavezna vrijednost") &&
             Helpers.Validator.ProvjeriUnos(txtNaziv, err, "Obavezna vrijednost");
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
