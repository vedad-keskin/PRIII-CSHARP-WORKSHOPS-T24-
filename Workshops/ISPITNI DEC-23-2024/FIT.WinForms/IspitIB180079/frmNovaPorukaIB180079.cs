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
    public partial class frmNovaPorukaIB180079 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();


        public frmNovaPorukaIB180079(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNovaPorukaIB180079_Load(object sender, EventArgs e)
        {
            UcitajComboBox();
        }

        private void UcitajComboBox()
        {
            cbPredmet.DataSource = db.Predmeti.ToList();
            cbHitnost.SelectedIndex = 0;
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var predmet = cbPredmet.SelectedItem as PredmetiIB180079;

                var hitnost = cbHitnost.SelectedItem.ToString();

                var validnost = dtpValidnost.Value;

                var sadrzaj = txtSadrzaj.Text;

                var slika = pbSlika.Image.ToByteArray();

                var novaPoruka = new StudentiPorukeIB180079()
                {
                    PredmetId = predmet.Id,
                    StudentId = student.Id,
                    Hitnost = hitnost,
                    Validnost = validnost,
                    Sadrzaj = sadrzaj,
                    Slika = slika

                };

                db.StudentiPorukeIB180079.Add(novaPoruka);
                db.SaveChanges();

                DialogResult = DialogResult.OK;



            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(pbSlika, err, Kljucevi.ReqiredValue)
                &&
                Validator.ProvjeriUnos(txtSadrzaj, err, Kljucevi.ReqiredValue);
        }
    }
}
