using eRent.Models;
using eRent.Models.Requests.Korisnik;
using eRent.Models.Search_Objects;
using eRent.UI.Helpers;

namespace eRent.UI
{
    public partial class frmSviKorisnici : Form
    {
        private readonly APIService korisnikService = new APIService("Korisnici");
        private readonly APIService ulogaService = new APIService("Uloge");

        string _username { get; set; }
        public frmSviKorisnici(string username1)
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
            _username = username1;
        }

        private async void btnUcitajKorisnike_Click(object sender, EventArgs e)
        {
            await loadKorisnike();
        }

        public async Task loadKorisnike()
        {
            KorisnikSearchObject korisnikSearchObject = new KorisnikSearchObject();
            korisnikSearchObject.IsActive = true;
            //if (cbUloge.Text !="Sve")
            //{
            //    //korisnikSearchObject.Ulo
            //}
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                korisnikSearchObject.NameFTS = txtUsername.Text;
            }
            List<KorisnikModel> korisnikModels = await korisnikService.Get<List<KorisnikModel>>(korisnikSearchObject);
            dgvKorisnici.DataSource = korisnikModels;
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            openNovogKorisnika(2);
        }

        private void openNovogKorisnika(int v, KorisnikModel korisnikModel = null)
        {
            this.Hide();
            var form2 = v == 2
                ? new frmAddNovogKorisnika(_username, korisnikModel)
                : new frmAddNovogKorisnika(_username);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private async void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KorisnikModel korisnik = (KorisnikModel)dgvKorisnici.SelectedRows[0].DataBoundItem;
            if (e.ColumnIndex == 4)
            {
                openNovogKorisnika(2, korisnik);
            }
            if (e.ColumnIndex == 5)
            {
                if (korisnik.Username == _username)
                {
                    MessageBox.Show("Nije moguce obrisati usera sa kojim ste trenutno prijavljeni!");
                }
                else
                {
                    KorisnikUpdateRequest korisnikSearchObject = new KorisnikUpdateRequest();
                    korisnikSearchObject.IsActive = false;
                    korisnikSearchObject.KorisnikPrezime = "deleted";
                    korisnikSearchObject.KorsnikIme = "deleted";
                    var korisnikModels = await korisnikService.Put<KorisnikUpdateRequest>(korisnik.KorisnikId, korisnikSearchObject);
                    AutoClosingMessageBox.Show("Korisnik obrisan!", "Korisnik uspjesno obrisan.", 3000);
                    await loadKorisnike();
                }
            }
        }

        private async void frmSviKorisnici_Load(object sender, EventArgs e)
        {
            //await loadUloge();
            await loadKorisnike();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmNekretninaList(_username);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
