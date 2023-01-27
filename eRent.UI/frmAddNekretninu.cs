using eRent.Models;
using eRent.Models.Requests;
using System.Text.RegularExpressions;

namespace eRent.UI
{
    public partial class frmAddNekretninu : Form
    {

        public APIService NekretnineService { get; set; } = new APIService("Nekretnine");
        NekretninaModel _nekretninaModel { get; set; }

        public frmAddNekretninu(NekretninaModel nekretnina = null)
        {
            InitializeComponent();
            if (nekretnina != null)
            {
                _nekretninaModel = nekretnina;
                PopulateScreen();
            }
        }

        private void PopulateScreen()
        {
            txtNaziv.Text = _nekretninaModel.NazivNekretnine;
            txtGrad.Text = _nekretninaModel.Grad;
            txtCijena.Text = _nekretninaModel.Cijena.ToString();
            txtBrojSoba.Text = _nekretninaModel.BrojSoba.ToString();
            cbNamjestena.Checked = _nekretninaModel.Namještena;
            cbIzdvojena.Checked = _nekretninaModel.Izdvojena;
            cbPopunjena.Checked = _nekretninaModel.Popunjena;
        }

        //TODO add error handling
        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_nekretninaModel == null)
                {
                    NekretninaInsertRequest nekretninaInsertRequest = new NekretninaInsertRequest();
                    CreateInsertObject(nekretninaInsertRequest);
                    var postNekretnina = await NekretnineService.Post<NekretninaInsertRequest>(nekretninaInsertRequest);
                    this.Close();
                }
                else
                {
                    //TODO EXTRACT TO SEPARATE FUNCTION
                    NekretninaUpdateRequest nekretninaUpdateRequest = CreateUpdateObject();
                    var updateNekretnina =
                        await NekretnineService.Put<NekretninaUpdateRequest>(_nekretninaModel.NekretninaId, nekretninaUpdateRequest);
                    this.Close();
                }
            }
        }
        private NekretninaUpdateRequest CreateUpdateObject()
        {
            NekretninaUpdateRequest nekretninaUpdateRequest = new NekretninaUpdateRequest();
            nekretninaUpdateRequest.BrojSoba = int.Parse(txtBrojSoba.Text);
            nekretninaUpdateRequest.NazivNekretnine = txtNaziv.Text;
            nekretninaUpdateRequest.Grad = txtGrad.Text;
            nekretninaUpdateRequest.DatumObjave = DateTime.Now;
            nekretninaUpdateRequest.Namještena = cbNamjestena.Checked;
            nekretninaUpdateRequest.Cijena = int.Parse(txtBrojSoba.Text);
            nekretninaUpdateRequest.Popunjena = cbPopunjena.Checked;
            nekretninaUpdateRequest.Izdvojena = cbIzdvojena.Checked;
            return nekretninaUpdateRequest;
        }

        private NekretninaInsertRequest CreateInsertObject(NekretninaInsertRequest nekretninaInsertRequest)
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

        //Validation
        private void txtNaziv_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                e.Cancel = true;
                txtNaziv.Focus();
                err.SetError(txtNaziv, "Name of the property should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtNaziv, "");
            }
        }

        private void txtBrojSoba_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBrojSoba.Text))
            {
                e.Cancel = true;
                txtBrojSoba.Focus();
                err.SetError(txtBrojSoba, "Number of rooms should not be left blank!");
            }
            else if (!IsNumber(txtBrojSoba.Text))
            {
                e.Cancel = true;
                txtBrojSoba.Focus();
                err.SetError(txtBrojSoba, "Number of rooms should be a number.");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtBrojSoba, "");
            }
        }

        private void txtCijena_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                e.Cancel = true;
                txtCijena.Focus();
                err.SetError(txtCijena, "Price should not be left blank!");
            }
            else if (!IsNumber(txtCijena.Text))
            {
                e.Cancel = true;
                txtCijena.Focus();
                err.SetError(txtCijena, "Price should be a number.");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtCijena, "");
            }
        }

        bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }
    }
}
