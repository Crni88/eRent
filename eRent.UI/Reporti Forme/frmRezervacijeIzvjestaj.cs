using eRent.Models;
using ReportDataSource = Microsoft.Reporting.WinForms.ReportDataSource;

namespace eRent.UI.Reporti_Forme
{
    public partial class frmRezervacijeIzvjestaj : Form
    {
        List<RezervacijaModel> _rezervacijaModels { get; set; }
        List<NekretninaModel> _nekretninaModels { get; set; }
        public frmRezervacijeIzvjestaj(List<Models.RezervacijaModel> rezervacijas, List<Models.NekretninaModel> data)
        {
            InitializeComponent();
            this._nekretninaModels = data;
            this._rezervacijaModels = rezervacijas;
        }

        private void frmRezervacijeIzvjestaj_Load(object sender, EventArgs e)
        {
            DataSet1.BrojRezervacijaDataTable tblRezervacije = new DataSet1.BrojRezervacijaDataTable();
            foreach (var rezervacija in _rezervacijaModels)
            {
                var red = tblRezervacije.NewBrojRezervacijaRow();
                red.Imeiprezime = rezervacija.ImePrezime;
                red.Brojtelefona = rezervacija.BrojTelefona;
                red.NazivNekretnine = rezervacija.Nazivnekretnine;
                DateTime datumPocetka = (DateTime)rezervacija.DatumPocetka;
                string formattedDatumPocetka = datumPocetka.ToString("dd-MM-yyyy");
                red.DatumPocetka = formattedDatumPocetka;
                DateTime datumKraja = (DateTime)rezervacija.DatumKraja;
                string formatteddatumKraja = datumKraja.ToString("dd-MM-yyyy");
                red.DatumKraja = formatteddatumKraja;
                red.MjesecnaRezervacija = rezervacija.MjesecnaRezervacija ? "Da" : "Ne";
                red.Cijena = rezervacija.Nekretnina.Cijena.ToString() + " KM";
                TimeSpan duration = datumKraja - datumPocetka;
                red.OstvareniIznos = (duration.Days * rezervacija.Nekretnina.Cijena).ToString() + " KM";
                tblRezervacije.Rows.Add(red);
            }
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1"; // This should match the name of the data source in the .rdlc file
            rds.Value = tblRezervacije;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "eRent.UI.reporti.Report2.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
