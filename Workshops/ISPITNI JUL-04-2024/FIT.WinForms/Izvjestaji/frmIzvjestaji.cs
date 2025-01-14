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

            var rpc = new ReportParameterCollection();

            rpc.Add(new ReportParameter("vrsta", odabranoUvjerenje.Vrsta));

            rpc.Add(new ReportParameter("student", $"{odabranoUvjerenje.Student.ImePrezime} ({odabranoUvjerenje.Student.Indeks})"));


            rpc.Add(new ReportParameter("svrha", odabranoUvjerenje.Svrha));


            rpc.Add(new ReportParameter("aktivan", odabranoUvjerenje.Student.Aktivan == true ? "AKTIVAN" : "NEAKTIVAN"  ));

            var polozeniPredmetiStudenta = db.PolozeniPredmeti
                .Include(x=> x.Predmet)
                .Where(x => x.StudentId == odabranoUvjerenje.StudentId)
                .ToList();


            
            rpc.Add(new ReportParameter("broj", polozeniPredmetiStudenta.Count().ToString()));

            var info = "";
            for (int i = 0; i < polozeniPredmetiStudenta.Count(); i++)
            {
                info += $"{polozeniPredmetiStudenta[i].Predmet.Naziv} ({polozeniPredmetiStudenta[i].Ocjena}) ";
            }


            rpc.Add(new ReportParameter("predmetiInfo", string.IsNullOrEmpty(info) ? "/" : info   ));


            rpc.Add(new ReportParameter("prosjek", odabranoUvjerenje.Student.Prosjek.ToString()));

            rpc.Add(new ReportParameter("datum", odabranoUvjerenje.Vrijeme.ToString()  ));


            reportViewer1.LocalReport.SetParameters(rpc);

            reportViewer1.RefreshReport();
        }
    }
}
