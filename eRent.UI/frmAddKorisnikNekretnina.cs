using eRent.Models;
using eRent.Models.Requests.NekretninaKorisnik;
using System.Text.RegularExpressions;
using static eRent.UI.Helpers.ImageConverter;

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
            pbKorisnikSlika.Image = FromByteToImage(_nekretninaKorisnik.Slika);
        }

        private void populateFields(NekretninaKorisnikInsertRequest nekretninaKorisnikInsertRequest)
        {
            nekretninaKorisnikInsertRequest.PrezimeKorisnika = txtPrezime.Text;
            nekretninaKorisnikInsertRequest.ImeKorisnika = txtIme.Text;
            nekretninaKorisnikInsertRequest.BrojTelefona = txtBrojTelefona.Text;
            nekretninaKorisnikInsertRequest.DatumIseljenja = dtpDatumIseljenja.Value;
            nekretninaKorisnikInsertRequest.DatumUseljenja = dtpDatumUseljenja.Value;
            nekretninaKorisnikInsertRequest.Slika = FromImageToBase64(pbKorisnikSlika.Image);
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
            nekretninaKorisnikUpdateRequest.DatumIseljenja = dtpDatumIseljenja.Value;
            nekretninaKorisnikUpdateRequest.DatumUseljenja = dtpDatumUseljenja.Value;
            nekretninaKorisnikUpdateRequest.BrojTelefona = txtBrojTelefona.Text;
            nekretninaKorisnikUpdateRequest.ImeKorisnika = txtIme.Text;
            nekretninaKorisnikUpdateRequest.PrezimeKorisnika = txtPrezime.Text;
            nekretninaKorisnikUpdateRequest.Slika = FromImageToBase64(pbKorisnikSlika.Image);
            return nekretninaKorisnikUpdateRequest;
        }

        private bool isPhoneNumber(string text)
        {
            Regex regex = new Regex(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{3}$");
            return regex.IsMatch(text);
        }

        private void btnKorisnikSlika_Click(object sender, EventArgs e)
        {
            if (ofdKorisnikNekretnina.ShowDialog() == DialogResult.OK)
            {
                pbKorisnikSlika.Image = Image.FromFile(ofdKorisnikNekretnina.FileName);
            }
        }
    }
}
