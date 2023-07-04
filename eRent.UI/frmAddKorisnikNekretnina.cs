using eRent.Models;
using eRent.Models.Requests.NekretninaKorisnik;
using eRent.UI.Helpers;
using System.Text.RegularExpressions;
using static eRent.UI.Helpers.ImageConverter;

namespace eRent.UI
{
    public partial class frmAddKorisnikNekretnina : Form
    {
        public APIService NekretninaKorisnikService { get; set; } = new APIService("NekretninaKorisnik");
        public NekretninaKorisnikModel _nekretninaKorisnik { get; set; }
        public NekretninaModel _nekretnina { get; }
        bool isPressed = false;

        public frmAddKorisnikNekretnina(NekretninaKorisnikModel nekretninaKorisnik = null, NekretninaModel nekretnina = null)
        {
            InitializeComponent();
            //this._nekretninaKorisnik = nekretninaKorisnik;
            this._nekretnina = nekretnina;
            if (nekretninaKorisnik != null)
            {
                GetKorisnik(nekretninaKorisnik.NekretninaKorisnikId);
                btnObrisi.Enabled = true;
                //btnKorisnikSlika.Enabled = false;
            }
        }

        private async void GetKorisnik(int nekretninaKorisnikId)
        {
            _nekretninaKorisnik = await NekretninaKorisnikService.GetById<NekretninaKorisnikModel>(nekretninaKorisnikId);
            LoadData();
        }

        public frmAddKorisnikNekretnina(NekretninaModel nekretnina)
        {
            InitializeComponent();
            btnObrisi.Enabled = false;
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

        private void insertKorisnikNekretnina(NekretninaKorisnikInsertRequest nekretninaKorisnikInsertRequest)
        {
            nekretninaKorisnikInsertRequest.PrezimeKorisnika = txtPrezime.Text;
            nekretninaKorisnikInsertRequest.ImeKorisnika = txtIme.Text;
            nekretninaKorisnikInsertRequest.BrojTelefona = txtBrojTelefona.Text;
            nekretninaKorisnikInsertRequest.DatumIseljenja = dtpDatumIseljenja.Value;
            nekretninaKorisnikInsertRequest.DatumUseljenja = dtpDatumUseljenja.Value;
            nekretninaKorisnikInsertRequest.Slika = FromImageToBase64(pbKorisnikSlika.Image);
            nekretninaKorisnikInsertRequest.IsActive = true;
        }
        private async void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (pbKorisnikSlika.Image != null)
                {
                    err.SetError(pbKorisnikSlika, "");
                    err.Clear();
                    if (_nekretninaKorisnik == null)
                    {
                        try
                        {
                            NekretninaKorisnikInsertRequest nekretninaKorisnikUpsert = new NekretninaKorisnikInsertRequest();
                            insertKorisnikNekretnina(nekretninaKorisnikUpsert);
                            nekretninaKorisnikUpsert.Nekretnina = _nekretnina.NekretninaId;
                            var postNekretnina = await NekretninaKorisnikService.Post<NekretninaKorisnikInsertRequest>(nekretninaKorisnikUpsert);
                            if (postNekretnina != null)
                            {
                                AutoClosingMessageBox.Show("Korisnik uspjesno dodan!", "Korisnik dodan!", 3000);
                                saveDataAndLoadForm();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            NekretninaKorisnikUpdateRequest nekretninaKorisnikUpdateRequest = UpdateKorisnikNekretnina();
                            var putNekretnina = await NekretninaKorisnikService.Put<NekretninaKorisnikUpdateRequest>(_nekretninaKorisnik.NekretninaKorisnikId, nekretninaKorisnikUpdateRequest);
                            if (putNekretnina != null)
                            {
                                AutoClosingMessageBox.Show("Korisnik uspjesno azuriran!", "Korisnik azuriran!", 3000);
                                saveDataAndLoadForm();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    pbKorisnikSlika.Focus();
                    err.SetError(pbKorisnikSlika, "Slika je obavezna!");
                }
            }
        }

        private void saveDataAndLoadForm()
        {
            //this.Close();
            //frmKorisniciNekretnina frmKorisniciNekretnina = new frmKorisniciNekretnina(_nekretnina);
            //frmKorisniciNekretnina.ShowDialog();
        }

        private NekretninaKorisnikUpdateRequest UpdateKorisnikNekretnina()
        {
            NekretninaKorisnikUpdateRequest nekretninaKorisnikUpdateRequest = new NekretninaKorisnikUpdateRequest();
            nekretninaKorisnikUpdateRequest.DatumIseljenja = dtpDatumIseljenja.Value;
            nekretninaKorisnikUpdateRequest.DatumUseljenja = dtpDatumUseljenja.Value;
            nekretninaKorisnikUpdateRequest.BrojTelefona = txtBrojTelefona.Text;
            nekretninaKorisnikUpdateRequest.ImeKorisnika = txtIme.Text;
            nekretninaKorisnikUpdateRequest.PrezimeKorisnika = txtPrezime.Text;
            nekretninaKorisnikUpdateRequest.IsActive = true;
            if (isPressed)
            {
                nekretninaKorisnikUpdateRequest.Slika = FromImageToBase64(pbKorisnikSlika.Image);
            }
            else
            {
                nekretninaKorisnikUpdateRequest.Slika = _nekretninaKorisnik.Slika;
            }
            return nekretninaKorisnikUpdateRequest;
        }

        private bool isPhoneNumber(string text)
        {
            Regex regex = new Regex(@"^\d{3}\s\d{3}\s\d{3,4}$");
            return regex.IsMatch(text);
        }

        private void btnKorisnikSlika_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdKorisnikNekretnina.ShowDialog() == DialogResult.OK)
                {
                    isPressed = true;
                    pbKorisnikSlika.Image = Image.FromFile(ofdKorisnikNekretnina.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Validation
        private void txtIme_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                e.Cancel = true;
                txtIme.Focus();
                err.SetError(txtIme, "Obavezno polje!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtIme, "");
            }
        }

        private void txtPrezime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                e.Cancel = true;
                txtPrezime.Focus();
                err.SetError(txtPrezime, "Obavezno polje!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtPrezime, "");
            }
        }

        private void txtBrojTelefona_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrojTelefona.Text))
            {
                e.Cancel = true;
                txtBrojTelefona.Focus();
                err.SetError(txtBrojTelefona, "Obavezno polje!");
            }
            else if (!isPhoneNumber(txtBrojTelefona.Text))
            {
                e.Cancel = true;
                txtBrojTelefona.Focus();
                err.SetError(txtBrojTelefona, "Format nije dobar");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtBrojTelefona, "");
            }
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                NekretninaKorisnikUpdateRequest nekretninaKorisnikUpdateRequest = UpdateKorisnikNekretnina();
                nekretninaKorisnikUpdateRequest.IsActive = false;
                var putNekretnina = await NekretninaKorisnikService.Put<NekretninaKorisnikUpdateRequest>(_nekretninaKorisnik.NekretninaKorisnikId, nekretninaKorisnikUpdateRequest);
                AutoClosingMessageBox.Show("Korisnik uspjesno obrisan!", "Korisnik obrisan!", 3000);
                saveDataAndLoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAddKorisnikNekretnina_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frmKorisniciNekretnina frmKorisniciNekretnina = new frmKorisniciNekretnina(_nekretnina);
            //frmKorisniciNekretnina.ShowDialog();
        }
    }
}
