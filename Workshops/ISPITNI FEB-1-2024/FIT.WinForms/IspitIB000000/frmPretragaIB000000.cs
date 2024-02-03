using FIT.Data;
using FIT.Data.IspitIB0000000;
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

namespace FIT.WinForms.IspitIB000000
{
    public partial class frmPretragaIB000000 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> studenti;
        DrzavaIB000000 odabranaDrzava;
        public frmPretragaIB000000()
        {
            InitializeComponent();
        }

        private void frmPretragaIB000000_Load(object sender, EventArgs e)
        {
            cbDrzava.DataSource = db.DrzaveIB000000.ToList();
            odabranaDrzava = cbDrzava.SelectedItem as DrzavaIB000000;

            cbGrad.DataSource = db.GradoviIB000000.Where(x => x.DrzavaID == odabranaDrzava.Id).Count() == 0 ?
                "Drzava nema gradova" :
                db.GradoviIB000000.Where(x => x.DrzavaID == odabranaDrzava.Id).ToList();


            dgvStudenti.AutoGenerateColumns = false;
            Text = "Pretraga studenata";
            UcitajStudent();
        }

        private void UcitajStudent()
        {
            studenti = db.Studenti.Include("Grad").Include("Semestar").ToList();
            if (studenti != null)
            {
                var dsTabela = new DataTable();
                dsTabela.Columns.Add("ImePrezime");
                dsTabela.Columns.Add("Drzava");
                dsTabela.Columns.Add("Grad");
                dsTabela.Columns.Add("Prosjek");

                for (int i = 0; i < studenti.Count(); i++)
                {
                    var s = studenti[i];

                    var Red = dsTabela.NewRow();
                    Red["ImePrezime"] = s.ToString();
                    Red["Drzava"] = s.Grad.Drzava.ToString();
                    Red["Grad"] = s.Grad.ToString();

                    Red["Prosjek"] = db.PolozeniPredmeti.Where(x => x.StudentId == s.Id).Count() == 0 ? "0" : db.PolozeniPredmeti.Where(x => x.StudentId == s.Id).Average(x => x.Ocjena).ToString("N2");

                    dsTabela.Rows.Add(Red);
                }

                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = dsTabela;
            }
        }

        private void Filtriraj()
        {

            odabranaDrzava = cbDrzava.SelectedItem as DrzavaIB000000;

            var grad = cbGrad.SelectedItem == null ? "" : cbGrad.SelectedItem.ToString();
            var drzava = cbDrzava.SelectedItem as DrzavaIB000000;


            studenti = db.Studenti.Include("Grad").Where(x =>
            (x.Grad.Naziv == grad) && (x.Grad.Drzava.Id == drzava.Id)
            ).ToList();
            if (studenti != null)
            {
                var dsTabela = new DataTable();
                dsTabela.Columns.Add("ImePrezime");
                dsTabela.Columns.Add("Drzava");
                dsTabela.Columns.Add("Grad");
                dsTabela.Columns.Add("Prosjek");

                for (int i = 0; i < studenti.Count(); i++)
                {
                    var s = studenti[i];
                    var Red = dsTabela.NewRow();
                    Red["ImePrezime"] = s.ToString();
                    Red["Drzava"] = s.Grad.Drzava.ToString();
                    Red["Grad"] = s.Grad.ToString();
                    Red["Prosjek"] = db.PolozeniPredmeti.Where(x => x.StudentId == s.Id).Count() == 0 ? "0" : db.PolozeniPredmeti.Where(x => x.StudentId == s.Id).Average(x => x.Ocjena).ToString("N2");
                    dsTabela.Rows.Add(Red);
                }

                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = dsTabela;
            }
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtriraj();

            cbGrad.DataSource = db.GradoviIB000000.Where(x => x.DrzavaID == odabranaDrzava.Id).Count() == 0 ?
                null : db.GradoviIB000000.Where(x => x.DrzavaID == odabranaDrzava.Id).ToList();
        }

        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtriraj();
        }
    }
}
