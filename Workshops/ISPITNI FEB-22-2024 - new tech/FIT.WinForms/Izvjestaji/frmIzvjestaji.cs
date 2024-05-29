using FIT.Data.IspitIB180079;
using FIT.Infrastructure;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private ProstorijeIB180079? odabranaProstorija;
        DLWMSDbContext db = new DLWMSDbContext();

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(ProstorijeIB180079? odabranaProstorija)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            var svaPrisustva = db.PrisustvoIB180079.Include(x=> x.Nastava).ThenInclude(x=> x.Predmet).Include(x=> x.Student) .ToList();


            var tblNastava = new dsPrisustvaIB180079.dsPrisustvaDataTable();
            int brojac = 0;

            for (int i = 0; i < svaPrisustva.Count(); i++)
            {
                if (svaPrisustva[i].Nastava.ProstorijaId == odabranaProstorija.Id)
                {
                    brojac++;

                    var Red = tblNastava.NewdsPrisustvaRow();

                    Red.Rb = brojac.ToString();
                    Red.Predmet = svaPrisustva[i].Nastava.Predmet.ToString();
                    Red.Vrijeme = svaPrisustva[i].Nastava.Vrijeme.ToString();
                    Red.Broj_indeksa = svaPrisustva[i].Student.Indeks;
                    Red.Ime_prezime = svaPrisustva[i].Student.ToString();

                    tblNastava.Rows.Add(Red);

                }
               

            }

            var rds = new ReportDataSource();
            rds.Value = tblNastava;
            rds.Name = "dsPrisustva";

            reportViewer1.LocalReport.DataSources.Add(rds);

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("naziv", odabranaProstorija.Naziv));
            rpc.Add(new ReportParameter("broj", brojac.ToString()));

            reportViewer1.LocalReport.SetParameters(rpc);





            reportViewer1.RefreshReport();
        }
    }
}
