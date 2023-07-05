using eRent.Models;
using eRent.Models.Requests.Task;
using eRent.Models.Search_Objects;
using eRent.UI.Helpers;

namespace eRent.UI
{
    public partial class frmAllTasks : Form
    {
        public APIService TaskService { get; set; } = new APIService("Task");
        public NekretninaModel Nekretnina { get; }

        string _username;

        public frmAllTasks(string _username, NekretninaModel nekretnina)
        {
            InitializeComponent();
            Nekretnina = nekretnina;
            dgvAllTask.AutoGenerateColumns = false;
            this._username = _username;
            loadTasks();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            openNewForm(1);
        }

        private void openNewForm(int v, TaskModel taskModel = null)
        {
            this.Hide();
            frmAddTask form2;
            if (v == 1)
            {
                form2 = new frmAddTask(Nekretnina, _username);
            }
            else if (v == 2)
            {
                form2 = new frmAddTask(Nekretnina, _username, taskModel);
            }
            else
            {
                form2 = new frmAddTask(Nekretnina, _username);
            }
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await loadTasks();
        }

        public async Task loadTasks()
        {
            try
            {
                TaskSearchObject nekretninaKorisnik = new TaskSearchObject();
                nekretninaKorisnik.IsActive = true;
                if (cbPrioritet.Text != "Svi")
                {
                    nekretninaKorisnik.Priority = cbPrioritet.Text;
                }
                if (cbStatus.Text != "Svi")
                {
                    nekretninaKorisnik.Status = cbStatus.Text;
                }
                nekretninaKorisnik.NekretninaTask = Nekretnina.NekretninaId;
                var list = await TaskService.Get<List<TaskModel>>(nekretninaKorisnik);
                dgvAllTask.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvAllTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                TaskModel taskModel = (TaskModel)dgvAllTask.SelectedRows[0].DataBoundItem;
                openNewForm(2, taskModel);
            }
            if (e.ColumnIndex == 6)
            {
                await deleteTask();
            }
        }

        private async Task deleteTask()
        {
            TaskModel taskModel = (TaskModel)dgvAllTask.SelectedRows[0].DataBoundItem;
            TaskUpdateRequest tagUpsertRequest = new TaskUpdateRequest();
            tagUpsertRequest.IsActive = false;
            tagUpsertRequest.NekretninaTask = taskModel.NekretninaTask;
            tagUpsertRequest.Title = taskModel.Title;
            tagUpsertRequest.Description = taskModel.Description;
            tagUpsertRequest.DueDate = taskModel.DueDate;
            tagUpsertRequest.Status = taskModel.Status;
            tagUpsertRequest.Priority = taskModel.Priority;
            //tagUpsertRequest.TaskId = taskModel.TaskId;
            var taskModels = await TaskService.Put<TaskUpdateRequest>(taskModel.TaskId, tagUpsertRequest);
            await loadTasks();
            AutoClosingMessageBox.Show("Task uspjesno obrisan!", "Task obrisan", 3000);
        }

        private async void frmAllTasks_Load(object sender, EventArgs e)
        {
            List<String> priority = new List<String>();
            priority.Add("Svi");
            priority.Add("Low");
            priority.Add("Medium");
            priority.Add("High");
            cbPrioritet.DataSource = priority;
            List<String> status = new List<String>();
            status.Add("Svi");
            status.Add("TO DO");
            status.Add("In Progress");
            status.Add("Done");
            cbStatus.DataSource = status;
            await loadTasks();
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
