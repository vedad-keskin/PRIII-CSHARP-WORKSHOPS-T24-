using FIT.Data;
using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmGradoviIB180079 : Form
    {
        private DrzaveIB180079 odabranaDrzava;
        DLWMSDbContext db = new DLWMSDbContext();
        List<GradoviIB180079> gradovi;

        public frmGradoviIB180079(DrzaveIB180079 odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;
        }

        private void frmGradoviIB180079_Load(object sender, EventArgs e)
        {
            dgvGradovi.AutoGenerateColumns = false;
            UcitajInfo();
            UcitajGradove();
        }

        private void UcitajGradove()
        {
            gradovi = db.GradoviIB180079.Where(x => x.DrzavaId == odabranaDrzava.Id).ToList();

            if (gradovi != null)
            {

                dgvGradovi.DataSource = null;
                dgvGradovi.DataSource = gradovi;
            }
            if(gradovi.Count() == 0)
            {
                btnGenerisi.Enabled = false;
            }
            else
            {
                btnGenerisi.Enabled = true;
            }
        }

        private void UcitajInfo()
        {
            pbZastava.Image = Ekstenzije.ToImage(odabranaDrzava.Zastava);
            lblDrzava.Text = odabranaDrzava.Naziv;
        }

        private void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniGrad = gradovi[e.RowIndex];

            if (e.ColumnIndex == 2)
            {
                if (odabraniGrad.Status)
                {
                    odabraniGrad.Status = false;
                }
                else
                {
                    odabraniGrad.Status = true;
                }

                db.GradoviIB180079.Update(odabraniGrad);
            }
            UcitajGradove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var naziv = txtNaziv.Text;

                if (db.GradoviIB180079.ToList().Exists(x => x.DrzavaId == odabranaDrzava.Id && x.Naziv.ToLower() == naziv.ToLower()))
                {
                    MessageBox.Show("Već je unesen grad sa tim imenom!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var noviGrad = new GradoviIB180079()
                    {
                        Naziv = naziv,
                        Status = true,
                        DrzavaId = odabranaDrzava.Id
                    };

                    db.GradoviIB180079.Add(noviGrad);
                    db.SaveChanges();

                    txtNaziv.Clear();
                }
                UcitajGradove();
            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue);
        }

        private void frmGradoviIB180079_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            // 1. dio
            // -- validacija
            // -- async 
            // -- sve sto je vezano za combo box
            // -- postavljanje threada
            // -- pokretanje threada

            if (ValidirajMultithreading())
            {
                Thread thread = new Thread(() => GenerisiGradove());
                thread.Start();
            }
        }

        private void GenerisiGradove()
        {

            // 2. dio
            // -- kalkulacije
            // -- pohrane 
            // -- sleep


            var broj = int.Parse(txtBroj.Text);
            var status = chbStatus.Checked;
            var info = "";

            for (int i = 0; i < broj; i++)
            {
                Thread.Sleep(300);
                var noviGrad = new GradoviIB180079()
                {
                    Naziv = $"Grad {i+1}.",
                    Status = status,
                    DrzavaId = odabranaDrzava.Id
                };
                db.GradoviIB180079.Add(noviGrad);
                db.SaveChanges();

                info += $"{DateTime.Now.ToString("dd:MM")} {DateTime.Now.ToString("HH:mm:ss")} -> dodat grad Grad {i+1}. za državu {odabranaDrzava} {Environment.NewLine}";

            }

            // 3. dio
            // -- ispisi
            // -- mbox 
            // -- ucitavanje

            Action action = () =>
            {
                UcitajGradove();
                MessageBox.Show($"Generisano je {broj} gradova.","Informacija",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtInfo.Text = info;

            };
            BeginInvoke(action);

        }

        private bool ValidirajMultithreading()
        {
            return Validator.ProvjeriUnos(txtBroj,err2,Kljucevi.ReqiredValue);
        }
    }
}
