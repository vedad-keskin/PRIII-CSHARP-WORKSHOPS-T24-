using FIT.Infrastructure;
using FIT.WinForms.IspitIB000000;
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

namespace FIT.WinForms
{
    public partial class frmPocetna : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            lblKonekcijaInfo.Text = $"Broj studenata u bazi -> {db.Studenti.Count()}";
            Text = "GLAVNA FORMA";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            frmDrzaveIB000000 frm = new frmDrzaveIB000000();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmPretragaIB000000();
            frm.ShowDialog();
        }
    }
}
