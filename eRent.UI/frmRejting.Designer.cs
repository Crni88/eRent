namespace eRent.UI
{
    partial class frmRejting
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
            dgvRejting = new DataGridView();
            Nekretnina = new DataGridViewTextBoxColumn();
            Korisnik = new DataGridViewTextBoxColumn();
            Rejting = new DataGridViewTextBoxColumn();
            Komentar = new DataGridViewTextBoxColumn();
            btnLoad = new Button();
            label1 = new Label();
            cbOcjene = new ComboBox();
            label2 = new Label();
            lblNemaRejtinga = new Label();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRejting).BeginInit();
            SuspendLayout();
            // 
            // dgvRejting
            // 
            dgvRejting.AllowUserToAddRows = false;
            dgvRejting.AllowUserToDeleteRows = false;
            dgvRejting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRejting.Columns.AddRange(new DataGridViewColumn[] { Nekretnina, Korisnik, Rejting, Komentar });
            dgvRejting.Location = new Point(12, 77);
            dgvRejting.Name = "dgvRejting";
            dgvRejting.ReadOnly = true;
            dgvRejting.RowTemplate.Height = 25;
            dgvRejting.Size = new Size(776, 361);
            dgvRejting.TabIndex = 0;
            // 
            // Nekretnina
            // 
            Nekretnina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nekretnina.DataPropertyName = "Nekretnina";
            Nekretnina.HeaderText = "Nekretnina";
            Nekretnina.Name = "Nekretnina";
            Nekretnina.ReadOnly = true;
            // 
            // Korisnik
            // 
            Korisnik.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Korisnik.DataPropertyName = "ImePrezime";
            Korisnik.HeaderText = "Korisnik";
            Korisnik.Name = "Korisnik";
            Korisnik.ReadOnly = true;
            // 
            // Rejting
            // 
            Rejting.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Rejting.DataPropertyName = "Rejting1";
            Rejting.HeaderText = "Rejting";
            Rejting.Name = "Rejting";
            Rejting.ReadOnly = true;
            Rejting.Width = 69;
            // 
            // Komentar
            // 
            Komentar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Komentar.DataPropertyName = "Komentar";
            Komentar.HeaderText = "Komentar";
            Komentar.Name = "Komentar";
            Komentar.ReadOnly = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(713, 43);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Ucitaj";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 3;
            label1.Text = "Rejting";
            // 
            // cbOcjene
            // 
            cbOcjene.FormattingEnabled = true;
            cbOcjene.Location = new Point(586, 43);
            cbOcjene.Name = "cbOcjene";
            cbOcjene.Size = new Size(121, 23);
            cbOcjene.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(522, 43);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 5;
            label2.Text = "Ocjene";
            // 
            // lblNemaRejtinga
            // 
            lblNemaRejtinga.AutoSize = true;
            lblNemaRejtinga.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblNemaRejtinga.Location = new Point(83, 208);
            lblNemaRejtinga.Name = "lblNemaRejtinga";
            lblNemaRejtinga.Size = new Size(634, 65);
            lblNemaRejtinga.TabIndex = 7;
            lblNemaRejtinga.Text = "Jos uvijek nemate rejtinge.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(50, 9);
            label8.Name = "label8";
            label8.Size = new Size(59, 21);
            label8.TabIndex = 29;
            label8.Text = "Nazad";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 9);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 28;
            label7.Text = "<-";
            label7.Click += label7_Click;
            // 
            // frmRejting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblNemaRejtinga);
            Controls.Add(label2);
            Controls.Add(cbOcjene);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Controls.Add(dgvRejting);
            Name = "frmRejting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rejting";
            Load += frmRejting_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRejting).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRejting;
        private Button btnLoad;
        private DataGridViewTextBoxColumn Nekretnina;
        private DataGridViewTextBoxColumn Korisnik;
        private DataGridViewTextBoxColumn Rejting;
        private DataGridViewTextBoxColumn Komentar;
        private Label label1;
        private ComboBox cbOcjene;
        private Label label2;
        private Label lblNemaRejtinga;
        private Label label8;
        private Label label7;
    }
}