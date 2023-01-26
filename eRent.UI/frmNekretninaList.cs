using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmNekretninaList : Form
    {

        public APIService NekretnineService { get; set; } = new APIService("Nekretnine");
        public APIService LokacijaService { get; set; } = new APIService("Lokacija");

        public frmNekretninaList()
        {
            InitializeComponent();
            dgvNekretnineList.AutoGenerateColumns= false;
        }

        private async void btnShowNekretnine_Click(object sender, EventArgs e)
        {
            //Get Json Async Returns a TASK 
            //TODO Test Out The Update Method When Get By Id is Fixed
            //var entity = await NekretnineService.GetById<NekretninaModel>(4);
            //entity.Opis = "Testni Opis Sa Formi Dolazi";
            //var update = await NekretnineService.Put<NekretninaModel>(entity.NekretninaId, entity);
            if (txtSearch.Text == "")
            {
                var list = await NekretnineService.Get<List<NekretninaModel>>();
                dgvNekretnineList.DataSource = list;
            }
            else
            {
                NekretninaSearchObject  nekretnina = new NekretninaSearchObject();
                nekretnina.NameFTS = txtSearch.Text;
                var list = await NekretnineService.Get<List<NekretninaModel>>(nekretnina);
                dgvNekretnineList.DataSource = list;
            }
        }

        private void frmNekretninaList_Load(object sender, EventArgs e)
        {
            dgvNekretnineList.AutoGenerateColumns = false;
        }

        private void btnDodajNovu_Click(object sender, EventArgs e)
        {
            frmAddNekretninu addNekretninu = new frmAddNekretninu();
            addNekretninu.Show();
        }

        private void dgvNekretnineList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                var nekretnina = dgvNekretnineList.SelectedRows[0].DataBoundItem as NekretninaModel;
                if (nekretnina != null)
                {
                    frmAddNekretninu addNekretninu = new frmAddNekretninu(nekretnina);
                    addNekretninu.Show();
                }
            }
            if (e.ColumnIndex == 7)
            {
                var nekretnina = dgvNekretnineList.SelectedRows[0].DataBoundItem as NekretninaModel;
                if (nekretnina != null)
                {
                    frmKorisniciNekretnina frmKorisniciNekretnina = new frmKorisniciNekretnina(nekretnina);
                    frmKorisniciNekretnina.ShowDialog();
                }
            }
        }
    }
}
