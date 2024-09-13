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
    public partial class frmNovoUvjerenjeIB180079 : Form
    {
        private Student odabraniStudent;
        DLWMSDbContext db = new DLWMSDbContext();

        public frmNovoUvjerenjeIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNovoUvjerenjeIB180079_Load(object sender, EventArgs e)
        {
            cbVrsta.SelectedIndex = 0;
        }

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Validiraj())
            {
                var vrsta = cbVrsta.SelectedItem.ToString();
                var svrha = txtSvrha.Text;
                var uplatnica = Ekstenzije.ToByteArray(pbUplatnica.Image);


                var novoUvjerenje = new StudentiUvjerenjaIB180079()
                {
                    StudentId = odabraniStudent.Id,
                    Vrijeme = DateTime.Now,
                    Vrsta = vrsta,
                    Svrha = svrha,
                    Uplatnica = uplatnica,
                    Printano = false


                };

                db.StudentiUvjerenjaIB180079.Add(novoUvjerenje);
                db.SaveChanges();

                DialogResult = DialogResult.OK;


            }


        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(pbUplatnica, err, Kljucevi.ReqiredValue) && Validator.ProvjeriUnos(txtSvrha, err, Kljucevi.ReqiredValue);
        }
    }
}
