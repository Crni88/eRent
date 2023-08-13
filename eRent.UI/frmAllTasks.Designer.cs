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
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Uredi = new DataGridViewButtonColumn();
            Obrisi = new DataGridViewButtonColumn();
            btnAddNew = new Button();
            btnLoad = new Button();
            cbPrioritet = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cbStatus = new ComboBox();
            btnNazad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAllTask).BeginInit();
            SuspendLayout();
            // 
            // dgvAllTask
            // 
            dgvAllTask.AllowUserToAddRows = false;
            dgvAllTask.AllowUserToDeleteRows = false;
            dgvAllTask.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllTask.Columns.AddRange(new DataGridViewColumn[] { Title, Description, DueDate, Priority, Status, Uredi, Obrisi });
            dgvAllTask.Location = new Point(10, 76);
            dgvAllTask.Margin = new Padding(3, 2, 3, 2);
            dgvAllTask.Name = "dgvAllTask";
            dgvAllTask.ReadOnly = true;
            dgvAllTask.RowHeadersWidth = 51;
            dgvAllTask.RowTemplate.Height = 29;
            dgvAllTask.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllTask.Size = new Size(770, 253);
            dgvAllTask.TabIndex = 0;
            dgvAllTask.CellContentClick += dgvAllTask_CellContentClick;
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
            DueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DueDate.DataPropertyName = "DueDate";
            DueDate.HeaderText = "Datum Zavrsetka";
            DueDate.MinimumWidth = 6;
            DueDate.Name = "DueDate";
            DueDate.ReadOnly = true;
            // 
            // Priority
            // 
            Priority.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Priority.DataPropertyName = "Priority";
            Priority.HeaderText = "Prioritet";
            Priority.MinimumWidth = 6;
            Priority.Name = "Priority";
            Priority.ReadOnly = true;
            Priority.Width = 74;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 64;
            // 
            // Uredi
            // 
            Uredi.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Uredi.HeaderText = "Uredi";
            Uredi.Name = "Uredi";
            Uredi.ReadOnly = true;
            Uredi.Text = "Uredi";
            Uredi.ToolTipText = "Uredi";
            Uredi.UseColumnTextForButtonValue = true;
            Uredi.Width = 41;
            // 
            // Obrisi
            // 
            Obrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Obrisi.HeaderText = "Obrisi";
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Obrisi";
            Obrisi.UseColumnTextForButtonValue = true;
            Obrisi.Width = 44;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(698, 39);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(82, 27);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Dodaj novi";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(376, 39);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 27);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Ucitaj";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // cbPrioritet
            // 
            cbPrioritet.FormattingEnabled = true;
            cbPrioritet.Location = new Point(65, 42);
            cbPrioritet.Name = "cbPrioritet";
            cbPrioritet.Size = new Size(121, 23);
            cbPrioritet.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 4;
            label1.Text = "Prioritet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 45);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(249, 42);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(121, 23);
            cbStatus.TabIndex = 6;
            // 
            // btnNazad
            // 
            btnNazad.Location = new Point(12, 12);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(75, 23);
            btnNazad.TabIndex = 7;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            btnNazad.Click += btnNazad_Click;
            // 
            // frmAllTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 338);
            Controls.Add(btnNazad);
            Controls.Add(cbStatus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbPrioritet);
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
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllTask;
        private Button btnAddNew;
        private Button btnLoad;
        private ComboBox cbPrioritet;
        private Label label1;
        private Label label2;
        private ComboBox cbStatus;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
        private Button btnNazad;
    }
}