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
    public partial class frmPrisustvoIB180079 : Form
    {
        private ProstorijeIB180079 odabranaProstorija;
        DLWMSDbContext db = new DLWMSDbContext();
        int brojStudenataNaNastavi = 0;
        List<PrisustvoIB180079> prisustva;
        NastavaIB180079 odabranaNastava;

        public frmPrisustvoIB180079(ProstorijeIB180079 odabranaProstorija)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
        }

        private void frmPrisustvoIB180079_Load(object sender, EventArgs e)
        {
            dgvNastava.AutoGenerateColumns = false;
            lblProstorija.Text = $"{odabranaProstorija.Naziv} - {odabranaProstorija.Oznaka}";
            cbNastava.DataSource = db.NastavaIB180079.Include(x => x.Predmet).Where(x => x.ProstorijaId == odabranaProstorija.Id).ToList();
            cbStudent.DataSource = db.Studenti.ToList();
            UcitajPrisustvaNastave();
            UcitajPrebrojavanje();
        }

        private void UcitajPrisustvaNastave()
        {
            odabranaNastava = cbNastava.SelectedItem as NastavaIB180079;



            prisustva = db.PrisustvoIB180079.Include(x => x.Student).Include(x => x.Nastava).ThenInclude(x => x.Predmet).Where(x => x.NastavaId == odabranaNastava.Id).ToList();

            if (prisustva != null)
            {
                for (int i = 0; i < prisustva.Count(); i++)
                {
                    prisustva[i].Info = $"{prisustva[i].Nastava.Predmet} - u {prisustva[i].Nastava.Dan} @ {prisustva[i].Nastava.Vrijeme}";
                }

                brojStudenataNaNastavi = prisustva.Count();

                dgvNastava.DataSource = null;
                dgvNastava.DataSource = prisustva;
            }
            UcitajPrebrojavanje();
        }

        private void UcitajPrebrojavanje()
        {
            lblOdDo.Text = $"{brojStudenataNaNastavi}/{odabranaProstorija.Kapacitet}";
        }

        private void cbNastava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPrisustvaNastave();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = cbStudent.SelectedItem as Student;
            var nastava = cbNastava.SelectedItem as NastavaIB180079;

            var novoPrisustvo = new PrisustvoIB180079()
            {
                StudentId = student.Id,
                NastavaId = nastava.Id

            };

            if (db.PrisustvoIB180079.ToList().Exists(x => x.StudentId == student.Id && x.NastavaId == nastava.Id))
            {
                MessageBox.Show("Student je već evidentiran na toj nastavi", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (odabranaProstorija.Kapacitet == brojStudenataNaNastavi)
            {
                MessageBox.Show("Dosegli ste maksimalan broj studenata u prostoriji", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                db.PrisustvoIB180079.Add(novoPrisustvo);
                db.SaveChanges();

                MessageBox.Show("Prisustvo je evidentirano", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



            UcitajPrisustvaNastave();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var odabraniStudent = cbStudent.SelectedItem as Student;

                Thread thread = new Thread(() => GenerisiPrisustva(odabraniStudent));
                thread.Start();
            }
        }

        private void GenerisiPrisustva(Student? odabraniStudent)
        {
            Thread.Sleep(300);

            var broj = int.Parse(txtBroj.Text);
            var info = "";
            var sveNastaveProstorije = db.NastavaIB180079.Where(x => x.ProstorijaId == odabranaProstorija.Id).ToList();

            if(brojStudenataNaNastavi + broj >= odabranaProstorija.Kapacitet)
            {
                MessageBox.Show("Ako generišete ta prisustva prekoračit ćete maksimalan kapacitet prostorije na nekoj nastavi", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             for (int i = 0; i < broj; i++)
             {

                 for (int j = 0; j < sveNastaveProstorije.Count(); j++)
                 {

                     var novoPrisustvo = new PrisustvoIB180079()
                     {
                         StudentId = odabraniStudent.Id,
                         NastavaId = sveNastaveProstorije[j].Id
                     };

                     db.PrisustvoIB180079.Add(novoPrisustvo);

                     info += $"{DateTime.Now.ToString("dd.MM HH:mm:ss")} -> {odabraniStudent} za  {sveNastaveProstorije[j].Predmet} u {sveNastaveProstorije[j].Dan} @{sveNastaveProstorije  [j].Vrijeme} {Environment.NewLine}";

                 }



           }



            db.SaveChanges();

            Action action = () =>
            {
                UcitajPrisustvaNastave();
                MessageBox.Show($"Prisustva su generisana", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInfo.Text = info;

            };
            BeginInvoke(action);
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtBroj, err, Kljucevi.ReqiredValue);
        }
    }
}
