using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Requests.NekretninaKorisnik;
using eRent.Models.Requests.Rezervacija;
using eRent.Models.Search_Objects;
using eRent.UI.Helpers;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace eRent.UI
{
    public partial class frmSveRezervacije : Form
    {
        APIService rezervacijeAPIService { get; set; } = new APIService("Rezervacija");
        public APIService NekretninaKorisnikService { get; set; } = new APIService("NekretninaKorisnik");
        APIService ugovorAPIService { get; set; } = new APIService("Ugovor");
        string _username;
        public frmSveRezervacije(string _username)
        {
            InitializeComponent();
            dgvSveRezervacije.AutoGenerateColumns = false;
            this._username = _username;
        }

        private async void btnUcitaj_Click(object sender, EventArgs e)
        {
            // await loadData();
        }

        private async Task loadData(RezervacijaSearchObject rezervacijaSearchObject = null)
        {
            if (cbStatus.Text == "Odobrena")
            {
                dgvSveRezervacije.Columns[6].Visible = false;
                dgvSveRezervacije.Columns[7].Visible = false;
            }
            else if (cbStatus.Text == "Odbijena")
            {
                dgvSveRezervacije.Columns[6].Visible = false;
                dgvSveRezervacije.Columns[7].Visible = false;
            }
            else if (cbStatus.Text == "Sve")
            {
                dgvSveRezervacije.Columns[6].Visible = true;
                dgvSveRezervacije.Columns[7].Visible = true;
            }
            var list = await rezervacijeAPIService.Get<List<RezervacijaModel>>(rezervacijaSearchObject);
            dgvSveRezervacije.DataSource = list;
        }

        private async Task odobriRezervaiju()
        {
            cbStatus.Text = "Odobrena";
            RezervacijaSearchObject rezervacijaSearchObject = new RezervacijaSearchObject();
            rezervacijaSearchObject.Otkazana = false;
            rezervacijaSearchObject.Odobrena = true;
            rezervacijaSearchObject.Odbijena = false;
            var list = await rezervacijeAPIService.Get<List<RezervacijaModel>>(rezervacijaSearchObject);
            dgvSveRezervacije.DataSource = list;
        }

        private async Task odbijRezervaciju()
        {
            cbStatus.Text = "Odbijena";
            RezervacijaSearchObject rezervacijaSearchObject = new RezervacijaSearchObject();
            rezervacijaSearchObject.Otkazana = false;
            rezervacijaSearchObject.Odobrena = false;
            rezervacijaSearchObject.Odbijena = true;
            var list = await rezervacijeAPIService.Get<List<RezervacijaModel>>(rezervacijaSearchObject);
            dgvSveRezervacije.DataSource = list;
        }

        private void frmSveRezervacije_Load(object sender, EventArgs e)
        {
            //await  loadData();
            List<String> status = new List<string>();
            status.Add("Sve");
            status.Add("Odobrena");
            status.Add("Odbijena");
            //status.Add("Otkazana");
            cbStatus.DataSource = status;
        }

        private async void dgvSveRezervacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                //Odobri rezervaciju
                try
                {
                    RezervacijaModel taskModel = (RezervacijaModel)dgvSveRezervacije.SelectedRows[0].DataBoundItem;
                    if ((bool)taskModel.Odobrena)
                    {
                        MessageBox.Show("Rezervacija je već odobrena!");
                    }
                    else
                    {
                        RezervacijaUpdateRequest rezervacijaUpdateRequest = new RezervacijaUpdateRequest();
                        rezervacijaUpdateRequest.RezervacijaId = taskModel.RezervacijaId;
                        rezervacijaUpdateRequest.Odobrena = true;
                        rezervacijaUpdateRequest.Otkazana = false;
                        rezervacijaUpdateRequest.Odbijena = false;
                        var list = await rezervacijeAPIService.Put<RezervacijaUpdateRequest>(taskModel.RezervacijaId, rezervacijaUpdateRequest);

                        string[] parts = taskModel.ImePrezime.Split(' ');

                        NekretninaKorisnikModel nekretninaKorisnikModel = new NekretninaKorisnikModel();
                        nekretninaKorisnikModel.Nekretnina = taskModel.NekretninaId;
                        nekretninaKorisnikModel.ImeKorisnika = parts[0];
                        nekretninaKorisnikModel.PrezimeKorisnika = parts[1];
                        nekretninaKorisnikModel.BrojTelefona = taskModel.BrojTelefona;
                        nekretninaKorisnikModel.DatumUseljenja = taskModel.DatumPocetka;
                        nekretninaKorisnikModel.DatumIseljenja = taskModel.DatumKraja;
                        nekretninaKorisnikModel.IsActive = true;
                        nekretninaKorisnikModel.Slika = "";
                        var postNekretnina = await NekretninaKorisnikService.Post<NekretninaKorisnikInsertRequest>(nekretninaKorisnikModel);
                        generisiUgovor(taskModel);
                        await createUgovor(taskModel);
                        AutoClosingMessageBox.Show("Rezervacija odobrena", "Rezervacija uspjesno odobrena.", 3000);
                        //await loadData();
                        await odobriRezervaiju();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.ColumnIndex == 7)
            {
                //Odbij rezervaciju
                try
                {
                    RezervacijaModel taskModel = (RezervacijaModel)dgvSveRezervacije.SelectedRows[0].DataBoundItem;
                    RezervacijaUpdateRequest rezervacijaUpdateRequest = new RezervacijaUpdateRequest();
                    rezervacijaUpdateRequest.RezervacijaId = taskModel.RezervacijaId;
                    rezervacijaUpdateRequest.Odobrena = false;
                    rezervacijaUpdateRequest.Otkazana = false;
                    rezervacijaUpdateRequest.Odbijena = true;
                    var list = await rezervacijeAPIService.Put<RezervacijaUpdateRequest>(taskModel.RezervacijaId, rezervacijaUpdateRequest);
                    await odbijRezervaciju();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Ugovor generation
        private async Task<UgovorUpsertRequest> createUgovor(RezervacijaModel rezervacija)
        {
            var ugovorUpsert = new UgovorUpsertRequest();
            ugovorUpsert.PodnosiocUgovoraId = 2;
            ugovorUpsert.DatumSklapanjaUgovora = rezervacija.DatumPocetka;
            ugovorUpsert.DatumIstekaUgovora = rezervacija.DatumKraja;
            ugovorUpsert.PodnosiocUgovora = "Admin Admin";
            ugovorUpsert.UgovornaStranka = rezervacija.ImePrezime;
            ugovorUpsert.NekretninaId = rezervacija.NekretninaId;

            var res = await ugovorAPIService.Post<UgovorUpsertRequest>(ugovorUpsert);
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
                "Ovaj ugovor o najmu stana (\"Ugovor\") zaključen je između (\"Stanodavac\") __________");
            //Paragraph stanodavac = new Paragraph(_nekretnina.Username);
            //Paragraph stanar = new Paragraph(_stanar);
            //Paragraph i = new Paragraph("i");
            Paragraph finalParagraph = new Paragraph(" (\"Stanar\") __________ dana __________.\n\n" +
                "1. Predmet ugovora: Stanodavac iznajmljuje Stanaru stan __________ (\"Stan\") na period od __________ počevši od __________.\n\n" +
                "2. Visina najamnine: Stanar će platiti Stanodavcu najamninu u iznosu od __________ KM po mjesecu. Najamnina će se plaćati __________.\n\n" +
                "3. Depozit: Stanar će uplatiti depozit u iznosu od __________ KM Stanodavcu kao sigurnost za ispunjenje obaveza iz ovog Ugovora. Depozit će se vratiti Stanaru nakon isteka ugovornog perioda, pod uvjetom da Stanar ispuni sve svoje obaveze prema ovom Ugovoru. Stanodavac ima pravo zadržati dio ili cijeli iznos depozita ako Stanar ne ispuni svoje obaveze prema ovom Ugovoru.\n\n" +
                "4. Troškovi: Stanar će snositi sve troškove vezane za korištenje stana, uključujući troškove struje, vode, plina, grijanja, telefona i interneta.\n\n" +
                "5. Održavanje stana: Stanar će održavati Stan u dobrom stanju i čistiti ga redovito. Stanodavac će obavljati sve popravke i održavanje koji su potrebni zbog redovnog habanja i korištenja stana. Ako su potrebni popravci zbog Stanarovog nemara ili nepažnje, Stanar će snositi troškove popravka.\n\n" +
                "6. Kućni red: Stanar će se pridržavati kućnog reda u zgradi i u susjedstvu. Stanodavac ima pravo otkazati ovaj Ugovor ako Stanar ne poštuje kućni red ili ako\n\n");
            document.Add(firstParagraph);
            //document.Add(stanodavac);
            //document.Add(i);
            //document.Add(stanar);
            document.Add(finalParagraph);

            // Close the document
            document.Close();
        }


        //Go back
        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmNekretninaList(_username);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private async void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RezervacijaSearchObject rezervacijaSearchObject = new RezervacijaSearchObject();
            string selectedStatus = cbStatus.Text;

            switch (selectedStatus)
            {
                case "Odobrena":
                    rezervacijaSearchObject.Otkazana = false;
                    rezervacijaSearchObject.Odobrena = true;
                    rezervacijaSearchObject.Odbijena = null;
                    break;

                case "Odbijena":
                    rezervacijaSearchObject.Otkazana = false;
                    rezervacijaSearchObject.Odobrena = null;
                    rezervacijaSearchObject.Odbijena = true;
                    break;

                case "Sve":
                    rezervacijaSearchObject.Otkazana = false;
                    rezervacijaSearchObject.Odobrena = null;
                    rezervacijaSearchObject.Odbijena = null;
                    break;

                default:
                    // Handle unrecognized status here (optional)
                    break;
            }
            await loadData(rezervacijaSearchObject);
        }
    }
}
