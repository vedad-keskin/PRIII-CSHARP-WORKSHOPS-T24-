using FIT.Data.IspitIB0000000;
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

namespace FIT.WinForms.IspitIB000000
{
    public partial class frmDrzaveIB000000 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<DrzavaIB000000> drzava;
        public frmDrzaveIB000000()
        {
            InitializeComponent();
        }

        private void frmDrzaveIB000000_Load(object sender, EventArgs e)
        {
            dgvDrzave.AutoGenerateColumns = false;
            UcitajSve();
        }

        private void UcitajSve()
        {
            drzava = db.DrzaveIB000000.ToList();
            if (drzava != null)
            {
                var dsTable = new DataTable();
                dsTable.Columns.Add("Zastava", typeof(Image));
                dsTable.Columns.Add("Naziv");
                dsTable.Columns.Add("BrojGradova");
                for (int i = 0; i < drzava.Count(); i++)
                {
                    var d = drzava[i];

                    var Red = dsTable.NewRow();
                    Red["Zastava"] = Ekstenzije.ToImage(d.Zastava);
                    Red["Naziv"] = d.Naziv.ToString();
                    Red["BrojGradova"] = db.GradoviIB000000.Where(x => x.DrzavaID == d.Id).Count().ToString();

                    dsTable.Rows.Add(Red);
                }


                dgvDrzave.DataSource = null;
                dgvDrzave.DataSource = dsTable;

            }
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            frmNovaDrzavaIB000000 frm = new frmNovaDrzavaIB000000();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                UcitajSve();

            }
        }

        private void dgvDrzave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaDrzava = drzava[e.RowIndex];
            if (e.ColumnIndex == 3)
            {
                frmGradoviIB000000 forma = new frmGradoviIB000000(odabranaDrzava);
                forma.ShowDialog();
            }
            
        }
    }

}
