using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmRejting : Form
    {

        APIService rejtingAPIService { get; set; } = new APIService("Rejting");
        public dynamic Result { get; }
        int _korisnikId;
        string username;

        public frmRejting(string username, int korisnikId)
        {
            InitializeComponent();
            dgvRejting.AutoGenerateColumns = false;
            this._korisnikId = korisnikId;
            this.username = username;
            lblNemaRejtinga.Visible = false;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await loadData();
        }

        private async Task loadData()
        {
            try
            {
                RejtingSearchObject rejtingSearchObject = new RejtingSearchObject();
                rejtingSearchObject.KorisnikPrim = _korisnikId;
                if (cbOcjene.Text != "Sve")
                {
                    rejtingSearchObject.Rejting = float.Parse(cbOcjene.Text);
                }

                var list = await rejtingAPIService.Get<List<RejtingModel>>(rejtingSearchObject);
                if (list.Count > 0)
                {

                    dgvRejting.DataSource = list;
                }
                else
                {
                    dgvRejting.Visible = false;
                    lblNemaRejtinga.Visible = true;
                    cbOcjene.Visible = false;
                    btnLoad.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void frmRejting_Load(object sender, EventArgs e)
        {
            loadOcjene();
            await loadData();
        }

        private void loadOcjene()
        {
            List<string> ocjene = new List<string>();
            ocjene.Add("Sve");
            ocjene.Add("1");
            ocjene.Add("2");
            ocjene.Add("3");
            ocjene.Add("4");
            ocjene.Add("5");
            cbOcjene.DataSource = ocjene;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void goBack()
        {
            this.Hide();
            var form2 = new frmNekretninaList(username);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            goBack();
        }
    }
}
