using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private StudentiUvjerenjaIB180079 odabranoUvjerenje;
        DLWMSDbContext db = new DLWMSDbContext();

        public frmIzvjestaji(StudentiUvjerenjaIB180079 odabranoUvjerenje)
        {
            InitializeComponent();
            this.odabranoUvjerenje = odabranoUvjerenje;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            var odabraniStudent = db.Studenti.Where(x => x.Id == odabranoUvjerenje.StudentId).First();

            var rpc = new ReportParameterCollection();

            rpc.Add(new ReportParameter("imePrezime", odabraniStudent.ImePrezime));
            rpc.Add(new ReportParameter("indeks", odabraniStudent.Indeks));
            rpc.Add(new ReportParameter("aktivan", odabraniStudent.Aktivan == true ? "AKTIVAN" : "NEAKTIVAN"));

            rpc.Add(new ReportParameter("svrha", odabranoUvjerenje.Svrha));
            rpc.Add(new ReportParameter("vrsta", odabranoUvjerenje.Vrsta));


            var polozeniIspiti = db.PolozeniPredmeti
                .Include(x=> x.Predmet)
                .Where(x => x.StudentId == odabraniStudent.Id)
                .ToList();

            rpc.Add(new ReportParameter("brojIspita", polozeniIspiti.Count().ToString()));
            rpc.Add(new ReportParameter("prosjek", polozeniIspiti.Count() == 0 ? "5" : polozeniIspiti.Average(x => x.Ocjena).ToString()));

            var ispiti = " ";

            for (int i = 0; i < polozeniIspiti.Count(); i++)
            {
                ispiti += $"{polozeniIspiti[i].Predmet.Naziv} ({polozeniIspiti[i].Ocjena}), ";
            }


            rpc.Add(new ReportParameter("ispiti", ispiti));


            reportViewer1.LocalReport.SetParameters(rpc);


            reportViewer1.RefreshReport();
        }

        private void frmIzvjestaji_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
