using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmKorisniciNekretnina : Form
    {
        public APIService NekretninaKorisnikService { get; set; } = new APIService("NekretninaKorisnik");
        
        private NekretninaModel _nekretnina;

        public frmKorisniciNekretnina(NekretninaModel nekretnina)
        {
            this._nekretnina = nekretnina;
            InitializeComponent();
        }
         
        private void frmKorisniciNekretnina_Load(object sender, EventArgs e)
        {
        }

        private async void btnUcitajKorisnike_Click(object sender, EventArgs e)
        {
            NekretninaKorisnikSearchObject nekretninaKorisnik = new NekretninaKorisnikSearchObject();
            nekretninaKorisnik.NekretninaId = _nekretnina.NekretninaId;
            var list = await NekretninaKorisnikService.Get<NekretninaKorisnikModel>();
            dgvKorisniciNekretnina.DataSource = list;
        }
    }
}
