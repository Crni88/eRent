using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Requests.Rezervacija;
using eRent.Models.Search_Objects;
using eRent.UI.Helpers;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace eRent.UI
{
    public partial class frmRezervacije : Form
    {
        NekretninaModel _nekretnina { get; set; }

        APIService rezervacijeAPIService { get; set; } = new APIService("Rezervacija");
        APIService ugovorAPIService { get; set; } = new APIService("Ugovor");
        public frmRezervacije(NekretninaModel nekretnina)
        {
            InitializeComponent();
            dgvRezervacije.AutoGenerateColumns = false;
            this._nekretnina = nekretnina;
        }

        private async void btnLoadRezervacije_Click(object sender, EventArgs e)
        {
            RezervacijaSearchObject rezervacijaSearchObject = new RezervacijaSearchObject();
            rezervacijaSearchObject.NekretninaId = _nekretnina.NekretninaId;
            rezervacijaSearchObject.Odobrena = true;
            var list = await rezervacijeAPIService.Get<List<RezervacijaModel>>(rezervacijaSearchObject);
            dgvRezervacije.DataSource = list;
        }

        private void showMessage()
        {
            AutoClosingMessageBox.Show("Vaš novi ugovor se nalazi na Desktopu!", "Rezervacija odobrena!", 3000);
        }

        private void dgvRezervacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var rezervacija = dgvRezervacije.SelectedRows[0].DataBoundItem as RezervacijaModel;
                if (rezervacija != null)
                {
                    var rezervacijaRes = updateRezervacija(rezervacija);
                    var ugovorRes = createUgovor(rezervacija);
                    generisiUgovor(rezervacija);
                    if (rezervacijaRes != null && ugovorRes != null)
                    {
                        showMessage();
                        this.Close();
                    }
                }
            }
        }

        private async Task<UgovorUpsertRequest> createUgovor(RezervacijaModel rezervacija)
        {
            var ugovorUpsert = new UgovorUpsertRequest();
            ugovorUpsert.PodnosiocUgovoraId = _nekretnina.KorisnikNekretnina;
            ugovorUpsert.DatumSklapanjaUgovora = rezervacija.DatumPocetka;
            ugovorUpsert.DatumIstekaUgovora = rezervacija.DatumKraja;
            ugovorUpsert.PodnosiocUgovora = _nekretnina.Username;
            ugovorUpsert.UgovornaStranka = rezervacija.ImePrezime;
            ugovorUpsert.NekretninaId = rezervacija.NekretninaId;
            var res = await ugovorAPIService.Post<UgovorUpsertRequest>(ugovorUpsert);
            return res;
        }

        private async Task<RezervacijaUpdateRequest> updateRezervacija(RezervacijaModel? rezervacija)
        {
            var rezervacijaUpdateRequest = new RezervacijaUpdateRequest();
            rezervacijaUpdateRequest.RezervacijaId = rezervacija.RezervacijaId;
            rezervacijaUpdateRequest.Odobrena = true;
            var res = await rezervacijeAPIService.Put<RezervacijaUpdateRequest>(rezervacija.RezervacijaId, rezervacijaUpdateRequest);
            return res;
        }

        private void generisiUgovor(RezervacijaModel rezervacija)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ugovor.pdf"));
            string imekorisnika = rezervacija.ImePrezime;
            // Create a new document object
            Document document = new Document(pdfDoc);

            // Add content to the document

            string _stanar = rezervacija.ImePrezime;
            Paragraph firstParagraph = new Paragraph("UGOVOR O NAJMU STANA\n\n" +
                "Ovaj ugovor o najmu stana (\"Ugovor\") zaključen je između (\"Stanodavac\")");
            Paragraph stanodavac = new Paragraph(_nekretnina.Username);
            Paragraph stanar = new Paragraph(_stanar);
            Paragraph i = new Paragraph("i");
            Paragraph finalParagraph = new Paragraph(" (\"Stanar\") dana [Datum zaključenja ugovora].\n\n" +
                "1. Predmet ugovora: Stanodavac iznajmljuje Stanaru stan [Adresa stana] (\"Stan\") na period od [Broj godina/mjeseci/dana] počevši od [Datum početka najma].\n\n" +
                "2. Visina najamnine: Stanar će platiti Stanodavcu najamninu u iznosu od [Iznos najamnine] KM po mjesecu. Najamnina će se plaćati [Opis vremena plaćanja najamnine - npr. do 5. u mjesecu].\n\n" +
                "3. Depozit: Stanar će uplatiti depozit u iznosu od [Iznos depozita] KM Stanodavcu kao sigurnost za ispunjenje obaveza iz ovog Ugovora. Depozit će se vratiti Stanaru nakon isteka ugovornog perioda, pod uvjetom da Stanar ispuni sve svoje obaveze prema ovom Ugovoru. Stanodavac ima pravo zadržati dio ili cijeli iznos depozita ako Stanar ne ispuni svoje obaveze prema ovom Ugovoru.\n\n" +
                "4. Troškovi: Stanar će snositi sve troškove vezane za korištenje stana, uključujući troškove struje, vode, plina, grijanja, telefona i interneta.\n\n" +
                "5. Održavanje stana: Stanar će održavati Stan u dobrom stanju i čistiti ga redovito. Stanodavac će obavljati sve popravke i održavanje koji su potrebni zbog redovnog habanja i korištenja stana. Ako su potrebni popravci zbog Stanarovog nemara ili nepažnje, Stanar će snositi troškove popravka.\n\n" +
                "6. Kućni red: Stanar će se pridržavati kućnog reda u zgradi i u susjedstvu. Stanodavac ima pravo otkazati ovaj Ugovor ako Stanar ne poštuje kućni red ili ako\n\n");
            document.Add(firstParagraph);
            document.Add(stanodavac);
            document.Add(i);
            document.Add(stanar);
            document.Add(finalParagraph);

            // Close the document
            document.Close();
        }
    }
}
