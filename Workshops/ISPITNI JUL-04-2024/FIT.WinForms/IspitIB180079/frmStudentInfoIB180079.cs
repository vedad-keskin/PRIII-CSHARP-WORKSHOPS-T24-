using FIT.Data;
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
    public partial class frmStudentInfoIB180079 : Form
    {
        private Student odabraniStudent;


        public frmStudentInfoIB180079(Student odabraniStudent)
        {
            InitializeComponent();
            this.odabraniStudent = odabraniStudent;
        }

        private void frmStudentInfoIB180079_Load(object sender, EventArgs e)
        {
            UcitajInfo();
        }

        private void UcitajInfo()
        {
            pbSlika.Image = odabraniStudent.Slika.ToImage();
            //pbSlika.Image = Ekstenzije.ToImage(odabraniStudent.Slika);

            lblImePrezime.Text = odabraniStudent.ImePrezime;
            lblProsjek.Text = $"Prosjek: {odabraniStudent.Prosjek}";
            this.Text = odabraniStudent.Indeks;


        }
    }
}
