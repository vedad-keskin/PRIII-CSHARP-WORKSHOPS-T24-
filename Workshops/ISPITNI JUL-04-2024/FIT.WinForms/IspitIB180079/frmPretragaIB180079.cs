using FIT.Data;
using FIT.Infrastructure;
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
    public partial class frmPretragaIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> studenti;
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;

            cbSpol.SelectedIndex = 0;

        }

        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente()
        {

            var aktivan = chbAktivan.Checked;

            var spol = cbSpol.SelectedItem.ToString(); // "Svi" "Muški" "Ženski"

            var imePrezime = txtImePrezime.Text.ToLower(); // "Jasmin jasmin

            var datumOd = dtpDatumOd.Value;
            var datumDo = dtpDatumDo.Value;



            studenti = db.Studenti
                .Where(x => x.Aktivan == aktivan)
                .Where(x => x.Spol == spol || spol == "Svi")
                .Where(x => x.Ime.ToLower().Contains(imePrezime) || x.Prezime.ToLower().Contains(imePrezime))
                .Where(x => x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo)
                .ToList();


            for (int i = 0; i < studenti.Count(); i++)
            {
                studenti[i].Prosjek = db.PolozeniPredmeti
                    .Where(x => x.StudentId == studenti[i].Id).Count() == 0 ? 5 :
                    db.PolozeniPredmeti
                    .Where(x => x.StudentId == studenti[i].Id)
                    .Average(x => x.Ocjena);
            }

            // ? : 


            if (studenti != null)
            {

                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studenti;

            }



        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //var odabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;

            var odabraniStudent = studenti[e.RowIndex];
            

            if (e.ColumnIndex < 6)
            {
                var frmInfo = new frmStudentInfoIB180079(odabraniStudent);

                frmInfo.ShowDialog();
            }
            else
            {
                var frmUvjerenja = new frmUvjerenjaIB180079(odabraniStudent);

                frmUvjerenja.ShowDialog();
            }


        }

 
    }
}
