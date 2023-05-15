using eRent.Models;
using eRent.Models.Search_Objects;
using eRent.UI.Helpers;
using eRent.UI.Reporti_Forme;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Globalization;

namespace eRent.UI
{
    public partial class frmOpcijeIzvjestaja : Form
    {

        APIService rezervacijeAPIService { get; set; } = new APIService("Rezervacija");
        APIService NekretnineService { get; set; } = new APIService("Nekretnine");
        APIService NekretninaKorisnikService { get; set; } = new APIService("NekretninaKorisnik");

        List<NekretninaModel> data = new List<NekretninaModel>();

        public frmOpcijeIzvjestaja()
        {
            InitializeComponent();
        }

        private void btnListaNekretninaReportGenerate(object sender, EventArgs e)
        {
            frmBrojNekretninaIzvjestaj frmBrojNekretninaIzvjestaj = new frmBrojNekretninaIzvjestaj(data);
            frmBrojNekretninaIzvjestaj.ShowDialog();
        }

        private void showMessage()
        {
            AutoClosingMessageBox.Show("Vaš novi report se nalazi na Desktopu!", "Report generisan!", 3000);
        }

        private async void btnListaRezervacija_Click(object sender, EventArgs e)
        {
            List<RezervacijaModel> rezervacijas = await loadRezervacije();
            // create a new PDF document
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\listaRezervacija.pdf"));
            // create a new document instance
            Document doc = new Document(pdfDoc);
            // create a new table with 1 column
            Table table = new Table(6);

            // add header row with column names
            table.AddHeaderCell("Ime i prezime");
            table.AddHeaderCell("Broj telefona");
            table.AddHeaderCell("Naziv Nekretnine");
            table.AddHeaderCell("Datum Pocetka");
            table.AddHeaderCell("Datum kraja");
            table.AddHeaderCell("Mjesečna rezervacija");


            // add table rows dynamically based on API data
            foreach (RezervacijaModel item in rezervacijas)
            {
                DateTime datumPocetka = DateTime.ParseExact(item.DatumPocetka.ToString(), "d. M. yyyy. HH:mm:ss", CultureInfo.InvariantCulture);
                string formattedDate = datumPocetka.ToString("d. M. yyyy");
                DateTime datumKraja = DateTime.ParseExact(item.DatumKraja.ToString(), "d. M. yyyy. HH:mm:ss", CultureInfo.InvariantCulture);
                string formattedDate1 = datumPocetka.ToString("d. M. yyyy");

                table.AddCell(item.ImePrezime);
                table.AddCell(item.BrojTelefona);
                table.AddCell(item.Nazivnekretnine);
                table.AddCell(formattedDate);
                table.AddCell(formattedDate1);
                table.AddCell(item.MjesecnaRezervacija ? "Da" : "Ne");
            }
            Paragraph title = new Paragraph("Broj rezervacija").SetFont(PdfFontFactory.CreateFont("Helvetica-Bold"))
            .SetFontSize(22).SetTextAlignment(TextAlignment.CENTER);
            Paragraph para = new Paragraph("Ukupan broj rezervacija " + rezervacijas.Count + ".");
            // add the table to the document
            doc.Add(title);
            doc.Add(table);
            doc.Add(para);
            // close the document
            doc.Close();
            showMessage();
            this.Close();
        }

        private async Task<List<RezervacijaModel>> loadRezervacije()
        {
            RezervacijaSearchObject rezervacijaSearchObject = new RezervacijaSearchObject();
            rezervacijaSearchObject.NekretninaId = data.Where(x => x.NazivNekretnine == cbListaNekretnina.Text).Select(x => x.NekretninaId).FirstOrDefault();
            rezervacijaSearchObject.DatumPocetka = dtpFrom.Value;
            rezervacijaSearchObject.DatumKraja = dtpUntil.Value;
            List<RezervacijaModel> rezervacijas = await rezervacijeAPIService.Get<List<RezervacijaModel>>(rezervacijaSearchObject);
            return rezervacijas;
        }

        private async void btnMjesecniPrihodiUkupno_Click(object sender, EventArgs e)
        {
            List<NekretninaKorisnikModel> nekretninaKorisnikModels = await getMjesecniPrihodiUkupno();
            frmSingleReport frmSingleReport = new frmSingleReport(nekretninaKorisnikModels, data);
            frmSingleReport.ShowDialog();
        }

        private async Task<List<NekretninaKorisnikModel>> getMjesecniPrihodiUkupno()
        {
            List<NekretninaKorisnikModel> nekretninaKorisnikModels = new List<NekretninaKorisnikModel>();
            foreach (NekretninaModel item in data)
            {
                NekretninaKorisnikSearchObject nekretninaKorisnik = new NekretninaKorisnikSearchObject();
                nekretninaKorisnik.NekretninaId = item.NekretninaId;
                List<NekretninaKorisnikModel> temp = await NekretninaKorisnikService.Get<List<NekretninaKorisnikModel>>(nekretninaKorisnik);
                nekretninaKorisnikModels.AddRange(temp);
            }

            return nekretninaKorisnikModels;
        }

