using eRent.Models.Requests;

namespace eRent.UI
{
    public partial class frmAddNekretninu : Form
    {

        public APIService NekretnineService { get; set; } = new APIService("Nekretnine");

        public frmAddNekretninu()
        {
            InitializeComponent();
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            frmKorisniciNekretnina frmKorisniciNekretnina = new frmKorisniciNekretnina();
            frmKorisniciNekretnina.ShowDialog();
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            NekretninaInsertRequest nekretninaInsertRequest = new NekretninaInsertRequest();
            populateFields(nekretninaInsertRequest);

            var postNekretnina = await NekretnineService.Post<NekretninaInsertRequest>(nekretninaInsertRequest);
            this.Close();
        }

        private NekretninaInsertRequest populateFields(NekretninaInsertRequest nekretninaInsertRequest)
        {
            nekretninaInsertRequest.KorisnikNekretnina = 1;
            nekretninaInsertRequest.LokacijaId = 1;
            nekretninaInsertRequest.Username = APIService.username;
            nekretninaInsertRequest.BrojSoba = int.Parse(txtBrojSoba.Text);
            nekretninaInsertRequest.NazivNekretnine = txtNaziv.Text;
            nekretninaInsertRequest.Grad = txtGrad.Text;
            nekretninaInsertRequest.DatumObjave = DateTime.Now;
            nekretninaInsertRequest.Namještena = cbNamjestena.Checked;
            nekretninaInsertRequest.Cijena = int.Parse(txtBrojSoba.Text);
            nekretninaInsertRequest.Popunjena = cbPopunjena.Checked;
            nekretninaInsertRequest.Izdvojena = cbIzdvojena.Checked;
            nekretninaInsertRequest.TagIdList = addTags();
            return nekretninaInsertRequest;
        }

        private List<int> addTags()
        {
            var tagList = new List<int>() { };
            if (cbOsvjetljen.Checked)
            {
                tagList.Add(1);
            }
            if (cbNoSmoking.Checked)
            {
                tagList.Add(2);

            }

            if (cbMiran.Checked)
            {
                tagList.Add(3);

            }

            //if (cbPetFriendly.Checked)
            //{
            //    tagList.Add(4);
            //}
            return tagList;
        }

        private void frmAddNekretninu_Load(object sender, EventArgs e)
        {

        }
    }
}
