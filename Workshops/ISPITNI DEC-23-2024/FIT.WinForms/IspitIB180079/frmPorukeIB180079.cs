using FIT.Data;
using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using FIT.WinForms.Izvjestaji;
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
    public partial class frmPorukeIB180079 : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiPorukeIB180079> poruke;

        public frmPorukeIB180079(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmPorukeIB180079_Load(object sender, EventArgs e)
        {
            dgvPoruke.AutoGenerateColumns = false;

            lblStudent.Text = $"Poruke studenta {student}";

            UcitajPoruke();

            cbPredmet.DataSource = db.Predmeti.ToList();
        }

        private void UcitajPoruke()
        {
            poruke = db.StudentiPorukeIB180079
                .Include(x => x.Predmet)
                .Include(x => x.Student)
                .Where(x => x.StudentId == student.Id)
                .Where(x => x.Validnost >= DateTime.Now)
                .ToList();

            if (poruke != null)
            {
                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = poruke;
            }


            btnDodaj.Enabled = poruke.Count() == 0 ? false : true;


            this.Text = $"Broj poruka: {poruke.Count()}";

        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabranaPoruka = poruke[e.RowIndex];

            if (e.ColumnIndex == 5)
            {

                if (MessageBox.Show("Da li ste sigurni da želite izbrisati odabranu poruku ?", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    db.StudentiPorukeIB180079.Remove(odabranaPoruka);
                    db.SaveChanges();

                    UcitajPoruke();

                }

            }

        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            var frmNovaPoruka = new frmNovaPorukaIB180079(student);

            if (frmNovaPoruka.ShowDialog() == DialogResult.OK)
            {
                UcitajPoruke();
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            // 1. dio
            // -- async/await/task ILI kreiranje i pokretanje threada
            // -- validacija
            // -- sve vezano za combobox


            if (ValidirajMultithreading())
            {

                var predmet = cbPredmet.SelectedItem as PredmetiIB180079;
                
                await Task.Run(() => GenerisiPoruke(predmet));

                //Thread thread = new Thread(() => GenerisiPoruke(predmet));
                //thread.Start();

            }



        }

        private void GenerisiPoruke(PredmetiIB180079? predmet)
        {
            // 2. dio
            // -- kalkulacije
            // -- pohrane
            // -- sleep

            var broj = int.Parse(txtBroj.Text);
            var info = "";
            var validnost = dtpValidnost.Value;


            for (int i = 0; i < broj; i++)
            {
                Thread.Sleep(300);

                var novaPoruka = new StudentiPorukeIB180079()
                {
                    StudentId = student.Id,
                    PredmetId = predmet.Id,
                    Hitnost = "Srednja",
                    Validnost = validnost,
                    Sadrzaj = $"{i + 1}. GENERISANA PORUKA",
                    Slika = poruke[0].Slika


                };

                db.StudentiPorukeIB180079.Add(novaPoruka);
                db.SaveChanges();

                info += $"{DateTime.Now} -> generisana poruka za {student} na predmetu {predmet}{Environment.NewLine}";


            }


            Action action = () =>
            {
                // 3. dio
                // -- mbox
                // -- ucitavanje
                // -- info

                MessageBox.Show($"Uspješno je generisano {broj} poruka za studenta {student}", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UcitajPoruke();
                txtInfo.Text = info;

            };
            BeginInvoke(action);


        }

        private bool ValidirajMultithreading()
        {
            return Validator.ProvjeriUnos(txtBroj, err, Kljucevi.ReqiredValue);
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var frmIzvjestaj = new frmIzvjestaji(poruke);

            frmIzvjestaj.ShowDialog();
        }
    }
}