        private async void frmOpcijeIzvjestaja_Load(object sender, EventArgs e)
        {
            NekretninaSearchObject nekretninaSearchObject = new NekretninaSearchObject();
            nekretninaSearchObject.IsActive = true;
            List<NekretninaModel> nekretninas = await NekretnineService.Get<List<NekretninaModel>>(nekretninaSearchObject);
            data = nekretninas;
            List<String> nekretnineNames = new List<string>();
            foreach (var nekretnina in nekretninas)
            {
                nekretnineNames.Add(nekretnina.NazivNekretnine);
            }
            cbListaNekretnina.DataSource = nekretnineNames;
        }



        private async void btnMjesecniPrihodiUkupnoPDF_Click(object sender, EventArgs e)
        {
            List<NekretninaKorisnikModel> nekretninaKorisnikModels = await getMjesecniPrihodiUkupno();

            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ukupanPrihod.pdf"));

            // create a new document instance
            Document doc = new Document(pdfDoc);

            // create a new table with 1 column
            Table table = new Table(4);

            // add header row with column names
            table.AddHeaderCell("Naziv Nekretnine");
            table.AddHeaderCell("Cijena");
            table.AddHeaderCell("Br. Korisnika");
            table.AddHeaderCell("Ukupan prihod");

            int ukupniPrihodi = 0;
            // add table rows dynamically based on API data
            foreach (NekretninaModel nekretnina in data)
            {
                table.AddCell(nekretnina.NazivNekretnine);
                table.AddCell(nekretnina.Cijena.ToString());
                table.AddCell(nekretninaKorisnikModels.Where(x => x.Nekretnina == nekretnina.NekretninaId).Count().ToString());
                int brojKorisnikaUNekretnini = nekretninaKorisnikModels.Where(x => x.Nekretnina == nekretnina.NekretninaId).Count();
                ukupniPrihodi += nekretnina.Cijena * brojKorisnikaUNekretnini;
                table.AddCell((nekretnina.Cijena * brojKorisnikaUNekretnini).ToString());
            }

            Paragraph title = new Paragraph("Ukupni profit")
                .SetFont(PdfFontFactory
                .CreateFont("Helvetica-Bold"))
                .SetFontSize(22)
                .SetTextAlignment(TextAlignment.CENTER);
            Paragraph para = new Paragraph("Broj nekretnina " + data.Count + ".");
            Paragraph ukupniPrihod = new Paragraph("Ukupni prihodi " + ukupniPrihodi.ToString() + ".");
            // add the table to the document
            doc.Add(title);
            doc.Add(table);
            doc.Add(para);
            doc.Add(ukupniPrihod);
            // close the document
            doc.Close();
            showMessage();
            this.Close();
        }

        private async void btnRezervacijeIzvjestaj_Click(object sender, EventArgs e)
        {
            List<RezervacijaModel> rezervacijas = await loadRezervacije();
            frmRezervacijeIzvjestaj frmRezervacije = new frmRezervacijeIzvjestaj(rezervacijas, data);
            frmRezervacije.Show();
        }

        private void btnListaNekretninaPDF_Click(object sender, EventArgs e)
        {
            // create a new PDF document
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\listaNekretnina.pdf"));

            // create a new document instance
            Document doc = new Document(pdfDoc);

            // create a new table with 1 column
            Table table = new Table(6);

            // add header row with column names
            table.AddHeaderCell("Naziv Nekretnine");
            table.AddHeaderCell("Grad");
            table.AddHeaderCell("Cijena");
            table.AddHeaderCell("Broj Soba");
            table.AddHeaderCell("Namještena");
            table.AddHeaderCell("Broj Kvadrata");


            // add table rows dynamically based on API data
            foreach (NekretninaModel item in data)
            {
                table.AddCell(item.NazivNekretnine);
                table.AddCell(item.Grad);
                table.AddCell(item.Cijena.ToString());
                table.AddCell(item.BrojSoba.ToString());
                table.AddCell(item.Namještena ? "Da" : "Ne");
                table.AddCell(item.Brojkvadrata.ToString());
                //table.AddCell(item.Popunjena ? "Ne" : "Da");
            }

            Paragraph title = new Paragraph("Broj nekretnina")
                .SetFont(PdfFontFactory
                .CreateFont("Helvetica-Bold"))
                .SetFontSize(22)
                .SetTextAlignment(TextAlignment.CENTER);
            Paragraph para = new Paragraph("Broj nekretnina " + data.Count + ".");
            // add the table to the document
            doc.Add(title);
            doc.Add(table);
            doc.Add(para);
            // close the document
            doc.Close();
            showMessage();
            this.Close();
        }
    }
}
