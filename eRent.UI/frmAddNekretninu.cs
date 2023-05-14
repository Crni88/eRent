using eRent.Models;
using eRent.Models.Requests;
using eRent.Models.Requests.NekretninaTag;
using eRent.Models.Search_Objects;
using eRent.UI.Helpers;
using System.Text.RegularExpressions;
using static eRent.UI.Helpers.ImageConverter;

namespace eRent.UI
{
    public partial class frmAddNekretninu : Form
    {

        public APIService NekretnineService { get; set; } = new APIService("Nekretnine");
        public APIService nekretninaTagoviService { get; set; } = new APIService("NekretnineTagovi");
        private readonly APIService korisnikService = new APIService("Korisnici");
        private string _username { get; set; }

        int userId { get; set; }
        bool isPressed = false;

        NekretninaModel _nekretninaModel { get; set; }
        NekretninaTagSearchObject nekretninaSearchObject = new NekretninaTagSearchObject();
        public frmAddNekretninu(string username, NekretninaModel nekretnina = null)
        {
            InitializeComponent();
            this._username = username;
            btnObrisiNekretninu.Enabled = false;
            loadUser();
            if (nekretnina != null)
            {
                loadNekretnina(nekretnina.NekretninaId);
                nekretninaSearchObject.NekretninaId = nekretnina.NekretninaId;
                loadTags(nekretninaSearchObject);
                btnObrisiNekretninu.Enabled = true;
            }
        }

        private async void loadUser()
        {
            KorisnikSearchObject korisnikSearchObject = new KorisnikSearchObject();
            korisnikSearchObject.Username = _username;
            List<KorisnikModel> korisnikModel = await korisnikService.Get<List<KorisnikModel>>(korisnikSearchObject);
            userId = korisnikModel[0].KorisnikId;
        }

        private async void loadNekretnina(int nekretninaId)
        {
            _nekretninaModel = await NekretnineService.GetById<NekretninaModel>(nekretninaId);
            PopulateScreen();
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
                if (pbSlikaNekretnine.Image != null)
                {
                    err.SetError(pbSlikaNekretnine, "");
                    err.Clear();
                    if (_nekretninaModel == null)
                    {
                        NekretninaInsertRequest nekretninaInsertRequest = new NekretninaInsertRequest();
                        CreateInsertObject(nekretninaInsertRequest);
                        var postNekretnina = await NekretnineService.Post<NekretninaModel>(nekretninaInsertRequest);
                        _nekretninaModel = postNekretnina;
                        await UpdateTagsAsync();
                        AutoClosingMessageBox.Show("Nekretnina dodana!", "Nekretnina uspjesno dodana!", 3000);
                    }
                    else
                    {
                        NekretninaUpdateRequest nekretninaUpdateRequest = CreateUpdateObject();
                        var updateNekretnina =
                            await NekretnineService.Put<NekretninaUpdateRequest>(_nekretninaModel.NekretninaId, nekretninaUpdateRequest);
                        await UpdateTagsAsync();
                        AutoClosingMessageBox.Show("Nekretnina azurirana!", "Nekretnina uspjesno azurirana!", 3000);
                    }
                    frmNekretninaList frmNekretninaList = new frmNekretninaList(_username);
                    frmNekretninaList.ShowDialog();
                    this.Close();
                }
                else
                {
                    pbSlikaNekretnine.Focus();
                    err.SetError(pbSlikaNekretnine, "Slika je obavezna!");
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
            nekretninaUpdateRequest.Cijena = int.Parse(txtCijena.Text);
            nekretninaUpdateRequest.Popunjena = cbPopunjena.Checked;
            nekretninaUpdateRequest.Izdvojena = cbIzdvojena.Checked;
            nekretninaUpdateRequest.Opis = txtOpis.Text;
            nekretninaUpdateRequest.IsActive = true;
            if (isPressed)
            {
                nekretninaUpdateRequest.Slika = FromImageToBase64(pbSlikaNekretnine.Image);
            }
            else
            {
                nekretninaUpdateRequest.Slika = _nekretninaModel.Slika;
            }
            return nekretninaUpdateRequest;
        }

        private NekretninaInsertRequest CreateInsertObject(NekretninaInsertRequest nekretninaInsertRequest)
        {
            nekretninaInsertRequest.KorisnikNekretnina = userId;
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
            nekretninaInsertRequest.IsActive = true;
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
                isPressed = true;
                pbSlikaNekretnine.Image = Image.FromFile(ofdSlikaNekretnine.FileName);
            }
        }

        private async void btnObrisiNekretninu_Click(object sender, EventArgs e)
        {
            NekretninaUpdateRequest nekretninaUpdateRequest = CreateUpdateObject();
            nekretninaUpdateRequest.IsActive = false;
            var updateNekretnina =
                        await NekretnineService.Put<NekretninaUpdateRequest>(_nekretninaModel.NekretninaId, nekretninaUpdateRequest);
            AutoClosingMessageBox.Show("Nekretnina obrisana!", "Nekretnina uspjesno obrisana!", 3000);
            this.Close();
        }

        private void pbSlikaNekretnine_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (pbSlikaNekretnine.Image != null)
            {
                err.SetError(pbSlikaNekretnine, "");
                err.Clear();
            }
            else
            {
                pbSlikaNekretnine.Focus();
                err.SetError(pbSlikaNekretnine, "Slika je obavezna!");
            }
        }
    }
}