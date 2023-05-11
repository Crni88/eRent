using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _ApiService = new APIService("Nekretnine");
        private readonly APIService korisnikService = new APIService("Korisnici");

        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Text = "desktop";
            txtPassword.Text = "admin";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.username = txtUsername.Text;
            APIService.password = txtPassword.Text;

            try
            {
                List< KorisnikModel > korisnikModel = new List<KorisnikModel>();
                KorisnikSearchObject korisnikSearchObject = new KorisnikSearchObject();
                korisnikSearchObject.Username = txtUsername.Text;
                korisnikModel = await korisnikService.Get<List<KorisnikModel>>(korisnikSearchObject);
                if (korisnikModel[0].Uloga == "Admin")
                {
                    var result = await _ApiService.Get<dynamic>();
                    string username = txtUsername.Text;
                    frmNekretninaList frmNekretnina = new frmNekretninaList(username, result);
                    frmNekretnina.Show();
                }
                else
                {
                    MessageBox.Show("Invalid operation");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Email or password is incorrect.");
            }
        }
    }
}
