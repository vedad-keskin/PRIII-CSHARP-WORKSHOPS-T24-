using FIT.Data.IspitIB0000000;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<GradIB000000> gradovi;

        public frmIzvjestaji(List<GradIB000000> gradovi)
        {
            InitializeComponent();
            this.gradovi = gradovi;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var dsTable = new dsGradovi.dsGradoviDataTable();
            for (int i = 0; i < gradovi.Count(); i++) 
            {
                var Red = dsTable.NewdsGradoviRow();
                Red.Rb = $"{i+1}.";
                Red.Naziv = gradovi[i].Naziv.ToString();
                Red.Aktivan = gradovi[i].Aktivan == true ? "Da" : "Ne";

                dsTable.Rows.Add(Red);  
            }

            var rds = new ReportDataSource();
            rds.Value = dsTable;
            rds.Name = "dsGradovi";
            reportViewer1.LocalReport.DataSources.Add(rds);

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("drzava", gradovi[0].Drzava.ToString().ToUpper()));
            reportViewer1.LocalReport.SetParameters(rpc);


            reportViewer1.RefreshReport();
        }
    }
}
