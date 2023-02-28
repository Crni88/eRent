using eRent.Models;
using eRent.Models.Search_Objects;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace eRent.UI
{
    public partial class frmOpcijeIzvjestaja : Form
    {
        APIService NekretnineService { get; set; } = new APIService("Nekretnine");
        APIService rezervacijeAPIService { get; set; } = new APIService("Rezervacija");
        APIService NekretninaKorisnikService { get; set; } = new APIService("NekretninaKorisnik");

        public frmOpcijeIzvjestaja()
        {
            InitializeComponent();
        }

        private async void btnListaNekretnina_Click(object sender, EventArgs e)
        {

            // Retrieve data from API
            List<NekretninaModel> data = await NekretnineService.Get<List<NekretninaModel>>();

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
            table.AddHeaderCell("Br. Soba");
            table.AddHeaderCell("Namještena");
            table.AddHeaderCell("Br. Kvadrata");


            // add table rows dynamically based on API data
            foreach (NekretninaModel item in data)
            {
                table.AddCell(item.NazivNekretnine);
                table.AddCell(item.Grad);
                table.AddCell(item.Cijena.ToString());
                table.AddCell(item.BrojSoba.ToString());
                table.AddCell(item.Namještena ? "Da" : "Ne");
                table.AddCell(item.Popunjena ? "Ne" : "Da");
                table.AddCell(item.Brojkvadrata.ToString());
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
        }

        private async void btnListaRezervacija_Click(object sender, EventArgs e)
        {
            List<RezervacijaModel> data = await rezervacijeAPIService.Get<List<RezervacijaModel>>();

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
            table.AddHeaderCell("Datum Početka");
            table.AddHeaderCell("Datum kraja");
            table.AddHeaderCell("Mjesečna rezervacija");


            // add table rows dynamically based on API data
            foreach (RezervacijaModel item in data)
            {
                table.AddCell(item.ImePrezime);
                table.AddCell(item.BrojTelefona);
                table.AddCell(item.Nazivnekretnine);
                table.AddCell(item.DatumPocetka.ToString());
                table.AddCell(item.DatumKraja.ToString());
                table.AddCell(item.MjesecnaRezervacija ? "Da" : "Ne");
            }
            Paragraph title = new Paragraph("Broj rezervacija").SetFont(PdfFontFactory.CreateFont("Helvetica-Bold"))
            .SetFontSize(22).SetTextAlignment(TextAlignment.CENTER);
            Paragraph para = new Paragraph("Ukupan broj rezervacija " + data.Count + ".");
            // add the table to the document
            doc.Add(title);
            doc.Add(table);
            doc.Add(para);
            // close the document
            doc.Close();
        }

        private async void btnMjesecniPrihodiUkupno_Click(object sender, EventArgs e)
        {
            List<NekretninaModel> data = await NekretnineService.Get<List<NekretninaModel>>();
            List<NekretninaKorisnikModel> nekretninaKorisnikModels = new List<NekretninaKorisnikModel>();
            foreach (NekretninaModel item in data)
            {
                NekretninaKorisnikSearchObject nekretninaKorisnik = new NekretninaKorisnikSearchObject();
                nekretninaKorisnik.NekretninaId = item.NekretninaId;
                List<NekretninaKorisnikModel> temp = await NekretninaKorisnikService.Get<List<NekretninaKorisnikModel>>(nekretninaKorisnik);
                nekretninaKorisnikModels.AddRange(temp);
            }
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
        }
    }
}
