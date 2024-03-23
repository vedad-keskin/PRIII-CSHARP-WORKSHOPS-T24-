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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB180079
{
    public partial class frmProstorijeIB180079 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<ProstorijeIB180079> prostorije;
        ProstorijeIB180079 odabranaProstorija;
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

                for (int i = 0; i < prostorije.Count(); i++)
                {
                    var sveNastave = db.NastavaIB180079.ToList();

                    prostorije[i].Broj = sveNastave.Where(x => x.ProstorijaId == prostorije[i].Id).Count();
                }


                dgvProstorije.DataSource = null;
                dgvProstorije.DataSource = prostorije;
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            odabranaProstorija = dgvProstorije.SelectedRows[0].DataBoundItem as ProstorijeIB180079;

            frmIzvjestaji frmIzvjestaj = new frmIzvjestaji(odabranaProstorija);
            frmIzvjestaj.ShowDialog();
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            frmNovaProstorijaIB180079 frmNovaProstorija = new frmNovaProstorijaIB180079();
            if (frmNovaProstorija.ShowDialog() == DialogResult.OK)
            {
                UcitajProstorije();
                MessageBox.Show("Zapis je dodan", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvProstorije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            odabranaProstorija = prostorije[e.RowIndex];

            if (e.ColumnIndex == 5 || e.ColumnIndex == 6) // double click na dva buttona koje necemo koristit jer nam treba jednostruki klik na njih
            {

            }
            else
            {
                frmNovaProstorijaIB180079 frmNovaProstorija = new frmNovaProstorijaIB180079(odabranaProstorija);
                if (frmNovaProstorija.ShowDialog() == DialogResult.OK)
                {
                    UcitajProstorije();
                    MessageBox.Show("Zapis je modifikovan", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvProstorije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            odabranaProstorija = prostorije[e.RowIndex];

            if (e.ColumnIndex == 5) // pregled nastave
            {
                frmNastavaIB180079 frmNastava = new frmNastavaIB180079(odabranaProstorija);
                if(frmNastava.ShowDialog() == DialogResult.OK)
                {
                    UcitajProstorije();
                }
            }
            else if (e.ColumnIndex == 6) // pregled prisustva
            {
                var brojNastavaUProstoriji = db.NastavaIB180079.Where(x => x.ProstorijaId == odabranaProstorija.Id).Count();

                if(brojNastavaUProstoriji != 0)
                {
                    frmPrisustvoIB180079 frmPrisustvo = new frmPrisustvoIB180079(odabranaProstorija);
                    frmPrisustvo.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Prostorija nema zakazanih nastava", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
