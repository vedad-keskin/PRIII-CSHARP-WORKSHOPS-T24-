using FIT.Data;
using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using FIT.WinForms.Izvjestaji;
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
    public partial class frmUvjerenjaIB180079 : Form
    {
        private Student odabraniStudent;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiUvjerenjaIB180079> uvjerenja;

        public frmUvjerenjaIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void frmUvjerenjaIB180079_Load(object sender, EventArgs e)
        {
            dgvUvjerenja.AutoGenerateColumns = false;
            cbVrsta.SelectedIndex = 0;
            UcitajUvjerenja();
        }

        private void UcitajUvjerenja()
        {
            uvjerenja = db.StudentiUvjerenjaIB180079
                .Where(x => x.StudentId == odabraniStudent.Id)
                .ToList();


            if (uvjerenja != null)
            {

                dgvUvjerenja.DataSource = null;
                dgvUvjerenja.DataSource = uvjerenja;
            }


            this.Text = $"Broj uvjerenja -> {uvjerenja.Count()}";

            if(uvjerenja.Count() == 0)
            {
                btnDodaj.Enabled = false;
            }
            else
            {
                btnDodaj.Enabled = true;
            }


        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            frmNovoUvjerenjeIB180079 frmNovo = new frmNovoUvjerenjeIB180079(odabraniStudent);

            if (frmNovo.ShowDialog() == DialogResult.OK)
            {
                UcitajUvjerenja();
            }
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranoUvjerenje = uvjerenja[e.RowIndex];

            if (e.ColumnIndex == 5)
            {

                if (MessageBox.Show("Da li ste sigurni da želite izbrisati odabrano uvjerenje", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.StudentiUvjerenjaIB180079.Remove(odabranoUvjerenje);
                    db.SaveChanges();

                    UcitajUvjerenja();

                }


            }
            if (e.ColumnIndex == 6)
            {
                frmIzvjestaji frmIzvjestaj = new frmIzvjestaji(odabranoUvjerenje);

                if(frmIzvjestaj.ShowDialog() == DialogResult.OK)
                {
                    odabranoUvjerenje.Printano = true;
                    db.StudentiUvjerenjaIB180079.Update(odabranoUvjerenje);
                    db.SaveChanges();
                    UcitajUvjerenja();

                }

            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            // 1. DIO
            // -- async
            // -- postavaljanje i pokretanje threada
            // -- validacija
            // -- sve sto je vezano za combo box

            var vrsta = cbVrsta.SelectedItem.ToString();


            if (ValidrajMultithreading())
            {
                Thread t1 = new Thread(() => GenerisiUvjerenja(vrsta));
                t1.Start();
            }

        }

        private void GenerisiUvjerenja(string? vrsta)
        {
            // 2. DIO
            // -- pohrane
            // -- kalkulacije
            // -- sleep

            var svrha = txtSvrha.Text;
            var broj = int.Parse(txtBroj.Text);
            var info = "";

            for (int i = 0; i < broj; i++)
            {
                Thread.Sleep(300);

                var novoUvjerenje = new StudentiUvjerenjaIB180079()
                {
                    StudentId = odabraniStudent.Id,
                    Vrijeme = DateTime.Now,
                    Vrsta = vrsta,
                    Svrha = svrha,
                    Uplatnica = uvjerenja[0].Uplatnica,
                    Printano = false
                };

                info += $"{DateTime.Now.ToString("HH:mm:ss")} -> {vrsta} ({odabraniStudent.Indeks}) - {odabraniStudent.ImePrezime} u {svrha} {Environment.NewLine}";

                db.StudentiUvjerenjaIB180079.Add(novoUvjerenje);
                db.SaveChanges();

            }

            Action action = () =>
            {
                // 3. DIO 
                // -- ispis
                // -- ucitavanje
                // -- mbox

                UcitajUvjerenja();
                MessageBox.Show($"Uspješno ste generisali {broj} zahtjeva","Informacija",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtInfo.Text = info;    



            };
            BeginInvoke(action);


        }

        private bool ValidrajMultithreading()
        {
            return Validator.ProvjeriUnos(txtBroj, err, Kljucevi.ReqiredValue) && 
                Validator.ProvjeriUnos(txtSvrha, err, Kljucevi.ReqiredValue) &&
Validator.ProvjeriUnos(cbVrsta, err, Kljucevi.ReqiredValue);

        }
    }
}
