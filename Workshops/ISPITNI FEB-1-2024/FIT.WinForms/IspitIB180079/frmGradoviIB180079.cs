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
            gradovi = db.GradoviIB180079
                .Where(x => x.DrzavaId == odabranaDrzava.Id)
                .ToList();


            if (gradovi != null)
            {

                dgvGradovi.DataSource = null;
                dgvGradovi.DataSource = gradovi;

            }
        }

        private void UcitajInfo()
        {
            pbZastava.Image = odabranaDrzava.Zastava.ToImage();

            lblNazivDrzave.Text = odabranaDrzava.Naziv;

        }

        private void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabraniGrad = gradovi[e.RowIndex];

            if (e.ColumnIndex == 2)
            {


                odabraniGrad.Status = !odabraniGrad.Status;


                // pohrana          =          iskaz/provjera     ? ako je true uradi ovo : ako ovo nije true ;
                //odabraniGrad.Status = odabraniGrad.Status ? false : true;

                // ?? ako je lijeva strana null neka se nesto desi -> 


                db.GradoviIB180079.Update(odabraniGrad);
                db.SaveChanges();

                UcitajGradove();


            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {

                var naziv = txtNaziv.Text;

                //                        mostar == mostar
                if (gradovi.Exists(x => x.Naziv.ToLower() == naziv.ToLower()))
                {
                    MessageBox.Show($"Grad {naziv} već postoji u državi {odabranaDrzava.Naziv}", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var noviGrad = new GradoviIB180079()
                    {
                        Naziv = naziv,
                        Status = true,
                        DrzavaId = odabranaDrzava.Id,

                        // Drzava = odabranaDrzava BAZA PUCA 

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

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            // 1. dio
            // -- validacija
            // -- kreiranje threada/pokretanje threada ili await/async/run
            // -- [---]


            if (ValidirajMultithreading())
            {

                Thread t1 = new Thread(() => GenerisiGradove());
                t1.Start();

            }



        }

        private void GenerisiGradove()
        {
            // 2. dio
            // -- pohrane
            // -- kalkulacije
            // -- sleep

            var broj = int.Parse(txtBroj.Text);

            var status = chbStatus.Checked;

            var info = "";

            for (int i = 0; i < broj; i++) // i = 0  1 2 3 4 5 
            {
                Thread.Sleep(300);

                var noviGrad = new GradoviIB180079()
                {
                    Status = status,
                    Naziv = $"Grad {i + 1}.",
                    DrzavaId = odabranaDrzava.Id

                };

                info += $"{DateTime.Now.ToString("dd.MM HH:mm:ss")} -> dodat grad {noviGrad.Naziv} za drzavu {odabranaDrzava.Naziv}{Environment.NewLine}";

                db.GradoviIB180079.Add(noviGrad);
                db.SaveChanges();



            }





            Action action = () =>
            {
                // 3. dio
                // -- mbox
                // -- ispis
                // -- ucitavanje

                UcitajGradove();
                MessageBox.Show($"Generisano je {broj} gradova","Informacija",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtInfo.Text = info;


            };
            BeginInvoke(action);


        }

        private bool ValidirajMultithreading()
        {
            return Validator.ProvjeriUnos(txtBroj, err, Kljucevi.ReqiredValue);
        }
    }
}
