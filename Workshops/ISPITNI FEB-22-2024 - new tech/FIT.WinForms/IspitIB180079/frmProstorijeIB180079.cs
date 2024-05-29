using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB180079
{
    public partial class frmProstorijeIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<ProstorijeIB180079> prostorije;
        public frmProstorijeIB180079()
        {
            InitializeComponent();
        }

        private void frmProstorijeIB180079_Load(object sender, EventArgs e)
        {

            dgvProstorije.AutoGenerateColumns = false;

            UcitajProstorije();


        }

        private void UcitajProstorije()
        {
            prostorije = db.ProstorijeIB180079.ToList();


            if (prostorije != null)
            {
                var SveNastave = db.NastavaIB180079.ToList();

                for (int i = 0; i < prostorije.Count(); i++)
                {
                    // 
                    prostorije[i].Broj = SveNastave.Where(x => x.ProstorijaId == prostorije[i].Id).Count();
                }



                dgvProstorije.DataSource = null;
                dgvProstorije.DataSource = prostorije;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNovaProstorijaIB180079 frmNova = new frmNovaProstorijaIB180079();
            if (frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajProstorije();
                MessageBox.Show("Prostorija je dodana", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProstorije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabranaProstorija = prostorije[e.RowIndex];

            // var odabranaProstorija2 = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijeIB180079;

            if (e.ColumnIndex != 5 || e.ColumnIndex != 6)
            {

                frmNovaProstorijaIB180079 frmNova = new frmNovaProstorijaIB180079(odabranaProstorija);
                if (frmNova.ShowDialog() == DialogResult.OK)
                {
                    UcitajProstorije();
                    MessageBox.Show("Prostorija je modifikovana", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void dgvProstorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaProstorija = prostorije[e.RowIndex];

            // var odabranaProstorija2 = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijeIB180079;

            if (e.ColumnIndex == 5)
            {
                frmNastavaIB180079 frmNastava = new frmNastavaIB180079(odabranaProstorija);
                if (frmNastava.ShowDialog() == DialogResult.OK)
                {
                    UcitajProstorije();
                }
            }
            else if (e.ColumnIndex == 6)
            {

                frmPrisustvoIB180079 frmPrisustvo = new frmPrisustvoIB180079(odabranaProstorija);
                frmPrisustvo.ShowDialog();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var odabranaProstorija = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijeIB180079;


            frmIzvjestaji frmIzvjestaj = new frmIzvjestaji(odabranaProstorija);
            frmIzvjestaj.ShowDialog();
        }
    }
}
