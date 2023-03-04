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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.Ime_Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj_Telefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_Pocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_Kraja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odobrena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Odobri = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLoadRezervacije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervacije";
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime_Prezime,
            this.Broj_Telefona,
            this.Datum_Pocetka,
            this.Datum_Kraja,
            this.Odobrena,
            this.Odobri});
            this.dgvRezervacije.Location = new System.Drawing.Point(12, 42);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.RowTemplate.Height = 25;
            this.dgvRezervacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRezervacije.Size = new System.Drawing.Size(776, 396);
            this.dgvRezervacije.TabIndex = 1;
            this.dgvRezervacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervacije_CellContentClick);
            // 
            // Ime_Prezime
            // 
            this.Ime_Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime_Prezime.DataPropertyName = "ImePrezime";
            this.Ime_Prezime.HeaderText = "Ime i prezime";
            this.Ime_Prezime.Name = "Ime_Prezime";
            this.Ime_Prezime.ReadOnly = true;
            // 
            // Broj_Telefona
            // 
            this.Broj_Telefona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Broj_Telefona.DataPropertyName = "BrojTelefona";
            this.Broj_Telefona.HeaderText = "Broj Telefona";
            this.Broj_Telefona.Name = "Broj_Telefona";
            this.Broj_Telefona.ReadOnly = true;
            // 
            // Datum_Pocetka
            // 
            this.Datum_Pocetka.DataPropertyName = "DatumPocetka";
            this.Datum_Pocetka.HeaderText = "Datum Pocetka";
            this.Datum_Pocetka.Name = "Datum_Pocetka";
            this.Datum_Pocetka.ReadOnly = true;
            // 
            // Datum_Kraja
            // 
            this.Datum_Kraja.DataPropertyName = "DatumKraja";
            this.Datum_Kraja.HeaderText = "Datum Kraja";
            this.Datum_Kraja.Name = "Datum_Kraja";
            this.Datum_Kraja.ReadOnly = true;
            // 
            // Odobrena
            // 
            this.Odobrena.DataPropertyName = "Odobrena";
            this.Odobrena.HeaderText = "Odobrena";
            this.Odobrena.Name = "Odobrena";
            this.Odobrena.ReadOnly = true;
            // 
            // Odobri
            // 
            this.Odobri.HeaderText = "Odobri";
            this.Odobri.Name = "Odobri";
            this.Odobri.ReadOnly = true;
            this.Odobri.Text = "Odobri";
            this.Odobri.UseColumnTextForButtonValue = true;
            // 
            // btnLoadRezervacije
            // 
            this.btnLoadRezervacije.Location = new System.Drawing.Point(713, 9);
            this.btnLoadRezervacije.Name = "btnLoadRezervacije";
            this.btnLoadRezervacije.Size = new System.Drawing.Size(75, 23);
            this.btnLoadRezervacije.TabIndex = 2;
            this.btnLoadRezervacije.Text = "Ucitaj";
            this.btnLoadRezervacije.UseVisualStyleBackColor = true;
            this.btnLoadRezervacije.Click += new System.EventHandler(this.btnLoadRezervacije_Click);
            // 
            // frmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadRezervacije);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.label1);
            this.Name = "frmRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervacije";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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