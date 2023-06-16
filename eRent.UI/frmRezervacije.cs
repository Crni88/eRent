using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmRezervacije : Form
    {
        NekretninaModel _nekretnina { get; set; }
        APIService rezervacijeAPIService { get; set; } = new APIService("PaymentRequest");
        public frmRezervacije(NekretninaModel nekretnina)
        {
            InitializeComponent();
            dgvRezervacije.AutoGenerateColumns = false;
            this._nekretnina = nekretnina;
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
            PaymentRequestSearchObject rezervacijaSearchObject = new PaymentRequestSearchObject();
            rezervacijaSearchObject.NekretninaPayment = _nekretnina.NekretninaId;
            //rezervacijaSearchObject.Odobrena = true;
            //rezervacijaSearchObject.Otkazana = false;

            var list = await rezervacijeAPIService.Get<List<PaymentRequestModel>>(rezervacijaSearchObject);
            dgvRezervacije.DataSource = list;
        }
    }
}
