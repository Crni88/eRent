using eRent.Models;
using eRent.Models.Requests.NekretninaKorisnik;

namespace eRent.UI
{
    public partial class frmAddKorisnikNekretnina : Form
    {
        public APIService NekretninaKorisnikService { get; set; } = new APIService("NekretninaKorisnik");
        public NekretninaKorisnikModel _nekretninaKorisnik { get; }
        public NekretninaModel _nekretnina { get; }

        public frmAddKorisnikNekretnina(NekretninaKorisnikModel nekretninaKorisnik = null)
        {
            InitializeComponent();
            this._nekretninaKorisnik = nekretninaKorisnik;
            if (_nekretninaKorisnik != null)
            {
                LoadData();
            }
        }

        public frmAddKorisnikNekretnina(NekretninaModel nekretnina)
        {
            InitializeComponent();
            _nekretnina = nekretnina;
        }

        private void LoadData()
        {
            txtBrojTelefona.Text = _nekretninaKorisnik.BrojTelefona;
            txtIme.Text = _nekretninaKorisnik.ImeKorisnika;
            txtPrezime.Text = _nekretninaKorisnik.PrezimeKorisnika;
            dtpDatumIseljenja.Value = Convert.ToDateTime(_nekretninaKorisnik.DatumIseljenja);
            dtpDatumUseljenja.Value = Convert.ToDateTime(_nekretninaKorisnik.DatumUseljenja);
        }

        private void populateFields(NekretninaKorisnikInsertRequest nekretninaKorisnikUpsert)
        {
            nekretninaKorisnikUpsert.PrezimeKorisnika = txtPrezime.Text;
            nekretninaKorisnikUpsert.ImeKorisnika = txtIme.Text;
            nekretninaKorisnikUpsert.BrojTelefona = txtBrojTelefona.Text;
            nekretninaKorisnikUpsert.DatumIseljenja = dtpDatumIseljenja.Value;
            nekretninaKorisnikUpsert.DatumUseljenja = dtpDatumUseljenja.Value;
            nekretninaKorisnikUpsert.NekretninaKorisnikSlika = 1;
            //TODO Add image
        }

        private void frmAddKorisnikNekretnina_Load(object sender, EventArgs e)
        {

        }

        private async void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            if (_nekretninaKorisnik == null)
            {
                NekretninaKorisnikInsertRequest nekretninaKorisnikUpsert = new NekretninaKorisnikInsertRequest();
                populateFields(nekretninaKorisnikUpsert);
                nekretninaKorisnikUpsert.Nekretnina = _nekretnina.NekretninaId;
                var postNekretnina = await NekretninaKorisnikService.Post<NekretninaKorisnikInsertRequest>(nekretninaKorisnikUpsert);
            }
            else
            {
                NekretninaKorisnikUpdateRequest nekretninaKorisnikUpdateRequest = UpdateKorisnikNekretnina();
                var putNekretnina = await NekretninaKorisnikService.Put<NekretninaKorisnikUpdateRequest>(_nekretninaKorisnik.NekretninaKorisnikId, nekretninaKorisnikUpdateRequest);
            }
            this.Close();
        }

        private NekretninaKorisnikUpdateRequest UpdateKorisnikNekretnina()
        {
            NekretninaKorisnikUpdateRequest nekretninaKorisnikUpdateRequest = new NekretninaKorisnikUpdateRequest();
            nekretninaKorisnikUpdateRequest.NekretninaKorisnikSlika = 1;
            nekretninaKorisnikUpdateRequest.DatumIseljenja = dtpDatumIseljenja.Value;
            nekretninaKorisnikUpdateRequest.DatumUseljenja = dtpDatumUseljenja.Value;
            nekretninaKorisnikUpdateRequest.BrojTelefona = txtBrojTelefona.Text;
            nekretninaKorisnikUpdateRequest.ImeKorisnika = txtIme.Text;
            nekretninaKorisnikUpdateRequest.PrezimeKorisnika = txtPrezime.Text;
            return nekretninaKorisnikUpdateRequest;
        }
    }
}
