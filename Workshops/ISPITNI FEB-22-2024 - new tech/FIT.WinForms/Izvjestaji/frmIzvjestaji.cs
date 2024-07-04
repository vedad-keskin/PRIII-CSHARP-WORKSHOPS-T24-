using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System.Drawing.Text;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private ProstorijeIB180079? odabranaProstorija;
        DLWMSDbContext db = new DLWMSDbContext();


        public frmIzvjestaji(ProstorijeIB180079? odabranaProstorija)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            var prisustva = db.PrisustvoIB180079
                .Include(x=> x.Student)
                .Include(x=> x.Nastava).ThenInclude(x=> x.Predmet)
                .Where(x => x.Nastava.ProstorijaId == odabranaProstorija.Id)
                .ToList();


            var tblPrisustva = new dsIzvjestajIB180079.dsPrisustvaDataTable(); // RB Predmet 


            for (int i = 0; i < prisustva.Count(); i++)
            {

                var Red = tblPrisustva.NewdsPrisustvaRow();

                Red.Rb = (i + 1).ToString();
                Red.Predmet = prisustva[i].Nastava.Predmet.ToString();
                Red.Vrijeme = prisustva[i].Nastava.Vrijeme;
                Red.BrojIndeksa = prisustva[i].Student.Indeks;
                Red.ImePrezime = $"{prisustva[i].Student.Ime} {prisustva[i].Student.Prezime}";

                tblPrisustva.Rows.Add( Red );


            }

            var rds = new ReportDataSource();

            rds.Value = tblPrisustva;
            rds.Name = "dsPrisustva";

            reportViewer1.LocalReport.DataSources.Add(rds);

            var rpc = new ReportParameterCollection();

            rpc.Add(new ReportParameter("prostorija", odabranaProstorija.Naziv));
            rpc.Add(new ReportParameter("broj", prisustva.Count().ToString()));

            reportViewer1.LocalReport.SetParameters(rpc);


            reportViewer1.RefreshReport();
        }
    }
}
