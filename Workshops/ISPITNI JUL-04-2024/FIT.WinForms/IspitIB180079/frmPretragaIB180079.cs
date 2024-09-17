using FIT.Data;
using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
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
            cbSpol.DataSource = db.Spol.ToList();

        }

        private void UcitajStudente()
        {
            var spol = cbSpol.SelectedItem as SpolIB180079;
            var datumOd = dtpDatumOd.Value;
            var datumDo = dtpDatumDo.Value;
            var aktivan = chbAktivan.Checked;
            var imeprezime = txtImePrezime.Text.ToLower();


            studenti = db.Studenti
                .Include(x => x.Spol)
                .Where(x => x.SpolId == spol.Id)
                .Where(x => x.Aktivan == aktivan)
                .Where(x => x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo)
                .Where(x => x.Ime.ToLower().Contains(imeprezime) || x.Prezime.ToLower().Contains(imeprezime))
                .ToList();

            for (int i = 0; i < studenti.Count(); i++)
            {
                studenti[i].Prosjek = db.PolozeniPredmeti
                    .Where(x => x.StudentId == studenti[i].Id).Count() == 0 ? 5 :
                    db.PolozeniPredmeti
                    .Where(x => x.StudentId == studenti[i].Id)
                    .Average(x => x.Ocjena);
            }


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

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();

        }

        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabraniStudent = studenti[e.RowIndex];

            if(e.ColumnIndex < 5)
            {
                frmStudentInfoIB180079 frmInfo = new frmStudentInfoIB180079(odabraniStudent);
                frmInfo.ShowDialog();
            }

            if(e.ColumnIndex == 5)
            {
                frmUvjerenjaIB180079 frmUvjerenja = new frmUvjerenjaIB180079(odabraniStudent);
                frmUvjerenja.ShowDialog();
            }

        }


    }
}
