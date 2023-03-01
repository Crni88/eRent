namespace eRent.UI
{
    partial class frmKorisniciNekretnina
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
            this.dgvKorisniciNekretnina = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj_Telefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_Useljenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum_Iseljenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUcitajKorisnike = new System.Windows.Forms.Button();
            this.btnDodajNovogKorisnika = new System.Windows.Forms.Button();
            this.btnZahtjevZaPlacanje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciNekretnina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled korisnika";
            // 
            // dgvKorisniciNekretnina
            // 
            this.dgvKorisniciNekretnina.AllowUserToAddRows = false;
            this.dgvKorisniciNekretnina.AllowUserToDeleteRows = false;
            this.dgvKorisniciNekretnina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisniciNekretnina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Broj_Telefona,
            this.Datum_Useljenja,
            this.Datum_Iseljenja,
            this.Uredi});
            this.dgvKorisniciNekretnina.Location = new System.Drawing.Point(14, 51);
            this.dgvKorisniciNekretnina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKorisniciNekretnina.MultiSelect = false;
            this.dgvKorisniciNekretnina.Name = "dgvKorisniciNekretnina";
            this.dgvKorisniciNekretnina.ReadOnly = true;
            this.dgvKorisniciNekretnina.RowHeadersWidth = 51;
            this.dgvKorisniciNekretnina.RowTemplate.Height = 25;
            this.dgvKorisniciNekretnina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisniciNekretnina.Size = new System.Drawing.Size(887, 503);
            this.dgvKorisniciNekretnina.TabIndex = 2;
            this.dgvKorisniciNekretnina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisniciNekretnina_CellContentClick);
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "ImeKorisnika";
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prezime.DataPropertyName = "PrezimeKorisnika";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Broj_Telefona
            // 
            this.Broj_Telefona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Broj_Telefona.DataPropertyName = "BrojTelefona";
            this.Broj_Telefona.HeaderText = "Broj telefona";
            this.Broj_Telefona.MinimumWidth = 6;
            this.Broj_Telefona.Name = "Broj_Telefona";
            this.Broj_Telefona.ReadOnly = true;
            // 
            // Datum_Useljenja
            // 
            this.Datum_Useljenja.DataPropertyName = "DatumUseljenja";
            this.Datum_Useljenja.HeaderText = "Datum Useljenja";
            this.Datum_Useljenja.MinimumWidth = 6;
            this.Datum_Useljenja.Name = "Datum_Useljenja";
            this.Datum_Useljenja.ReadOnly = true;
            this.Datum_Useljenja.Width = 125;
            // 
            // Datum_Iseljenja
            // 
            this.Datum_Iseljenja.DataPropertyName = "DatumIseljenja";
            this.Datum_Iseljenja.HeaderText = "Datum Iseljenja";
            this.Datum_Iseljenja.MinimumWidth = 6;
            this.Datum_Iseljenja.Name = "Datum_Iseljenja";
            this.Datum_Iseljenja.ReadOnly = true;
            this.Datum_Iseljenja.Width = 125;
            // 
            // Uredi
            // 
            this.Uredi.HeaderText = "Uredi";
            this.Uredi.MinimumWidth = 6;
            this.Uredi.Name = "Uredi";
            this.Uredi.ReadOnly = true;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            this.Uredi.Width = 125;
            // 
            // btnUcitajKorisnike
            // 
            this.btnUcitajKorisnike.Location = new System.Drawing.Point(142, 12);
            this.btnUcitajKorisnike.Name = "btnUcitajKorisnike";
            this.btnUcitajKorisnike.Size = new System.Drawing.Size(94, 29);
            this.btnUcitajKorisnike.TabIndex = 3;
            this.btnUcitajKorisnike.Text = "Ucitaj";
            this.btnUcitajKorisnike.UseVisualStyleBackColor = true;
            this.btnUcitajKorisnike.Click += new System.EventHandler(this.btnUcitajKorisnike_Click);
            // 
            // btnDodajNovogKorisnika
            // 
            this.btnDodajNovogKorisnika.Location = new System.Drawing.Point(784, 11);
            this.btnDodajNovogKorisnika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajNovogKorisnika.Name = "btnDodajNovogKorisnika";
            this.btnDodajNovogKorisnika.Size = new System.Drawing.Size(117, 31);
            this.btnDodajNovogKorisnika.TabIndex = 4;
            this.btnDodajNovogKorisnika.Text = "Dodaj Novog";
            this.btnDodajNovogKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajNovogKorisnika.Click += new System.EventHandler(this.btnDodajNovogKorisnika_Click);
            // 
            // btnZahtjevZaPlacanje
            // 
            this.btnZahtjevZaPlacanje.Location = new System.Drawing.Point(743, 562);
            this.btnZahtjevZaPlacanje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZahtjevZaPlacanje.Name = "btnZahtjevZaPlacanje";
            this.btnZahtjevZaPlacanje.Size = new System.Drawing.Size(159, 31);
            this.btnZahtjevZaPlacanje.TabIndex = 5;
            this.btnZahtjevZaPlacanje.Text = "Zahtjev za placanje";
            this.btnZahtjevZaPlacanje.UseVisualStyleBackColor = true;
            this.btnZahtjevZaPlacanje.Click += new System.EventHandler(this.btnZahtjevZaPlacanje_Click);
            // 
            // frmKorisniciNekretnina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 604);
            this.Controls.Add(this.btnZahtjevZaPlacanje);
            this.Controls.Add(this.btnDodajNovogKorisnika);
            this.Controls.Add(this.btnUcitajKorisnike);
            this.Controls.Add(this.dgvKorisniciNekretnina);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmKorisniciNekretnina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled korisnika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciNekretnina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvKorisniciNekretnina;
        private Button btnUcitajKorisnike;
        private Button btnDodajNovogKorisnika;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Broj_Telefona;
        private DataGridViewTextBoxColumn Datum_Useljenja;
        private DataGridViewTextBoxColumn Datum_Iseljenja;
        private DataGridViewButtonColumn Uredi;
        private Button btnZahtjevZaPlacanje;
    }
}