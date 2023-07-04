using eRent.Models;
using eRent.Models.Requests.Task;
using eRent.UI.Helpers;

namespace eRent.UI
{
    public partial class frmAddTask : Form
    {
        public APIService TaskService { get; set; } = new APIService("Task");
        public NekretninaModel Nekretnina { get; set; }
        public TaskModel TaskModel { get; set; } = null;

        string _username; 

        public frmAddTask(NekretninaModel nekretnina, string _username, TaskModel taskModel = null)
        {
            InitializeComponent();
            Nekretnina = nekretnina;
            TaskModel = taskModel;
            this._username = _username;
            loadData();
            if (taskModel != null)
            {
                loadTaskData();
            }
        }

        private void loadTaskData()
        {
            txtDescription.Text = TaskModel.Description;
            txtTitle.Text = TaskModel.Title;
            cbPriority.Text = TaskModel.Priority;
            cbStatus.Text = TaskModel.Status;
            dtpDueDate.Value = TaskModel.DueDate;
        }

        private void loadData()
        {
            List<String> priority = new List<String>();
            priority.Add("Low");
            priority.Add("Medium");
            priority.Add("High");
            cbPriority.DataSource = priority;
            List<String> status = new List<String>();
            status.Add("TO DO");
            status.Add("In Progress");
            status.Add("Done");
            cbStatus.DataSource = status;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    if (TaskModel == null)
                    {
                        await addTask();
                    }
                    else
                    {
                        await updateTask();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updateAndCloseForm()
        {
            this.Hide();
            var form2 = new frmAllTasks(_username,Nekretnina);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }


        private async Task updateTask()
        {
            TaskUpdateRequest taskInsertRequest = new TaskUpdateRequest();
            taskInsertRequest.NekretninaTask = Nekretnina.NekretninaId;
            taskInsertRequest.Title = txtTitle.Text;
            taskInsertRequest.Description = txtDescription.Text;
            taskInsertRequest.Status = cbStatus.Text;
            taskInsertRequest.Priority = cbPriority.Text;
            taskInsertRequest.DueDate = dtpDueDate.Value;
            taskInsertRequest.IsActive = true;
            var taskInsert = await TaskService.Put<TaskModel>(TaskModel.TaskId, taskInsertRequest);
            if (taskInsert != null)
            {
                AutoClosingMessageBox.Show("Task azuriran!", "Task uspjesno azuriran.", 3000);
                updateAndCloseForm();
            }
        }

        private async Task addTask()
        {
            TaskInsertRequest taskInsertRequest = new TaskInsertRequest();
            taskInsertRequest.NekretninaTask = Nekretnina.NekretninaId;
            taskInsertRequest.Title = txtTitle.Text;
            taskInsertRequest.Description = txtDescription.Text;
            taskInsertRequest.Status = cbStatus.Text;
            taskInsertRequest.Priority = cbPriority.Text;
            taskInsertRequest.DueDate = dtpDueDate.Value;
            taskInsertRequest.IsActive = true;
            var taskInsert = await TaskService.Post<TaskModel>(taskInsertRequest);
            if (taskInsert != null)
            {
                AutoClosingMessageBox.Show("Task dodan!", "Task uspjesno dodan.", 3000);
                updateAndCloseForm();
            }
        }

        //Validating
        private void txtTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                e.Cancel = true;
                txtTitle.Focus();
                err.SetError(txtTitle, "Obavezno polje");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTitle, "");
            }
        }

        private void txtDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                txtDescription.Focus();
                err.SetError(txtDescription, "Obavezno polje");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtDescription, "");
            }
        }

        private void cbPriority_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbPriority.Text))
            {
                e.Cancel = true;
                cbPriority.Focus();
                err.SetError(cbPriority, "Obavezno polje");
            }
            else
            {
                e.Cancel = false;
                err.SetError(cbPriority, "");
            }
        }

        private void cbStatus_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                e.Cancel = true;
                txtDescription.Focus();
                err.SetError(cbStatus, "Obavezno polje");
            }
            else
            {
                e.Cancel = false;
                err.SetError(cbStatus, "");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            updateAndCloseForm();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            updateAndCloseForm();
        }
    }
}