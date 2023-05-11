using eRent.Models;
using eRent.Models.Requests.Korisnik;
using eRent.Models.Search_Objects;
using eRent.UI.Helpers;

namespace eRent.UI
{
    public partial class frmSviKorisnici : Form
    {
        private readonly APIService korisnikService = new APIService("Korisnici");

        public frmSviKorisnici()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private async void btnUcitajKorisnike_Click(object sender, EventArgs e)
        {
            await loadKorisnike();
        }

        private async Task loadKorisnike()
        {
            KorisnikSearchObject korisnikSearchObject = new KorisnikSearchObject();
            korisnikSearchObject.IsActive = true;
            List<KorisnikModel> korisnikModels = await korisnikService.Get<List<KorisnikModel>>(korisnikSearchObject);
            dgvKorisnici.DataSource = korisnikModels;
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            frmAddNovogKorisnika frmAddNovogKorisnika = new frmAddNovogKorisnika();
            frmAddNovogKorisnika.ShowDialog();
        }

        private void showMessage(string title, string poruka)
        {
            AutoClosingMessageBox.Show(poruka, title, 3000);
        }


        private async void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KorisnikModel korisnik = (KorisnikModel)dgvKorisnici.SelectedRows[0].DataBoundItem;
            if (e.ColumnIndex == 4)
            {
                KorisnikUpdateRequest korisnikSearchObject = new KorisnikUpdateRequest();
                korisnikSearchObject.IsActive = false;
                var korisnikModels = await korisnikService.Put<KorisnikUpdateRequest>(korisnik.KorisnikId, korisnikSearchObject);
                loadKorisnike();
                showMessage("Korisnik obrisan!", "Korisnik uspjesno obrisan.");
            }
            else
            {
                frmAddNovogKorisnika frmAddNovogKorisnika = new frmAddNovogKorisnika(korisnik);
                frmAddNovogKorisnika.ShowDialog();  
            }
        }
    }
}
