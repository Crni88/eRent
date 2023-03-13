using eRent.Models;
using eRent.Models.Requests.Task;
using eRent.UI.Helpers;

namespace eRent.UI
{
    public partial class frmAddTask : Form
    {
        public APIService TaskService { get; set; } = new APIService("Task");
        public NekretninaModel Nekretnina { get; }

        public frmAddTask(NekretninaModel nekretnina)
        {
            InitializeComponent();
            Nekretnina = nekretnina;
        }

        private void frmAddTask_Load(object sender, EventArgs e)
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

        private void showMessage()
        {
            AutoClosingMessageBox.Show("Zadatak uspjesno kreiran!", "Zadatak kreiran!", 3000);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    TaskInsertRequest taskInsertRequest = new TaskInsertRequest();
                    taskInsertRequest.NekretninaTask = Nekretnina.NekretninaId;
                    taskInsertRequest.Title = txtTitle.Text;
                    taskInsertRequest.Description = txtDescription.Text;
                    taskInsertRequest.Status = cbStatus.Text;
                    taskInsertRequest.Priority = cbPriority.Text;
                    taskInsertRequest.DueDate = dtpDueDate.Value;
                    var taskInsert = await TaskService.Post<TaskModel>(taskInsertRequest);
                    showMessage();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
    }
}
