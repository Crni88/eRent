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
            await loadTasks();
        }

        public async Task loadTasks()
        {
            try
            {
                TaskSearchObject nekretninaKorisnik = new TaskSearchObject();
                nekretninaKorisnik.NekretninaTask = Nekretnina.NekretninaId;
                nekretninaKorisnik.IsActive = true;
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
                await deleteTask();
            }
            else
            {
                //Otvori novu formu
                TaskModel taskModel = (TaskModel)dgvAllTask.SelectedRows[0].DataBoundItem;
                frmAddTask frmAddTask = new frmAddTask(Nekretnina, taskModel);
                frmAddTask.Show();
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
            loadTasks();
            AutoClosingMessageBox.Show("Task obrisan", "Task uspjesno obrisan!", 3000);
        }
    }
}
