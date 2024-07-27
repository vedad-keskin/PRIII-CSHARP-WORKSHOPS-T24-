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

        public frmPrisustvoIB180079(ProstorijeIB180079 odabranaProstorija)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
        }

        private void frmPrisustvoIB180079_Load(object sender, EventArgs e)
        {
            dgvPrisustva.AutoGenerateColumns = false;

            lblProstorijaNaziv.Text = $"{odabranaProstorija.Naziv} - {odabranaProstorija.Oznaka}";

            cbNastava.DataSource = db.NastavaIB180079.Where(x => x.ProstorijaId == odabranaProstorija.Id).ToList();

            cbNastava.DisplayMember = "Oznaka";

            cbStudent.DataSource = db.Studenti.ToList();



        }

        private void cbNastava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPrisustva();
        }

        private void UcitajPrisustva()
        {
            var nastava = cbNastava.SelectedItem as NastavaIB180079;


            prisustva = db.PrisustvoIB180079
                .Include(x => x.Nastava).ThenInclude(x => x.Predmet)
                .Include(x => x.Student)
                .Where(x => x.NastavaId == nastava.Id)
                .ToList();

            if (nastava != null)
            {

                dgvPrisustva.DataSource = null;
                dgvPrisustva.DataSource = prisustva;

            }

            lblPrebrojavanje.Text = $"{prisustva.Count()}/{odabranaProstorija.Kapacitet}";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var student = cbStudent.SelectedItem as Student;
            var nastava = cbNastava.SelectedItem as NastavaIB180079;

            if (prisustva.Exists(x => x.StudentId == student.Id))
            {
                MessageBox.Show("Student je vec evidentiran na toj nastavi", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //    8              ==    8 
                if (prisustva.Count() == odabranaProstorija.Kapacitet)
                {
                    MessageBox.Show("Prostorija je popunjena", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    var novoPrisutvo = new PrisustvoIB180079()
                    {

                        NastavaId = nastava.Id,
                        StudentId = student.Id

                    };

                    db.PrisustvoIB180079.Add(novoPrisutvo);
                    db.SaveChanges();
                }


            }



            UcitajPrisustva();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // 1. dio 
            // -- dodamo async
            // -- postavljanje threada
            // -- pokretanje threada
            // -- sve sto je vezano za combobox radimo ovdje
            // -- validacija

            var student = cbStudent.SelectedItem as Student;
            var nastava = cbNastava.SelectedItem as NastavaIB180079;

            if (Validiraj())
            {

                Thread thread = new Thread(() => GenerisiPrisustva(student,nastava));
                thread.Start();
            }



        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtBroj, err, Kljucevi.ReqiredValue);
        }

        private void GenerisiPrisustva(Student? student, NastavaIB180079? nastava)
        {
            // 2. dio
            // -- pohrane ali ako one nisu iz comboboxa
            // -- kalkalacije
            // -- pohrane na bazu
            // -- spavanje threada

            Thread.Sleep(300);

            var broj = int.Parse(txtBroj.Text);
            string info = "";

            for (int i = 0; i < broj; i++)
            {

                var novoPrisustvo = new PrisustvoIB180079()
                {
                    StudentId = student.Id,
                    NastavaId = nastava.Id
                };


                db.PrisustvoIB180079.Add(novoPrisustvo);
                db.SaveChanges();

                info += $"{DateTime.Now.ToString("dd.MM HH:mm:ss")} -> {student} za {nastava} {Environment.NewLine}";

            }


            Action action = () => {

                // 3. dio
                // -- mbox
                // -- ispisi
                // -- ucitavanja

                UcitajPrisustva();
                MessageBox.Show($"Generisali ste {broj} prisustva","Informacija",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtInfo.Text = info;

                txtBroj.Clear();

            };
            BeginInvoke(action);




        }

 
    }
}
