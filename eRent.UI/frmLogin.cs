﻿namespace eRent.UI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _ApiService = new APIService("Nekretnine");
        private readonly APIService korisnikService = new APIService("Korisnici");

        public frmLogin()
        {
            InitializeComponent();
            txtPassword.Text = "test";
            txtUsername.Text = "admin";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.username = txtUsername.Text;
            APIService.password = txtPassword.Text;

            try
            {
                var result = await _ApiService.Get<dynamic>();
                // var korisnik = await korisnikService.Get<KorisnikModel>(APIService.username);
                // APIService.korisnik = korisnik;
                frmNekretninaList frmNekretnina = new frmNekretninaList();
                frmNekretnina.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
