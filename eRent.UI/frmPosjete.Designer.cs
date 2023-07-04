namespace eRent.UI
{
    partial class frmPosjete
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
            dataGridView1 = new DataGridView();
            NazivNekretnine = new DataGridViewTextBoxColumn();
            korisnikImePrezime = new DataGridViewTextBoxColumn();
            DatumPosjete = new DataGridViewTextBoxColumn();
            VrijemePosjete = new DataGridViewTextBoxColumn();
            btnUcitaj = new Button();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblNemaPosjeta = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NazivNekretnine, korisnikImePrezime, DatumPosjete, VrijemePosjete });
            dataGridView1.Location = new Point(16, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(772, 365);
            dataGridView1.TabIndex = 0;
            // 
            // NazivNekretnine
            // 
            NazivNekretnine.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivNekretnine.DataPropertyName = "nazivNekretnine";
            NazivNekretnine.HeaderText = "Naziv Nekretnine";
            NazivNekretnine.Name = "NazivNekretnine";
            NazivNekretnine.ReadOnly = true;
            // 
            // korisnikImePrezime
            // 
            korisnikImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            korisnikImePrezime.DataPropertyName = "korisnikImePrezime";
            korisnikImePrezime.HeaderText = "Ime i prezime";
            korisnikImePrezime.Name = "korisnikImePrezime";
            korisnikImePrezime.ReadOnly = true;
            // 
            // DatumPosjete
            // 
            DatumPosjete.DataPropertyName = "datumPosjete";
            DatumPosjete.HeaderText = "Datum Posjete";
            DatumPosjete.Name = "DatumPosjete";
            DatumPosjete.ReadOnly = true;
            // 
            // VrijemePosjete
            // 
            VrijemePosjete.DataPropertyName = "vrijemePosjete";
            VrijemePosjete.HeaderText = "Vrijeme Posjete";
            VrijemePosjete.Name = "VrijemePosjete";
            VrijemePosjete.ReadOnly = true;
            // 
            // btnUcitaj
            // 
            btnUcitaj.Location = new Point(713, 44);
            btnUcitaj.Name = "btnUcitaj";
            btnUcitaj.Size = new Size(75, 23);
            btnUcitaj.TabIndex = 1;
            btnUcitaj.Text = "Ucitaj";
            btnUcitaj.UseVisualStyleBackColor = true;
            btnUcitaj.Click += btnUcitaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 2;
            label1.Text = "Posjete";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(36, 9);
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
            // lblNemaPosjeta
            // 
            lblNemaPosjeta.AutoSize = true;
            lblNemaPosjeta.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNemaPosjeta.Location = new Point(95, 216);
            lblNemaPosjeta.Name = "lblNemaPosjeta";
            lblNemaPosjeta.Size = new Size(0, 32);
            lblNemaPosjeta.TabIndex = 30;
            // 
            // frmPosjete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNemaPosjeta);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(btnUcitaj);
            Controls.Add(dataGridView1);
            Name = "frmPosjete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Posjete";
            Load += frmPosjete_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnUcitaj;
        private Label label1;
        private DataGridViewTextBoxColumn NazivNekretnine;
        private DataGridViewTextBoxColumn korisnikImePrezime;
        private DataGridViewTextBoxColumn DatumPosjete;
        private DataGridViewTextBoxColumn VrijemePosjete;
        private Label label8;
        private Label label7;
        private Label lblNemaPosjeta;
    }
}