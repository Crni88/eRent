using eRent.Models;
using ReportDataSource = Microsoft.Reporting.WinForms.ReportDataSource;

namespace eRent.UI.Reporti_Forme
{
    public partial class frmBrojNekretninaIzvjestaj : Form
    {

        List<NekretninaModel> _nekretninaModels { get; set; }
        public frmBrojNekretninaIzvjestaj(List<Models.NekretninaModel> data)
        {
            InitializeComponent();
            _nekretninaModels = data;
        }

        private void frmBrojNekretninaIzvjestaj_Load(object sender, EventArgs e)
        {
            DataSet1.BrojNekretninaDataTable tblNekretnine = new DataSet1.BrojNekretninaDataTable();
            foreach (var nekretnina in _nekretninaModels)
            {
                var red = tblNekretnine.NewBrojNekretninaRow();
                red.NazivNekretnine = nekretnina.NazivNekretnine;
                red.Grad = nekretnina.Grad;
                red.Cijena = nekretnina.Cijena.ToString();
                red.BrojSoba = nekretnina.BrojSoba.ToString();
                red.Namjestena = nekretnina.Namještena ? "Da" : "Ne";
                red.BrojKvadrata = nekretnina.Brojkvadrata.ToString();
                tblNekretnine.Rows.Add(red);
            }
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1"; // This should match the name of the data source in the .rdlc file
            rds.Value = tblNekretnine;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "eRent.UI.reporti.Report3.rdlc";

            // Refresh the report viewer control
            reportViewer1.RefreshReport();
        }
    }
}
