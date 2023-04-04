using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmRejting : Form
    {

        APIService prosjetaAPIService { get; set; } = new APIService("Rejting");
        public dynamic Result { get; }
        int korisnikId;

        public frmRejting(dynamic result)
        {
            InitializeComponent();
            dgvRejting.AutoGenerateColumns = false;
            korisnikId = result[0].korisnikNekretnina;
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            RejtingSearchObject rejtingSearchObject = new RejtingSearchObject();
            rejtingSearchObject.KorisnikPrim = korisnikId;
            var list = await prosjetaAPIService.Get<List<RejtingModel>>(rejtingSearchObject);
            dgvRejting.DataSource = list;
        }

        private void frmRejting_Load(object sender, EventArgs e)
        {

        }
    }
}
