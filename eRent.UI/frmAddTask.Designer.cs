namespace eRent.UI
{
    partial class frmAddTask
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
            components = new System.ComponentModel.Container();
            btnSave = new Button();
            label1 = new Label();
            txtTitle = new TextBox();
            txtDescription = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            dtpDueDate = new DateTimePicker();
            label4 = new Label();
            cbPriority = new ComboBox();
            cbStatus = new ComboBox();
            label5 = new Label();
            err = new ErrorProvider(components);
            btnNazad = new Button();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(128, 262);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 0;
            btnSave.Text = "Sacuvaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Naslov";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 66);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(110, 23);
            txtTitle.TabIndex = 2;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 114);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(110, 91);
            txtDescription.TabIndex = 3;
            txtDescription.Text = "";
            txtDescription.Validating += txtDescription_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Opis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 207);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 5;
            label3.Text = "Datum završetka";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(12, 224);
            dtpDueDate.Margin = new Padding(3, 2, 3, 2);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(219, 23);
            dtpDueDate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 49);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Prioritet";
            // 
            // cbPriority
            // 
            cbPriority.FormattingEnabled = true;
            cbPriority.Location = new Point(176, 66);
            cbPriority.Margin = new Padding(3, 2, 3, 2);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(133, 23);
            cbPriority.TabIndex = 8;
            cbPriority.Validating += cbPriority_Validating;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(176, 118);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(133, 23);
            cbStatus.TabIndex = 10;
            cbStatus.Validating += cbStatus_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 101);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Status";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // btnNazad
            // 
            btnNazad.Location = new Point(12, 12);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(75, 23);
            btnNazad.TabIndex = 34;
            btnNazad.Text = "<- Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            btnNazad.Click += btnNazad_Click;
            // 
            // frmAddTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(374, 301);
            Controls.Add(btnNazad);
            Controls.Add(cbStatus);
            Controls.Add(label5);
            Controls.Add(cbPriority);
            Controls.Add(label4);
            Controls.Add(dtpDueDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAddTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalji";
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private TextBox txtTitle;
        private RichTextBox txtDescription;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDueDate;
        private Label label4;
        private ComboBox cbPriority;
        private ComboBox cbStatus;
        private Label label5;
        private ErrorProvider err;
        private Button btnNazad;
    }
}