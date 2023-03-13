using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Requests.NekretninaTag;
using eRent.Models.Search_Objects;
using System.Text.RegularExpressions;
using static eRent.UI.Helpers.ImageConverter;

namespace eRent.UI
{
    public partial class frmAddNekretninu : Form
    {

        public APIService NekretnineService { get; set; } = new APIService("Nekretnine");
        public APIService nekretninaTagoviService { get; set; } = new APIService("NekretnineTagovi");

        NekretninaModel _nekretninaModel { get; set; }
        NekretninaTagSearchObject nekretninaSearchObject = new NekretninaTagSearchObject();

        public frmAddNekretninu(NekretninaModel nekretnina = null)
        {
            InitializeComponent();
            if (nekretnina != null)
            {
                nekretninaSearchObject.NekretninaId = nekretnina.NekretninaId;
                _nekretninaModel = nekretnina;
                PopulateScreen();
                //btnDodajSliku.Enabled = false;
                loadTags(nekretninaSearchObject);
            }
        }
        List<NekretninaTagoviModel> allTags = new List<NekretninaTagoviModel>();
        private async void loadTags(NekretninaTagSearchObject nekretninaSearchObject)
        {
            var getTags = await nekretninaTagoviService.Get<List<NekretninaTagoviModel>>(nekretninaSearchObject);
            allTags = getTags;
            foreach (var tag in getTags)
            {
                if (tag.tagID == 1)
                {
                    cbTihoNaselje.Checked = (bool)tag.IsActive;
                }
                if (tag.tagID == 2)
                {
                    cbMiran.Checked = (bool)tag.IsActive;
                }
                if (tag.tagID == 3)
                {
                    cbNoSmoking.Checked = (bool)tag.IsActive;
                }
                if (tag.tagID == 4)
                {
                    cbOsvjetljen.Checked = (bool)tag.IsActive;
                }
                if (tag.tagID == 5)
                {
                    cbPetFriendly.Checked = (bool)tag.IsActive;
                }
            }
        }

