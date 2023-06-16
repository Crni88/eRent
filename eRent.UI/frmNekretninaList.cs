using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmNekretninaList : Form
    {
        public APIService NekretnineService { get; set; } = new APIService("Nekretnine");
        public dynamic Result { get; }
        private string _username { get; set; }
        public frmNekretninaList(string username, dynamic result = null)
        {
            InitializeComponent();
            dgvNekretnineList.AutoGenerateColumns = false;
            Result = result;
            this._username = username;

        }

        public async void btnShowNekretnine_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                await loadData();
            }
            else
            {
                NekretninaSearchObject nekretnina = new NekretninaSearchObject();
                nekretnina.NameFTS = txtSearch.Text;
                nekretnina.IsActive = true;
                nekretnina.Username = _username;
                var list = await NekretnineService.Get<List<NekretninaModel>>(nekretnina);
                dgvNekretnineList.DataSource = list;
            }
        }

        public async Task loadData()
        {
            NekretninaSearchObject nekretnina = new NekretninaSearchObject();
            nekretnina.IsActive = true;
            nekretnina.Username = _username;
            var list = await NekretnineService.Get<List<NekretninaModel>>(nekretnina);
            dgvNekretnineList.DataSource = list;
        }

        private void btnDodajNovu_Click(object sender, EventArgs e)
        {
            frmAddNekretninu addNekretninu = new frmAddNekretninu(_username);
            addNekretninu.Show();
        }

        private async void dgvNekretnineList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var nekretnina = dgvNekretnineList.SelectedRows[0].DataBoundItem as NekretninaModel;
                if (nekretnina != null)
                {
                    frmRezervacije frmRezervacije = new frmRezervacije(nekretnina);
                    frmRezervacije.Show();
                }
            }
            if (e.ColumnIndex == 4)
            {
                var nekretnina = dgvNekretnineList.SelectedRows[0].DataBoundItem as NekretninaModel;
                if (nekretnina != null)
                {
                    //this.Close();
                    frmAddNekretninu addNekretninu = new frmAddNekretninu(_username, nekretnina);
                    addNekretninu.Show();
                }
            }
            if (e.ColumnIndex == 5)
            {
                var nekretnina = dgvNekretnineList.SelectedRows[0].DataBoundItem as NekretninaModel;
                if (nekretnina != null)
                {
                    frmKorisniciNekretnina frmKorisniciNekretnina = new frmKorisniciNekretnina(nekretnina);
                    frmKorisniciNekretnina.ShowDialog();
                    await loadData();
                }
            }
            if (e.ColumnIndex == 6)
            {
                var nekretnina = dgvNekretnineList.SelectedRows[0].DataBoundItem as NekretninaModel;
                if (nekretnina != null)
                {
                    frmPosjete frmPosjete = new frmPosjete(nekretnina);
                    frmPosjete.ShowDialog();
                }
            }
            if (e.ColumnIndex == 7)
            {
                var nekretnina = dgvNekretnineList.SelectedRows[0].DataBoundItem as NekretninaModel;
                if (nekretnina != null)
                {
                    frmAllTasks frmAllTasks = new frmAllTasks(nekretnina);
                    frmAllTasks.ShowDialog();
                }
            }
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            frmOpcijeIzvjestaja frmIzvjestaj = new frmOpcijeIzvjestaja();
            frmIzvjestaj.Show();
        }

        private void btnRejting_Click(object sender, EventArgs e)
        {
            frmRejting frmRejting = new frmRejting(Result);
            frmRejting.Show();
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            frmSviKorisnici frmAddNovogKorisnika = new frmSviKorisnici();
            frmAddNovogKorisnika.Show();
        }

        private async void frmNekretninaList_Load(object sender, EventArgs e)
        {
            await loadData();
        }

        private void btnSveRezervacije_Click(object sender, EventArgs e)
        {
            frmSveRezervacije frmSveRezervacije = new frmSveRezervacije();
            frmSveRezervacije.Show();
        }
    }
}
