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
        DrzaveIB180079 odabranaDrzava;
        public frmPretragaIB180079()
        {
            InitializeComponent();
        }

        private void frmPretragaStudenataIB180079_Load(object sender, EventArgs e)
        {
            cbDrzava.DataSource = db.DrzaveIB180079.ToList();
        }

        private void UcitajStudente()
        {
            odabranaDrzava = cbDrzava.SelectedItem as DrzaveIB180079;

            var grad = cbGrad.SelectedItem == null ? "Svi" : cbGrad.SelectedItem.ToString();


            studenti = db.Studenti.Include("Grad").Include("Semestar")
                .Where(x => (x.Grad.Naziv == grad || grad == "Svi") &&
                x.Grad.DrzavaId == odabranaDrzava.Id)
                .ToList();

            if (studenti != null)
            {

                var tblStudenti = new DataTable();
                tblStudenti.Columns.Add("Ime");
                tblStudenti.Columns.Add("Prezime");
                tblStudenti.Columns.Add("Drzava");
                tblStudenti.Columns.Add("Grad");
                tblStudenti.Columns.Add("Prosjek");

                for (int i = 0; i < studenti.Count(); i++)
                {
                    var student = studenti[i];
                    var Red = tblStudenti.NewRow();
                    Red["Ime"] = student.Ime.ToString();
                    Red["Prezime"] = student.Prezime.ToString();
                    Red["Drzava"] = student.Grad.Drzava.ToString();
                    Red["Grad"] = student.Grad.ToString();
                    Red["Prosjek"] = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Count() == 0 ? "5" : db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena).ToString("N2");
                    tblStudenti.Rows.Add(Red);
                }

                dgvStudenti.DataSource = null;
                dgvStudenti.DataSource = tblStudenti;
            }
            if(studenti.Count() == 0)
            {
                MessageBox.Show($"U bazi nije evidentiran niti jedan student rođen u gradu {grad}, {odabranaDrzava}","Informacija",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();

            cbGrad.DataSource = db.GradoviIB180079.Where(x => x.DrzavaId == odabranaDrzava.Id).Count() == 0 ? null : db.GradoviIB180079.Where(x => x.DrzavaId == odabranaDrzava.Id).ToList();
        }

        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
    }
}
