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
        List<PrisustvoIB180079> prisustva;
        int brojac = 0;


        public frmPrisustvoIB180079(ProstorijeIB180079 odabranaProstorija)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
        }

        private void frmPrisustvoIB180079_Load(object sender, EventArgs e)
        {
            dgvPrisustva.AutoGenerateColumns = false;

            cbNastave.DataSource = db.NastavaIB180079
                .Include(x => x.Predmet)
                .Where(x => x.ProstorijaId == odabranaProstorija.Id)
                .ToList();

            cbStudent.DataSource = db.Studenti.ToList();

            lblProstorija.Text = odabranaProstorija.Naziv;


            UcitajPrisustva();


            UcitajPrebrojavanje();

        }

        private void UcitajPrisustva()
        {
            prisustva = db.PrisustvoIB180079
                .Include(x => x.Nastava).ThenInclude(x => x.Predmet)
                .Include(x => x.Nastava).ThenInclude(x => x.Prostorija)
                .Include(x => x.Student)
                .Where(x => x.Nastava.Prostorija.Naziv == odabranaProstorija.Naziv)
                .ToList();

            if (prisustva != null)
            {
                dgvPrisustva.DataSource = null;
                dgvPrisustva.DataSource = prisustva;
            }

            brojac = prisustva.Count();

            UcitajPrebrojavanje();

        }

        private void UcitajPrebrojavanje()
        {
            lblOd.Text = brojac.ToString();
            lblDo.Text = odabranaProstorija.Kapacitet.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = cbStudent.SelectedItem as Student;
            var nastava = cbNastave.SelectedItem as NastavaIB180079;


            if (prisustva.Exists(x => x.StudentId == student.Id && x.NastavaId == nastava.Id))
            {
                MessageBox.Show("Taj student je vec evidentiran na toj nastavi", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(odabranaProstorija.Kapacitet == prisustva.Count()) // 30 == 30 
                {
                    MessageBox.Show("Kapacitet prostorije je pun","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                   var NovoPrisustvo = new PrisustvoIB180079()
                   {
                       StudentId = student.Id,
                       NastavaId = nastava.Id

                   };

                   db.PrisustvoIB180079.Add(NovoPrisustvo);

                }



            }

            db.SaveChanges();

            UcitajPrisustva();


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // 1. dio
            // - postavljanje threada
            // - sve sto je vezano za combobox

            if (Validiraj())
            {

                var student = cbStudent.SelectedItem as Student;
                var nastava = cbNastave.SelectedItem as NastavaIB180079;

                Thread thread = new Thread(() => GenerisiPrisustva(student,nastava) );
                thread.Start();


            }

        }

        private void GenerisiPrisustva(Student? student, NastavaIB180079? nastava)
        {
            // 2. dio 
            // -- sve kalukacije i pohranjivanja
            // -- timer

            Thread.Sleep(3000);

            var broj = int.Parse(txtBroj.Text); // 2
            string info = "";

            for (int i = 0; i < broj; i++)
            {

                var novoPrisustvo = new PrisustvoIB180079()
                {
                    StudentId = student.Id,
                    NastavaId = nastava.Id
                };

                info += $"{DateTime.Now.ToString("dd.MM HH:mm:ss")} -> {student} za {nastava} {Environment.NewLine}";

                db.PrisustvoIB180079.Add(novoPrisustvo);
                db.SaveChanges();

            }


            // 3. dio
            // -- ispisi , ucitavanja, mbox

            Action action = () =>
            {


                UcitajPrisustva();
                txtInfo.Text = info;
                MessageBox.Show($"Generisano je {broj} prisustva","Informacija",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtBroj.Clear();


            };
            BeginInvoke(action);




        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtBroj, err, Kljucevi.ReqiredValue);
        }
    }
}
