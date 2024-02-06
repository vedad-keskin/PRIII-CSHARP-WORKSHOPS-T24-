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
    public partial class frmDrzaveIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<DrzaveIB180079> drzave;
        DrzaveIB180079 odabranaDrzava;
        public frmDrzaveIB180079()
        {
            InitializeComponent();
        }

        private void frmDrzaveIB180079_Load(object sender, EventArgs e)
        {
            dgvDrzave.AutoGenerateColumns = false;
            UcitajVrijeme();
            UcitajDrzave();
        }

        private void UcitajDrzave()
        {
            drzave = db.DrzaveIB180079.ToList();

            if (drzave != null)
            {


                for (int i = 0; i < drzave.Count(); i++)
                {

                    drzave[i].BrojGradova = db.GradoviIB180079.Where(x => x.DrzavaId == drzave[i].Id).Count();

                }

                dgvDrzave.DataSource = null;
                dgvDrzave.DataSource = drzave;

                odabranaDrzava = drzave[0];

            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            UcitajVrijeme();
        }

        private void UcitajVrijeme()
        {
            tslVrijeme.Text = $"Trenutno vrijeme : {DateTime.Now.ToString("HH:mm:ss")}";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmNovaDrzavaIB180079 frmNova = new frmNovaDrzavaIB180079();

            if (frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajDrzave();
                MessageBox.Show("Država dodana.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDrzave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            odabranaDrzava = drzave[e.RowIndex];

            if (e.ColumnIndex == 4)
            {
                frmGradoviIB180079 frmGradovi = new frmGradoviIB180079(odabranaDrzava);
                if (frmGradovi.ShowDialog() == DialogResult.OK)
                {
                    UcitajDrzave();
                }
            }
            else
            {
                frmNovaDrzavaIB180079 frmModifikacija = new frmNovaDrzavaIB180079(odabranaDrzava);
                if (frmModifikacija.ShowDialog() == DialogResult.OK)
                {
                    UcitajDrzave();
                    MessageBox.Show("Država modifikovana.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (odabranaDrzava != null)
            {
                frmIzvjestaji frmIzvjestaj = new frmIzvjestaji(odabranaDrzava);
                frmIzvjestaj.ShowDialog();
            }
            else
            {
                MessageBox.Show("null je ");
            }


        }

        private void dgvDrzave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            odabranaDrzava = drzave[e.RowIndex];
        }
    }
}
