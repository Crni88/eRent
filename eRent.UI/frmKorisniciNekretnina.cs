using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmKorisniciNekretnina : Form
    {
        public APIService NekretninaKorisnikService { get; set; } = new APIService("NekretninaKorisnik");
        public NekretninaKorisnikModel NekretninaKorisnik { get; }

        private NekretninaModel _nekretnina;

        List<NekretninaKorisnikModel> list = new List<NekretninaKorisnikModel>();

        public frmKorisniciNekretnina(NekretninaModel nekretnina)
        {
            InitializeComponent();
            this._nekretnina = nekretnina;
            dgvKorisniciNekretnina.AutoGenerateColumns = false;
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
        }

        private void btnDodajNovogKorisnika_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddKorisnikNekretnina frmAddKorisnikNekretnina = new frmAddKorisnikNekretnina(_nekretnina);
            frmAddKorisnikNekretnina.ShowDialog();
        }

        private void dgvKorisniciNekretnina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var nekretninaKorisnik = dgvKorisniciNekretnina.SelectedRows[0].DataBoundItem as NekretninaKorisnikModel;
                if (nekretninaKorisnik != null)
                {
                    this.Close();
                    frmAddKorisnikNekretnina frmAddKorisniciNekretnina = new frmAddKorisnikNekretnina(nekretninaKorisnik,_nekretnina);
                    frmAddKorisniciNekretnina.ShowDialog();
                }
            }
        }

        private async void btnZahtjevZaPlacanje_Click(object sender, EventArgs e)
        {
            int brojKorisnika = list.Count();
            if (brojKorisnika == 0)
            {
                NekretninaKorisnikSearchObject nekretninaKorisnik = new NekretninaKorisnikSearchObject();
                nekretninaKorisnik.NekretninaId = _nekretnina.NekretninaId;
                list = await NekretninaKorisnikService.Get<List<NekretninaKorisnikModel>>(nekretninaKorisnik);
                brojKorisnika = list.Count();
                frmZahtjevZaPlacanje frmZahtjevZaPlacanje = new frmZahtjevZaPlacanje(brojKorisnika, _nekretnina);
                frmZahtjevZaPlacanje.ShowDialog();
            }
            else
            {
                frmZahtjevZaPlacanje frmZahtjevZaPlacanje = new frmZahtjevZaPlacanje(brojKorisnika, _nekretnina);
                frmZahtjevZaPlacanje.ShowDialog();
            }
        }

        private async void frmKorisniciNekretnina_Load(object sender, EventArgs e)
        {
            await loadData();
        }
    }
}
