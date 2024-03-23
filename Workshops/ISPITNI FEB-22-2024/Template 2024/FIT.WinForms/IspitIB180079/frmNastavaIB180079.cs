using FIT.Data;
using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmNastavaIB180079 : Form
    {
        private ProstorijeIB180079 odabranaProstorija;
        DLWMSDbContext db = new DLWMSDbContext();
        List<NastavaIB180079> nastave;


        public frmNastavaIB180079(ProstorijeIB180079 odabranaProstorija)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
        }

        private void frmNastavaIB180079_Load(object sender, EventArgs e)
        {
            lblProstorija.Text = $"{odabranaProstorija.Naziv} - {odabranaProstorija.Oznaka}";
            cbPredmet.DataSource = db.Predmeti.ToList();
            dgvNastava.AutoGenerateColumns = false;
            UcitajNastave();
        }

        private void UcitajNastave()
        {
            nastave = db.NastavaIB180079.Include(x => x.Prostorija).Include(x => x.Predmet).Where(x=> x.ProstorijaId == odabranaProstorija.Id).ToList();

            if (nastave != null)
            {

                dgvNastava.DataSource = null;
                dgvNastava.DataSource = nastave;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {

                var dan = cbDan.SelectedItem.ToString();
                var vrijeme = cbVrijeme.SelectedItem.ToString();
                var predmet = cbPredmet.SelectedItem as PredmetiIB180079;

                var novaNastava = new NastavaIB180079()
                {
                    Dan = dan,
                    Vrijeme = vrijeme,
                    PredmetId = predmet.Id,
                    ProstorijaId = odabranaProstorija.Id,
                    Oznaka = $"{predmet} :: {dan} :: {vrijeme}"
                };

                if(db.NastavaIB180079.ToList().Exists(x=> x.ProstorijaId == odabranaProstorija.Id && x.Dan == dan && x.Vrijeme == vrijeme))
                {
                    MessageBox.Show("Već postoji nastava na taj dan i pod tom satnicom", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.NastavaIB180079.Add(novaNastava);
                    db.SaveChanges();

                    UcitajNastave();
                    MessageBox.Show("Zapis je dodan", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                

            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(cbDan, err, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(cbVrijeme, err, Kljucevi.ReqiredValue);
        }

        private void frmNastavaIB180079_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
