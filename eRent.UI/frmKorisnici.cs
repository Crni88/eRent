using eRent.Models;
using eRent.Models.Search_Objects;
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
    public partial class frmKorisnici : Form
    {
        public APIService KorisniciService { get; set; } = new APIService("Korisnici");
        
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void frmKorisnici_Load(object sender, EventArgs e)
        {

        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var searchObject = new KorisnikSearchObject(); 
            searchObject.NameFTS = txtUsername.Text;
            var list = await KorisniciService.Get<List<KorisnikModel>>(searchObject);
            dgvKorisnici.DataSource = list; 
        }
    }
}
