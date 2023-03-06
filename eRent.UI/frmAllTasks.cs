using eRent.Models;
using eRent.Models.Search_Objects;

namespace eRent.UI
{
    public partial class frmAllTasks : Form
    {
        public APIService TaskService { get; set; } = new APIService("Task");
        public NekretninaModel Nekretnina { get; }

        public frmAllTasks(NekretninaModel nekretnina)
        {
            InitializeComponent();
            Nekretnina = nekretnina;
            dgvAllTask.AutoGenerateColumns = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddTask frmAddTask = new frmAddTask(Nekretnina);
            frmAddTask.ShowDialog();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            TaskSearchObject nekretninaKorisnik = new TaskSearchObject();
            nekretninaKorisnik.NekretninaTask = Nekretnina.NekretninaId;
            var list = await TaskService.Get<List<TaskModel>>(nekretninaKorisnik);
            dgvAllTask.DataSource = list;
        }

        private void frmAllTasks_Load(object sender, EventArgs e)
        {

        }
    }
}
