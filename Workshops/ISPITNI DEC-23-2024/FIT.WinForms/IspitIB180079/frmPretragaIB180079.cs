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
        List<StudentiUlogeIB180079> studentiUloge;
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void cbUloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            var odabraniSemestar = cbSemestar.SelectedItem as SemestriIB180079 ?? new SemestriIB180079();
            var odabranaUloga = cbUloga.SelectedItem as UlogeIB180079 ?? new UlogeIB180079();

            var datumOd = dtpDatumOd.Value;
            var datumDo = dtpDatumDo.Value;


            studentiUloge = db.StudentiUloge
                .Include(x => x.Student)
                .Include(x => x.Uloga)
                .Where(x => x.UlogaId == odabranaUloga.Id)
                .Where(x => x.Student.SemestarId == odabraniSemestar.Id)
                .Where(x => x.Student.DatumRodjenja >= datumOd && x.Student.DatumRodjenja <= datumDo)
                .ToList();

            for (int i = 0; i < studentiUloge.Count(); i++)
            {
                studentiUloge[i].Prosjek =
                    db.PolozeniPredmeti.Where(x => x.StudentId == studentiUloge[i].StudentId).Count() == 0 ? 5 : db.PolozeniPredmeti.Where(x => x.StudentId == studentiUloge[i].StudentId).Average(x => x.Ocjena);
            }


            if (studentiUloge != null)
            {
                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = studentiUloge;
            }

            if (studentiUloge.Count() == 0)
            {
                MessageBox.Show($"U bazi nisu evidentirani studenti rođeni u periodu od {datumOd} – {datumDo}. godine, a koji su upisani u {odabraniSemestar} i posjeduju ulogu {odabranaUloga}");
            }

        }

        private void frmPretragaIB180079_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;

            UcitajComboBox();

        }

        private void UcitajComboBox()
        {
            cbSemestar.DataSource = db.Semestri.ToList();
            cbUloga.DataSource = db.Uloge.ToList();
        }

        private void cbSemestar_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaStudentUloga = studentiUloge[e.RowIndex];

            if(e.ColumnIndex == 6)
            {
                var frmPoruke = new frmPorukeIB180079(odabranaStudentUloga.Student);

                frmPoruke.ShowDialog();
            }
        }
    }
}
