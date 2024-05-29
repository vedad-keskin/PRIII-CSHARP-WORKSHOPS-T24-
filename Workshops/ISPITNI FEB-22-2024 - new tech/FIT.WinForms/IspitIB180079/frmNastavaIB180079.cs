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
        private ProstorijeIB180079 odabranaProstorija; // AMF1
        DLWMSDbContext db = new DLWMSDbContext();
        List<NastavaIB180079> nastave;

        public frmNastavaIB180079(ProstorijeIB180079 odabranaProstorija)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
        }

        private void frmNastavaIB180079_Load(object sender, EventArgs e)
        {
            dgvNastava.AutoGenerateColumns = false;

            cbPredmet.DataSource = db.Predmeti.ToList();

            lblNastava.Text = $"{odabranaProstorija.Naziv} - {odabranaProstorija.Oznaka}";

            UcitajNastave();
        }

        private void UcitajNastave()
        {
            nastave = db.NastavaIB180079
                .Include("Predmet").Include(x => x.Prostorija)
                .Where(x => x.ProstorijaId == odabranaProstorija.Id)
                .ToList();


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
                var predmet = cbPredmet.SelectedItem as PredmetiIB180079;

                // pohrana = izraz ? true : false ;  
                var dan = cbDan.SelectedItem.ToString();
                var vrijeme = cbVrijeme.SelectedItem.ToString();


                if (nastave.Exists(x=> x.PredmetId == predmet.Id && x.Dan == dan && x.Vrijeme == vrijeme)) 
                {
                    MessageBox.Show("Nije moguce dodati nastavu jer ona vec postoji","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    var novaNastava = new NastavaIB180079()
                    {
                        Dan = dan,
                        Vrijeme = vrijeme,
                        PredmetId = predmet.Id,
                        ProstorijaId = odabranaProstorija.Id,
                        Oznaka = $"{predmet.Naziv} :: {dan} :: {vrijeme}"

                    };


                    db.NastavaIB180079.Add(novaNastava);

                }

                db.SaveChanges();

                UcitajNastave();



            }



        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(cbDan, err, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(cbVrijeme, err, Kljucevi.ReqiredValue);
        }

        private void frmNastavaIB180079_FormClosed(object sender, FormClosedEventArgs e)
        {
                DialogResult = DialogResult.OK;

        }
    }
}
