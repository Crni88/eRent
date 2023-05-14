namespace eRent.UI
{
    partial class frmRezervacije
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
            label1 = new Label();
            dgvRezervacije = new DataGridView();
            Ime_Prezime = new DataGridViewTextBoxColumn();
            Broj_Telefona = new DataGridViewTextBoxColumn();
            Datum_Pocetka = new DataGridViewTextBoxColumn();
            Datum_Kraja = new DataGridViewTextBoxColumn();
            Odobrena = new DataGridViewCheckBoxColumn();
            Odobri = new DataGridViewButtonColumn();
            btnLoadRezervacije = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRezervacije).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 0;
            label1.Text = "Rezervacije";
            // 
            // dgvRezervacije
            // 
            dgvRezervacije.AllowUserToAddRows = false;
            dgvRezervacije.AllowUserToDeleteRows = false;
            dgvRezervacije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezervacije.Columns.AddRange(new DataGridViewColumn[] { Ime_Prezime, Broj_Telefona, Datum_Pocetka, Datum_Kraja, Odobrena, Odobri });
            dgvRezervacije.Location = new Point(12, 42);
            dgvRezervacije.Name = "dgvRezervacije";
            dgvRezervacije.ReadOnly = true;
            dgvRezervacije.RowTemplate.Height = 25;
            dgvRezervacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRezervacije.Size = new Size(776, 396);
            dgvRezervacije.TabIndex = 1;
            dgvRezervacije.CellContentClick += dgvRezervacije_CellContentClick;
            // 
            // Ime_Prezime
            // 
            Ime_Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime_Prezime.DataPropertyName = "ImePrezime";
            Ime_Prezime.HeaderText = "Ime i prezime";
            Ime_Prezime.Name = "Ime_Prezime";
            Ime_Prezime.ReadOnly = true;
            // 
            // Broj_Telefona
            // 
            Broj_Telefona.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Broj_Telefona.DataPropertyName = "BrojTelefona";
            Broj_Telefona.HeaderText = "Broj Telefona";
            Broj_Telefona.Name = "Broj_Telefona";
            Broj_Telefona.ReadOnly = true;
            // 
            // Datum_Pocetka
            // 
            Datum_Pocetka.DataPropertyName = "DatumPocetka";
            Datum_Pocetka.HeaderText = "Datum Pocetka";
            Datum_Pocetka.Name = "Datum_Pocetka";
            Datum_Pocetka.ReadOnly = true;
            // 
            // Datum_Kraja
            // 
            Datum_Kraja.DataPropertyName = "DatumKraja";
            Datum_Kraja.HeaderText = "Datum Kraja";
            Datum_Kraja.Name = "Datum_Kraja";
            Datum_Kraja.ReadOnly = true;
            // 
            // Odobrena
            // 
            Odobrena.DataPropertyName = "Odobrena";
            Odobrena.HeaderText = "Odobrena";
            Odobrena.Name = "Odobrena";
            Odobrena.ReadOnly = true;
            // 
            // Odobri
            // 
            Odobri.HeaderText = "Odobri";
            Odobri.Name = "Odobri";
            Odobri.ReadOnly = true;
            Odobri.Text = "Odobri";
            Odobri.UseColumnTextForButtonValue = true;
            // 
            // btnLoadRezervacije
            // 
            btnLoadRezervacije.Location = new Point(713, 9);
            btnLoadRezervacije.Name = "btnLoadRezervacije";
            btnLoadRezervacije.Size = new Size(75, 23);
            btnLoadRezervacije.TabIndex = 2;
            btnLoadRezervacije.Text = "Ucitaj";
            btnLoadRezervacije.UseVisualStyleBackColor = true;
            btnLoadRezervacije.Click += btnLoadRezervacije_Click;
            // 
            // frmRezervacije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoadRezervacije);
            Controls.Add(dgvRezervacije);
            Controls.Add(label1);
            Name = "frmRezervacije";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezervacije";
            ((System.ComponentModel.ISupportInitialize)dgvRezervacije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvRezervacije;
        private Button btnRezervacije;
        private Button btnLoadRezervacije;
        private DataGridViewTextBoxColumn Ime_Prezime;
        private DataGridViewTextBoxColumn Broj_Telefona;
        private DataGridViewTextBoxColumn Datum_Pocetka;
        private DataGridViewTextBoxColumn Datum_Kraja;
        private DataGridViewCheckBoxColumn Odobrena;
        private DataGridViewButtonColumn Odobri;
    }
}