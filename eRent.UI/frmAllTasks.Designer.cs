namespace eRent.UI
{
    partial class frmAllTasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAllTask = new DataGridView();
            btnAddNew = new Button();
            btnLoad = new Button();
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Uredi = new DataGridViewButtonColumn();
            Obrisi = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAllTask).BeginInit();
            SuspendLayout();
            // 
            // dgvAllTask
            // 
            dgvAllTask.AllowUserToAddRows = false;
            dgvAllTask.AllowUserToDeleteRows = false;
            dgvAllTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllTask.Columns.AddRange(new DataGridViewColumn[] { Title, Description, DueDate, Priority, Status, Uredi, Obrisi });
            dgvAllTask.Location = new Point(10, 34);
            dgvAllTask.Margin = new Padding(3, 2, 3, 2);
            dgvAllTask.Name = "dgvAllTask";
            dgvAllTask.ReadOnly = true;
            dgvAllTask.RowHeadersWidth = 51;
            dgvAllTask.RowTemplate.Height = 29;
            dgvAllTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllTask.Size = new Size(770, 295);
            dgvAllTask.TabIndex = 0;
            dgvAllTask.CellContentClick += dgvAllTask_CellContentClick;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(698, 8);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(82, 22);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Dodaj novi";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(10, 9);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Ucitaj";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Naslov";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Opis";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // DueDate
            // 
            DueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DueDate.DataPropertyName = "DueDate";
            DueDate.HeaderText = "Datum Zavrsetka";
            DueDate.MinimumWidth = 6;
            DueDate.Name = "DueDate";
            DueDate.ReadOnly = true;
            DueDate.Width = 111;
            // 
            // Priority
            // 
            Priority.DataPropertyName = "Priority";
            Priority.HeaderText = "Prioritet";
            Priority.MinimumWidth = 6;
            Priority.Name = "Priority";
            Priority.ReadOnly = true;
            Priority.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // Uredi
            // 
            Uredi.HeaderText = "Uredi";
            Uredi.Name = "Uredi";
            Uredi.ReadOnly = true;
            Uredi.Text = "Uredi";
            Uredi.ToolTipText = "Uredi";
            Uredi.UseColumnTextForButtonValue = true;
            // 
            // Obrisi
            // 
            Obrisi.HeaderText = "Obrisi";
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Obrisi";
            Obrisi.UseColumnTextForButtonValue = true;
            // 
            // frmAllTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 338);
            Controls.Add(btnLoad);
            Controls.Add(btnAddNew);
            Controls.Add(dgvAllTask);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAllTasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Svi zadaci";
            Load += frmAllTasks_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllTask).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAllTask;
        private Button btnAddNew;
        private Button btnLoad;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
    }
}