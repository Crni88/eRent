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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NazivNekretnine, korisnikImePrezime, DatumPosjete, VrijemePosjete });
            dataGridView1.Location = new Point(12, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 384);
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
            btnUcitaj.Location = new Point(713, 16);
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 30);
            label1.TabIndex = 2;
            label1.Text = "Posjete";
            // 
            // frmPosjete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnUcitaj);
            Controls.Add(dataGridView1);
            Name = "frmPosjete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Posjete";
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
    }
}