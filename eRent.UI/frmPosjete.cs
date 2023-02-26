using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmPosjete : Form
    {
        NekretninaModel _nekretnina { get; set; }
        APIService prosjetaAPIService { get; set; } = new APIService("Posjeta");
        public frmPosjete(NekretninaModel nekretnina)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this._nekretnina = nekretnina;
        }
        
        private async void btnUcitaj_Click(object sender, EventArgs e)
        {
            PosjetaSearchObject posjetaSearchObject = new PosjetaSearchObject();
            posjetaSearchObject.NekretninaId = _nekretnina.NekretninaId;
            var list = await prosjetaAPIService.Get<List<PosjetaModel>>(posjetaSearchObject);
            dataGridView1.DataSource = list;
        }
       
    }
}
