namespace eRent.UI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _ApiService = new APIService("Nekretnine");
        private readonly APIService korisnikService = new APIService("Korisnici");

        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Text = "admin";
            txtPassword.Text = "test";
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
                frmNekretninaList frmNekretnina = new frmNekretninaList(result);
                frmNekretnina.Show();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Email or password is incorrect.");
            }
        }
    }
}