        private void PopulateScreen()
        {
            txtNaziv.Text = _nekretninaModel.NazivNekretnine;
            txtGrad.Text = _nekretninaModel.Grad;
            txtCijena.Text = _nekretninaModel.Cijena.ToString();
            txtBrojSoba.Text = _nekretninaModel.BrojSoba.ToString();
            cbNamjestena.Checked = _nekretninaModel.Namještena;
            cbIzdvojena.Checked = (bool)_nekretninaModel.Izdvojena;
            cbPopunjena.Checked = (bool)_nekretninaModel.Popunjena;
            txtBrojKvadrata.Text = _nekretninaModel.Brojkvadrata.ToString();
            pbSlikaNekretnine.Image = FromByteToImage(_nekretninaModel.Slika);
            txtOpis.Text = _nekretninaModel.Opis;
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_nekretninaModel == null)
                {
                    NekretninaInsertRequest nekretninaInsertRequest = new NekretninaInsertRequest();
                    CreateInsertObject(nekretninaInsertRequest);
                    var postNekretnina = await NekretnineService.Post<NekretninaModel>(nekretninaInsertRequest);
                    _nekretninaModel = postNekretnina;
                    //TODO Test this
                    await UpdateTagsAsync();
                    this.Close();
                }
                else
                {
                    NekretninaUpdateRequest nekretninaUpdateRequest = CreateUpdateObject();
                    var updateNekretnina =
                        await NekretnineService.Put<NekretninaUpdateRequest>(_nekretninaModel.NekretninaId, nekretninaUpdateRequest);
                    await UpdateTagsAsync();
                    this.Close();
                }
            }
        }

        private async Task UpdateTagsAsync()
        {
            int[] tagIds = new int[] { 1, 2, 3, 4, 5 };
            bool[] checkboxValues = new bool[] { cbTihoNaselje.Checked, cbMiran.Checked, cbNoSmoking.Checked, cbOsvjetljen.Checked, cbPetFriendly.Checked };

            if (allTags.Count > 0)
            {
                NekretninaTagUpdateRequest nekretninaTagoviUpsertRequest = new NekretninaTagUpdateRequest();
                for (int i = 0; i < 5; i++)
                {
                        int id = allTags[i].NtId;
                        nekretninaTagoviUpsertRequest.TagId = tagIds[i];
                        nekretninaTagoviUpsertRequest.NekretninaId = _nekretninaModel.NekretninaId;
                        nekretninaTagoviUpsertRequest.IsActive = checkboxValues[i];
                        var postNekretnina = await nekretninaTagoviService.Put<NekretninaTagUpdateRequest>(id, nekretninaTagoviUpsertRequest);
                }
            }
            else
            {
                NekretninaTagoviInsertRequest nekretninaTagoviUpsertRequest = new NekretninaTagoviInsertRequest();
                for (int i = 0; i < tagIds.Length; i++)
                {
                    nekretninaTagoviUpsertRequest.TagId = tagIds[i];
                    nekretninaTagoviUpsertRequest.NekretninaId = _nekretninaModel.NekretninaId;
                    nekretninaTagoviUpsertRequest.IsActive = checkboxValues[i];
                    var postNekretnina = await nekretninaTagoviService.Post<NekretninaTagoviInsertRequest>(nekretninaTagoviUpsertRequest);
                }
            }
        }

        private NekretninaUpdateRequest CreateUpdateObject()
        {
            NekretninaUpdateRequest nekretninaUpdateRequest = new NekretninaUpdateRequest();
            nekretninaUpdateRequest.BrojSoba = int.Parse(txtBrojSoba.Text);
            nekretninaUpdateRequest.Brojkvadrata = int.Parse(txtBrojKvadrata.Text);
            nekretninaUpdateRequest.NazivNekretnine = txtNaziv.Text;
            nekretninaUpdateRequest.Grad = txtGrad.Text;
            nekretninaUpdateRequest.DatumObjave = DateTime.Now;
            nekretninaUpdateRequest.Namještena = cbNamjestena.Checked;
            nekretninaUpdateRequest.Cijena = int.Parse(txtBrojSoba.Text);
            nekretninaUpdateRequest.Popunjena = cbPopunjena.Checked;
            nekretninaUpdateRequest.Izdvojena = cbIzdvojena.Checked;
            nekretninaUpdateRequest.Opis = txtOpis.Text;
            nekretninaUpdateRequest.Slika = FromImageToBase64(pbSlikaNekretnine.Image);
            return nekretninaUpdateRequest;
        }

        private NekretninaInsertRequest CreateInsertObject(NekretninaInsertRequest nekretninaInsertRequest)
        {
            nekretninaInsertRequest.KorisnikNekretnina = 1;
            nekretninaInsertRequest.Username = APIService.username;
            nekretninaInsertRequest.Brojkvadrata = int.Parse(txtBrojKvadrata.Text);
            nekretninaInsertRequest.BrojSoba = int.Parse(txtBrojSoba.Text);
            nekretninaInsertRequest.NazivNekretnine = txtNaziv.Text;
            nekretninaInsertRequest.Grad = txtGrad.Text;
            nekretninaInsertRequest.DatumObjave = DateTime.Now;
            nekretninaInsertRequest.Namještena = cbNamjestena.Checked;
            nekretninaInsertRequest.Cijena = int.Parse(txtCijena.Text);
            nekretninaInsertRequest.Popunjena = cbPopunjena.Checked;
            nekretninaInsertRequest.Izdvojena = cbIzdvojena.Checked;
            nekretninaInsertRequest.Slika = FromImageToBase64(pbSlikaNekretnine.Image);
            nekretninaInsertRequest.Opis = txtOpis.Text;
            return nekretninaInsertRequest;
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

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            if (ofdSlikaNekretnine.ShowDialog() == DialogResult.OK)
            {
                pbSlikaNekretnine.Image = Image.FromFile(ofdSlikaNekretnine.FileName);
            }
        }

    }
}
