using eRent.Models;
using eRent.Models.Requests.Korisnik;
using eRent.Models.Requests.KorisnikTag;
using eRent.UI.Helpers;
using System.Text.RegularExpressions;

namespace eRent.UI
{
    public partial class frmAddNovogKorisnika : Form
    {

        public APIService KorisnikService { get; set; } = new APIService("Korisnici");
        public APIService UlogeService { get; set; } = new APIService("Uloge");
        private APIService KorisnikTagoviService { get; set; } = new APIService("KorisnikTagovi");
        public KorisnikModel Korisnik { get; }

        string _username { get; set; }

        public frmAddNovogKorisnika(string _username, KorisnikModel korisnik = null)
        {
            InitializeComponent();
            this._username = _username;
            loadUloge();
            if (korisnik != null)
            {
                Korisnik = korisnik;
                loadData();
                txtEmail.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                txtPassword.Visible = false;
                lblPassword.Visible = false;
            }

        }

        private void loadData()
        {
            txtKorisnikIme.Text = Korisnik.KorsnikIme;
            txtEmail.Text = Korisnik.Email;
            txtUsername.Text = Korisnik.Username;
            txtKorisnikPrezime.Text = Korisnik.KorisnikPrezime;
            cbUloga.Text = Korisnik.Uloga;
        }

        private void txtKorisnikIme_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnikIme.Text))
            {
                e.Cancel = true;
                txtKorisnikIme.Focus();
                err.SetError(txtKorisnikIme, "Obavezno polje");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtKorisnikIme, "");
            }
        }

        private void txtKorisnikPrezime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnikPrezime.Text))
            {
                e.Cancel = true;
                txtKorisnikPrezime.Focus();
                err.SetError(txtKorisnikPrezime, "Obavezno polje");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtKorisnikPrezime, "");
            }
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                err.SetError(txtEmail, "Obavezno polje");
            }
            else if (isEmail(txtEmail.Text) == false)
            {
                e.Cancel = true;
                txtEmail.Focus();
                err.SetError(txtEmail, "Neispravan format!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtEmail, "");
            }
        }

        private bool isEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool isValidEmail = Regex.IsMatch(email, pattern);
            return isValidEmail;
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                txtUsername.Focus();
                err.SetError(txtUsername, "Obavezno polje");
            }
            else if (txtUsername.Text.Length < 3)
            {
                e.Cancel = true;
                txtUsername.Focus();
                err.SetError(txtUsername, "Minimalna duzina korisnickog imena je 3 karaktera.");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtUsername, "");
            }
        }

        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Korisnik == null)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    e.Cancel = true;
                    txtPassword.Focus();
                    err.SetError(txtPassword, "Obavezno polje");
                }
                else if (txtPassword.Text.Length < 5)
                {
                    e.Cancel = true;
                    txtPassword.Focus();
                    err.SetError(txtPassword, "Minimalna duzina passworda je 5 karaktera.");
                }
                else
                {
                    e.Cancel = false;
                    err.SetError(txtPassword, "");
                }
            }
        }

        private async void btnDodajNovogKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {
                    if (Korisnik == null)
                    {
                        await addKorisnik();

                    }
                    else
                    {
                        await updateKorisnik();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task updateKorisnik()
        {
            KorisnikUpdateRequest korisnikInsertRequest = new KorisnikUpdateRequest();
            korisnikInsertRequest.Uloga = cbUloga.SelectedItem.ToString();
            korisnikInsertRequest.KorisnikPrezime = txtKorisnikPrezime.Text;
            korisnikInsertRequest.KorsnikIme = txtKorisnikIme.Text;
            korisnikInsertRequest.IsActive = true;
            var taskInsert = await KorisnikService.Put<KorisnikModel>(Korisnik.KorisnikId, korisnikInsertRequest);
            if (taskInsert != null)
            {
                //CreateKorisnikTags(taskInsert.KorisnikId);
                AutoClosingMessageBox.Show("Korisnik uspjesno azuriran!", "Korisnik azuriran!", 3000);
                closeForm();
            }
        }

        private async Task addKorisnik()
        {
            KorisnikInsertRequest korisnikInsertRequest = new KorisnikInsertRequest();
            korisnikInsertRequest.Email = txtEmail.Text;
            korisnikInsertRequest.Rejting = 0;
            korisnikInsertRequest.KorisnikPrezime = txtKorisnikPrezime.Text;
            korisnikInsertRequest.KorsnikIme = txtKorisnikIme.Text;
            korisnikInsertRequest.Username = txtUsername.Text;
            korisnikInsertRequest.Password = txtPassword.Text;
            korisnikInsertRequest.Uloga = cbUloga.SelectedItem.ToString();
            korisnikInsertRequest.IsActive = true;
            var taskInsert = await KorisnikService.Post<KorisnikModel>(korisnikInsertRequest);
            if (taskInsert != null)
            {
                CreateKorisnikTags(taskInsert.KorisnikId);
                AutoClosingMessageBox.Show("Korisnik uspjesno dodan!", "Korisnik kreiran!", 3000);
                closeForm();
            }
        }

        private void closeForm()
        {
            this.Hide();
            var form2 = new frmSviKorisnici(_username);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private async void CreateKorisnikTags(int korisnikId)
        {
            try
            {
                KorisnikTagUpsertRequest korisnikTagUpsertRequest = new KorisnikTagUpsertRequest();
                for (int i = 1; i <= 5; i++)
                {
                    korisnikTagUpsertRequest.KorisnikId = korisnikId;
                    korisnikTagUpsertRequest.TagId = i;
                    korisnikTagUpsertRequest.IsActive = true;
                    var taskInsert = await KorisnikTagoviService.Post<KorisnikTagoviModel>(korisnikTagUpsertRequest);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadUloge()
        {
            List<String> Uloge = new List<String>();
            Uloge.Add("Admin");
            Uloge.Add("Korisnik");
            cbUloga.DataSource = Uloge;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
          closeForm();
        }
    }
}
