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
            ((System.ComponentModel.ISupportInitialize)dgvRejting).BeginInit();
            SuspendLayout();
            // 
            // dgvRejting
            // 
            dgvRejting.AllowUserToAddRows = false;
            dgvRejting.AllowUserToDeleteRows = false;
            dgvRejting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRejting.Columns.AddRange(new DataGridViewColumn[] { Nekretnina, Korisnik, Rejting, Komentar });
            dgvRejting.Location = new Point(12, 36);
            dgvRejting.Name = "dgvRejting";
            dgvRejting.ReadOnly = true;
            dgvRejting.RowTemplate.Height = 25;
            dgvRejting.Size = new Size(776, 402);
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
            btnLoad.Location = new Point(713, 7);
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
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 3;
            label1.Text = "Rejting";
            // 
            // cbOcjene
            // 
            cbOcjene.FormattingEnabled = true;
            cbOcjene.Location = new Point(586, 7);
            cbOcjene.Name = "cbOcjene";
            cbOcjene.Size = new Size(121, 23);
            cbOcjene.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(522, 7);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 5;
            label2.Text = "Ocjene";
            // 
            // frmRejting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}