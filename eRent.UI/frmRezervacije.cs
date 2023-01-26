using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmRezervacije : Form
    {
        NekretninaModel _nekretnina { get; set; }

        APIService rezervacijeAPIService { get; set; } = new APIService("Rezervacija");
        public frmRezervacije(NekretninaModel nekretnina)
        {
            InitializeComponent();
            dgvRezervacije.AutoGenerateColumns = false;
            this._nekretnina = nekretnina;
        }

        private async void btnLoadRezervacije_Click(object sender, EventArgs e)
        {
            RezervacijaSearchObject rezervacijaSearchObject = new RezervacijaSearchObject();
            rezervacijaSearchObject.NekretninaId = _nekretnina.NekretninaId;
            var list =await rezervacijeAPIService.Get<List<RezervacijaModel>>(rezervacijaSearchObject);
            dgvRezervacije.DataSource = list;
        }
    }
}
