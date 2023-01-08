using eRent.Models;
using Flurl.Http;

namespace eRent.UI
{
    public partial class frmNekretninaList : Form
    {

        public APIService NekretnineService { get; set; } = new APIService("Nekretnine");

        public frmNekretninaList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void btnShowNekretnine_Click(object sender, EventArgs e)
        {
            //Get Json Async Returns a TASK 
            var list = await NekretnineService.Get<List<NekretninaModel>>();
            //TODO Test Out The Update Method When Get By Id is Fixed
           // var update = await NekretnineService.Put(4,)
        }

        private void frmNekretninaList_Load(object sender, EventArgs e)
        {
        }
    }
}
