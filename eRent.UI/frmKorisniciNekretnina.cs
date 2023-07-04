using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmKorisniciNekretnina : Form
    {
        public APIService NekretninaKorisnikService { get; set; } = new APIService("NekretninaKorisnik");
        public NekretninaKorisnikModel NekretninaKorisnik { get; }

        private NekretninaModel _nekretnina;

        string _username;

        List<NekretninaKorisnikModel> list = new List<NekretninaKorisnikModel>();

        public frmKorisniciNekretnina(string _username, NekretninaModel nekretnina)
        {
            InitializeComponent();
            this._nekretnina = nekretnina;
            dgvKorisniciNekretnina.AutoGenerateColumns = false;
            btnDodajNovogKorisnika.Visible = false;
            lblNemaKorisnika.Visible = false;
            this._username = _username;
        }

        private async void btnUcitajKorisnike_Click(object sender, EventArgs e)
        {
            await loadData();
        }

        public async Task loadData()
        {
            NekretninaKorisnikSearchObject nekretninaKorisnik = new NekretninaKorisnikSearchObject();
            nekretninaKorisnik.NekretninaId = _nekretnina.NekretninaId;
            nekretninaKorisnik.IsActive = true;
            list = await NekretninaKorisnikService.Get<List<NekretninaKorisnikModel>>(nekretninaKorisnik);
            dgvKorisniciNekretnina.DataSource = list;
            if (list.Count == 0)
            {
                lblNemaKorisnika.Visible = true;
                btnDodajNovogKorisnika.Visible = false;
                btnUcitajKorisnike.Visible = false;
                dgvKorisniciNekretnina.Visible = false;
                btnZahtjevZaPlacanje.Visible = false;
            }
        }

        private void btnDodajNovogKorisnika_Click(object sender, EventArgs e)
        {
            //this.Close();
            frmAddKorisnikNekretnina frmAddKorisnikNekretnina = new frmAddKorisnikNekretnina(_nekretnina);
            frmAddKorisnikNekretnina.ShowDialog();
        }

        private async void btnZahtjevZaPlacanje_Click(object sender, EventArgs e)
        {
            try
            {
                int brojKorisnika = dgvKorisniciNekretnina.RowCount;
                this.Hide();
                var form2 = new frmZahtjevZaPlacanje(brojKorisnika, _nekretnina,_username);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void frmKorisniciNekretnina_Load(object sender, EventArgs e)
        {
            await loadData();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            this.Hide();
            var form2 = new frmNekretninaList(_username);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
