using eRent.Models;
using ReportDataSource = Microsoft.Reporting.WinForms.ReportDataSource;

namespace eRent.UI
{
    public partial class frmSingleReport : Form
    {
        List<NekretninaKorisnikModel> nekretninaKorisnikModels1 { get; set; }
        List<NekretninaModel> nekretninaModels1 { get; set; }
        public frmSingleReport(List<Models.NekretninaKorisnikModel> nekretninaKorisnikModels, List<NekretninaModel> data)
        {
            InitializeComponent();
            nekretninaKorisnikModels1 = nekretninaKorisnikModels;
            nekretninaModels1 = data;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        private void frmTestReporta_Load(object sender, EventArgs e)
        {
            DataSet1.NekretnineDataTable tblPolozeni = new DataSet1.NekretnineDataTable();
            int ukupanprihod = 0;
            foreach (var _nekretninaModels1 in nekretninaModels1)
            {
                var red = tblPolozeni.NewNekretnineRow();
                red.NazivNekretnine = _nekretninaModels1.NazivNekretnine;
                red.Cijena = _nekretninaModels1.Cijena;
                int brojKorisnika = nekretninaKorisnikModels1.Count(x => x.Nekretnina == _nekretninaModels1.NekretninaId);
                red.BrojKorisnika = nekretninaKorisnikModels1.Count(x => x.Nekretnina == _nekretninaModels1.NekretninaId).ToString();
                 ukupanprihod+= (brojKorisnika * _nekretninaModels1.Cijena);
                red.UkupanPrihod = ukupanprihod.ToString(); 
                tblPolozeni.Rows.Add(red);
            }
            
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsNekretnine"; // This should match the name of the data source in the .rdlc file
            rds.Value = tblPolozeni;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "eRent.UI.reporti.Report1.rdlc";

            // Refresh the report viewer control
            reportViewer1.RefreshReport();
            //reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //reportViewer1.LocalReport.ReportEmbeddedResource = "eRent.UI.reporti.Report1.rdlc";
            //reportViewer1.RefreshReport();
        }
    }
}
