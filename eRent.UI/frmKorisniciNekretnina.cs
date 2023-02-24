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
            this._nekretnina = nekretnina;
            InitializeComponent();
            dgvKorisniciNekretnina.AutoGenerateColumns = false;
        }

        private async void btnUcitajKorisnike_Click(object sender, EventArgs e)
        {
            NekretninaKorisnikSearchObject nekretninaKorisnik = new NekretninaKorisnikSearchObject();
            nekretninaKorisnik.NekretninaId = _nekretnina.NekretninaId;
            list = await NekretninaKorisnikService.Get<List<NekretninaKorisnikModel>>(nekretninaKorisnik);
            dgvKorisniciNekretnina.DataSource = list;
        }

        private void btnDodajNovogKorisnika_Click(object sender, EventArgs e)
        {
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
                    frmAddKorisnikNekretnina frmAddKorisniciNekretnina = new frmAddKorisnikNekretnina(nekretninaKorisnik);
                    frmAddKorisniciNekretnina.ShowDialog();
                }
            }
        }

        private void btnZahtjevZaPlacanje_Click(object sender, EventArgs e)
        {
            int brojKorisnika = list.Count();
            frmZahtjevZaPlacanje frmZahtjevZaPlacanje = new frmZahtjevZaPlacanje(brojKorisnika,_nekretnina);
            frmZahtjevZaPlacanje.ShowDialog();      
        }
    }
}
