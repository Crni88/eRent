using eRent.Models;
using eRent.Models.Requests.Korisnik;
using eRent.UI.Helpers;
using System.Text.RegularExpressions;

namespace eRent.UI
{
    public partial class frmAddNovogKorisnika : Form
    {

        public APIService KorisnikService { get; set; } = new APIService("Korisnici");
        public APIService UlogeService { get; set; } = new APIService("Uloge");

        public frmAddNovogKorisnika()
        {
            InitializeComponent();
        }

        private void showMessage()
        {
            AutoClosingMessageBox.Show("Korisnik uspjesno dodan!", "Korisnik kreiran!", 3000);
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

        private async void btnDodajNovogKorisnika_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    KorisnikInsertRequest korisnikInsertRequest = new KorisnikInsertRequest();

                    korisnikInsertRequest.Email = txtEmail.Text;
                    korisnikInsertRequest.Rejting = 0;
                    korisnikInsertRequest.KorisnikPrezime = txtKorisnikPrezime.Text;
                    korisnikInsertRequest.KorsnikIme = txtKorisnikIme.Text;
                    korisnikInsertRequest.Username = txtUsername.Text;
                    korisnikInsertRequest.Password = txtPassword.Text;
                    korisnikInsertRequest.Uloga = cbUloga.SelectedItem.ToString();
                    var taskInsert = await KorisnikService.Post<TaskModel>(korisnikInsertRequest);
                    if (taskInsert != null)
                    {
                        showMessage();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmAddNovogKorisnika_Load(object sender, EventArgs e)
        {
            //TODO Load the roles from an API
            List<String> Uloge = new List<String>();
            Uloge.Add("Admin");
            Uloge.Add("Korisnik");
            cbUloga.DataSource = Uloge;
        }
    }
}
