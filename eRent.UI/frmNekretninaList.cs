using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Search_Objects;
using eRent.UI.Helpers;
using System.Windows.Forms;

namespace eRent.UI
{
    public partial class frmNekretninaList : Form
    {
        public APIService NekretnineService { get; set; } = new APIService("Nekretnine");
        public dynamic Result { get; }
        private string _username { get; set; }
        private List<NekretninaModel> _listaNekretnina { get; set; } = new List<NekretninaModel>();
        public frmNekretninaList(string username, dynamic result = null)
        {
            InitializeComponent();
            dgvNekretnineList.AutoGenerateColumns = false;
            this.Result = result;
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
                this._listaNekretnina = list;
            }
        }

        public async Task loadData()
        {
            NekretninaSearchObject nekretnina = new NekretninaSearchObject();
            nekretnina.IsActive = true;
            nekretnina.Username = _username;
            var list = await NekretnineService.Get<List<NekretninaModel>>(nekretnina);
            dgvNekretnineList.DataSource = list;
            this._listaNekretnina = list;
        }

        private void btnDodajNovu_Click(object sender, EventArgs e)
        {
            closeThisFormAndOpenNext(2);
        }

        private void closeThisFormAndOpenNext(int v, NekretninaModel nekretnina = null)
        {
            this.Hide();
            Form form2;
            switch (v)
            {
                case 3:
                    form2 = new frmRezervacije(_username, nekretnina);
                    break;
                case 4:
                    form2 = new frmAddNekretninu(_username, nekretnina);
                    break;
                case 5:
                    form2 = new frmKorisniciNekretnina(_username, nekretnina);
                    break;
                case 6:
                    form2 = new frmPosjete(_username, nekretnina);
                    break;
                case 7:
                    form2 = new frmAllTasks(_username, nekretnina);
                    break;
                case 8:
                    form2 = new frmSviKorisnici(_username);
                    break;
                case 9:
                    form2 = new frmSveRezervacije(_username);
                    break;
                case 10:
                    var korisnikId = _listaNekretnina[0].KorisnikNekretnina;
                    form2 = new frmRejting(_username, korisnikId);
                    break;
                case 11:
                    form2 = new frmOpcijeIzvjestaja(_username);
                    break;
                default:
                    form2 = new frmAddNekretninu(_username);
                    break;
            }
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }



        private async void dgvNekretnineList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 3 && e.ColumnIndex <= 7)
            {
                //int v = e.ColumnIndex - 2;
                var nekretnina = dgvNekretnineList.SelectedRows[0].DataBoundItem as NekretninaModel;

                if (nekretnina != null)
                {
                    closeThisFormAndOpenNext(e.ColumnIndex, nekretnina);
                }
            }
            else if (e.ColumnIndex == 8)
            {
                var nekretnina = dgvNekretnineList.SelectedRows[0].DataBoundItem as NekretninaModel;

                if (nekretnina != null)
                {
                    NekretninaUpdateRequest nekretninaUpdateRequest = new NekretninaUpdateRequest();
                    // Set properties for nekretninaUpdateRequest
                    nekretninaUpdateRequest.IsActive = false;
                    nekretninaUpdateRequest.NazivNekretnine = nekretnina.NazivNekretnine;
                    nekretninaUpdateRequest.Opis = nekretnina.Opis;
                    nekretninaUpdateRequest.Cijena = nekretnina.Cijena;
                    nekretninaUpdateRequest.Brojkvadrata = nekretnina.Brojkvadrata.Value;
                    nekretninaUpdateRequest.Grad = nekretnina.Grad;
                    nekretninaUpdateRequest.DatumObjave = nekretnina.DatumObjave;
                    nekretninaUpdateRequest.Slika = nekretnina.Slika;
                    nekretninaUpdateRequest.BrojSoba = nekretnina.BrojSoba;
                    nekretninaUpdateRequest.Namještena = nekretnina.Namještena;
                    nekretninaUpdateRequest.Izdvojena = nekretnina.Izdvojena;
                    nekretninaUpdateRequest.Popunjena = nekretnina.Popunjena;
                    var updateNekretnina = await NekretnineService.Put<NekretninaUpdateRequest>(nekretnina.NekretninaId, nekretninaUpdateRequest);
                    await loadData();
                    AutoClosingMessageBox.Show("Nekretnina obrisana!", "Nekretnina uspjesno obrisana!", 3000);
                }
            }
        }


        private async void frmNekretninaList_Load(object sender, EventArgs e)
        {
            await loadData();
        }

        private void btnIzvjestaj_Click_1(object sender, EventArgs e)
        {
            closeThisFormAndOpenNext(11);
        }

        private void btnRejting_Click_1(object sender, EventArgs e)
        {
            closeThisFormAndOpenNext(10);
        }

        private void btnDodajKorisnika_Click_1(object sender, EventArgs e)
        {
            closeThisFormAndOpenNext(8);
        }

        private void btnSveRezervacije_Click_1(object sender, EventArgs e)
        {
            closeThisFormAndOpenNext(9);
        }
    }
}
