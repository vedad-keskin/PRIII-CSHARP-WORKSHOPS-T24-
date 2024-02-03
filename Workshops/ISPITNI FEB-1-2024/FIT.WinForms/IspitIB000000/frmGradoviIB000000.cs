using FIT.Data.IspitIB0000000;
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

namespace FIT.WinForms.IspitIB000000
{
    public partial class frmGradoviIB000000 : Form
    {
        private DrzavaIB000000 odabranaDrzava;
        DLWMSDbContext db = new DLWMSDbContext();
        List<GradIB000000> gradovi;

        public frmGradoviIB000000()
        {
        }

        public frmGradoviIB000000(DrzavaIB000000 odabranaDrzava)
        {
            InitializeComponent();
            Text = "Dodavanje gradova";
            this.odabranaDrzava = odabranaDrzava;


        }

        private void frmGradoviIB000000_Load(object sender, EventArgs e)
        {
            dgvGradovi.AutoGenerateColumns = false;
            lblDrzava.Text = odabranaDrzava.Naziv.ToString();
            pbSlika.Image = Helpers.Ekstenzije.ToImage(odabranaDrzava.Zastava);
            FiltrirajGradove();
        }

        private void FiltrirajGradove()
        {
            gradovi = db.GradoviIB000000.Include("Drzava").Where(x =>
            x.DrzavaID == odabranaDrzava.Id
            ).ToList();

            if (gradovi != null)
            {
                dgvGradovi.DataSource = null;
                dgvGradovi.DataSource = gradovi;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var naziv = txtNaziv.Text;
                var aktivan = ckAktivan1.Checked;
                var noviGrad = new GradIB000000()
                {
                    DrzavaID = odabranaDrzava.Id,
                    Naziv = naziv,
                    Aktivan = aktivan,
                };
                db.GradoviIB000000.Add(noviGrad);
                db.SaveChanges();

                MessageBox.Show($"Uspijesno ste dodali grad {naziv}");
            }
            FiltrirajGradove();
        }

        private bool Validiraj()
        {
            return (Validator.ProvjeriUnos(txtNaziv, err, "Obavezan unos") &&
                Validator.ProvjeriUnos(ckAktivan1, err, "Obavezan unos")) ||
               (Validator.ProvjeriUnos(txtBroj, err, "Obavezan unos") &&
                Validator.ProvjeriUnos(ckAktivan2, err, "Obavezan unos"));

        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                Thread t1 = new Thread(() => GenerisiGradove());
                t1.Start();
            }
        }

        private void GenerisiGradove()
        {
            Thread.Sleep(300);
            var broj = int.Parse(txtBroj.Text);
            var aktivan = ckAktivan2.Checked;
            var info = "";
            for (int i = 0; i < broj; i++)
            {
                var NoviGrad = new GradIB000000()
                {
                    DrzavaID = odabranaDrzava.Id,
                    Naziv = $"{(i + 1)}. GRAD",
                    Aktivan = aktivan,
                };
                info += $"{DateTime.Now} -> {(i + 1)}. GRAD za drzavu {odabranaDrzava.Naziv} {Environment.NewLine}";
                db.GradoviIB000000.Add(NoviGrad);
                db.SaveChanges();

            }

            Action action = () =>
            {
                txtInfo.Text = info;
                FiltrirajGradove();
                MessageBox.Show($"Uspijesno dodano {broj} GRADA za drzavu  {odabranaDrzava}");
            };
            BeginInvoke(action);
            
        }

        private void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var promijeniStatus = gradovi[e.RowIndex];
            if (e.ColumnIndex == 2)
            {
                if (promijeniStatus.Aktivan)
                {
                    promijeniStatus.Aktivan = false;
                }
                else
                {
                    promijeniStatus.Aktivan = true;
                }
                db.Entry(promijeniStatus).State = EntityState.Modified;
                db.SaveChanges();

                FiltrirajGradove();

            }

        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            if(gradovi.Count() != 0)
            {
                frmIzvjestaji frm = new frmIzvjestaji(gradovi);
                frm.ShowDialog();
            }
        }


    }
}
