using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmPosjete : Form
    {
        NekretninaModel _nekretnina { get; set; }
        APIService prosjetaAPIService { get; set; } = new APIService("Posjeta");
        string _username;
        public frmPosjete(string _username, NekretninaModel nekretnina)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this._nekretnina = nekretnina;
            this._username = _username;
        }

        private async void btnUcitaj_Click(object sender, EventArgs e)
        {
            PosjetaSearchObject posjetaSearchObject = new PosjetaSearchObject();
            posjetaSearchObject.NekretninaId = _nekretnina.NekretninaId;
            posjetaSearchObject.Otkazana = false;
            var list = await prosjetaAPIService.Get<List<PosjetaModel>>(posjetaSearchObject);
            if (list.Count > 0)
            {

                dataGridView1.DataSource = list;
            }
            else
            {
                dataGridView1.Visible = false;
                btnUcitaj.Visible = false;
                lblNemaPosjeta.Visible = true;
                lblNemaPosjeta.Text = "Nema posjeta za ovu nekretninu.";
            }
        }

        private void frmPosjete_Load(object sender, EventArgs e)
        {
            btnUcitaj_Click(sender, e);
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
