namespace eRent.UI
{
    public partial class frmLogin : Form
    {

        private readonly APIService _ApiService = new APIService("Korisnici");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.username = txtUsername.Text;
            APIService.password = txtPassword.Text;

            try
            {
                var result = await _ApiService.Get<dynamic>();
                frmKorisnici frmKorisnici = new frmKorisnici();
                frmKorisnici.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    }
}
