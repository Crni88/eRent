using eRent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eRent.UI
{
    public partial class frmSviKorisnici : Form
    {
        private readonly APIService korisnikService = new APIService("Korisnici");

        public frmSviKorisnici()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private async void btnUcitajKorisnike_Click(object sender, EventArgs e)
        {
            List<KorisnikModel> korisnikModels = await korisnikService.Get<List<KorisnikModel>>();
            dgvKorisnici.DataSource = korisnikModels;
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            frmAddNovogKorisnika frmAddNovogKorisnika = new frmAddNovogKorisnika();
            frmAddNovogKorisnika.ShowDialog();
        }
    }
}
