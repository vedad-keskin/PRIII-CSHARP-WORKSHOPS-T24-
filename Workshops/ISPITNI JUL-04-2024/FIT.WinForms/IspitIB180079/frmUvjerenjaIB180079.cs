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
using System.Diagnostics.CodeAnalysis;
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
            UcitajUvjerenja();

            cbVrsta.SelectedIndex = 0;
        }

        private void UcitajUvjerenja()
        {
            uvjerenja = db.StudentiUvjerenjaIB180079
                .Include(x=> x.Student)
                .Where(x => x.StudentId == odabraniStudent.Id)
                .ToList();

            if (uvjerenja != null)
            {
                dgvUvjerenja.DataSource = null;
                dgvUvjerenja.DataSource = uvjerenja;
            }

            this.Text = $"Broj uvjerenja -> {uvjerenja.Count()}";


            btnDodaj.Enabled = uvjerenja.Count() == 0 ? false : true;


        }

        private void btnNovi_Click(object sender, EventArgs e)
        {

            var frmNovoUvjerenje = new frmNovoUvjerenjeIB180079(odabraniStudent);

            if (frmNovoUvjerenje.ShowDialog() == DialogResult.OK)
            {
                UcitajUvjerenja();
            }


        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabranoUvjerenje = uvjerenja[e.RowIndex];

            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Da li ste sigurni da zelite izbrisati odabrano uvjerenje?", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    db.StudentiUvjerenjaIB180079.Remove(odabranoUvjerenje);
                    db.SaveChanges();

                    UcitajUvjerenja();

                }



            }else if (e.ColumnIndex == 6)
            {



                var frmIzvjestaj = new frmIzvjestaji(odabranoUvjerenje);

                frmIzvjestaj.ShowDialog();


                odabranoUvjerenje.Printano = true;

                db.StudentiUvjerenjaIB180079.Update(odabranoUvjerenje);
                db.SaveChanges();
                UcitajUvjerenja();

            }

        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            // 1. dio

            if (Validiraj())
            {

                //Thread thread = new Thread(() => GenenisiUvjerenja());
                //thread.Start();


                var vrsta = cbVrsta.SelectedItem.ToString();

                await Task.Run(() => GenenisiUvjerenja(vrsta));

            }


        }

        private void GenenisiUvjerenja(string? vrsta)
        {
            // 2. dio

            var broj = int.Parse(txtBroj.Text);

            var svrha = txtSvrha.Text;

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

                info += $"{DateTime.Now.ToString("HH:mm:ss")} -> {vrsta} {odabraniStudent} u svrhu {svrha}{Environment.NewLine}";

                db.StudentiUvjerenjaIB180079.Add(novoUvjerenje);
                db.SaveChanges();


            }



            Action action = () =>
            {
                // 3. dio

                UcitajUvjerenja();
                MessageBox.Show($"Uspješno ste generisali {broj} uvjerenja", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInfo.Text = info;


            };
            BeginInvoke(action);


        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtBroj, err, Kljucevi.ReqiredValue)
                &&
                Validator.ProvjeriUnos(txtSvrha, err, Kljucevi.ReqiredValue);
        }
    }
}
