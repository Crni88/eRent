using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmRezervacije : Form
    {
        NekretninaModel _nekretnina { get; set; }
        APIService rezervacijeAPIService { get; set; } = new APIService("PaymentRequest");

        string _username { get; set; }
        public frmRezervacije(string _username, NekretninaModel nekretnina)
        {
            InitializeComponent();
            dgvRezervacije.AutoGenerateColumns = false;
            this._nekretnina = nekretnina;
            this._username = _username;
        }

        private async void btnLoadRezervacije_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void frmRezervacije_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private async void loadData()
        {
            try
            {
                lblImeNekretnine.Text = _nekretnina.NazivNekretnine;
                PaymentRequestSearchObject rezervacijaSearchObject = new PaymentRequestSearchObject();
                rezervacijaSearchObject.NekretninaPayment = _nekretnina.NekretninaId;
                var list = await rezervacijeAPIService.Get<List<PaymentRequestModel>>(rezervacijaSearchObject);
                if (list.Count > 0)
                {
                    // Remove items with KorisnikPaymentId equal to 3
                    list.RemoveAll(item => item.KorisnikPaymentId == 3);

                    if (list.Count > 0)
                    {
                        dgvRezervacije.DataSource = list;
                    }
                    else
                    {
                        ShowNoReservationsMessage();
                    }
                }
                else
                {
                    ShowNoReservationsMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowNoReservationsMessage()
        {
            MessageBox.Show("Nema odobrenih rezervacija za ovu nekretninu");
            dgvRezervacije.Visible = false;
            btnLoadRezervacije.Visible = false;
            lblNemaPlacanja.Visible = true;
            lblNemaPlacanja.Text = "Nema odobrenih rezervacija za ovu nekretninu";
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmNekretninaList(_username);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
