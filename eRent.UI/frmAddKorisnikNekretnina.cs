﻿using eRent.Models;
using eRent.Models.Requests.NekretninaKorisnik;
using System.Text.RegularExpressions;
using static eRent.UI.Helpers.ImageConverter;

namespace eRent.UI
{
    public partial class frmAddKorisnikNekretnina : Form
    {
        public APIService NekretninaKorisnikService { get; set; } = new APIService("NekretninaKorisnik");
        public NekretninaKorisnikModel _nekretninaKorisnik { get; set; }
        public NekretninaModel _nekretnina { get; }
        public frmAddKorisnikNekretnina(NekretninaKorisnikModel nekretninaKorisnik = null)
        {
            InitializeComponent();
            //this._nekretninaKorisnik = nekretninaKorisnik;
            if (nekretninaKorisnik != null)
            {
                GetKorisnik(nekretninaKorisnik.NekretninaKorisnikId);
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

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    this.Close();
                }
                else
                {
                    pbKorisnikSlika.Focus();
                    err.SetError(pbKorisnikSlika, "Slika je obavezna!");
                }
            }
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
            Regex regex = new Regex(@"^\+?[0-9]{1,3}[-\s]?\(?[0-9]{3}\)?[-\s]?[0-9]{3}[-\s]?[0-9]{3,4}$");
            return regex.IsMatch(text);
        }

        private void btnKorisnikSlika_Click(object sender, EventArgs e)
        {

            try
            {
                if (ofdKorisnikNekretnina.ShowDialog() == DialogResult.OK)
                {
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
                err.SetError(txtIme, "Obavezno polje!");
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
            else if (isPhoneNumber(txtBrojTelefona.Text))
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
    }
}
