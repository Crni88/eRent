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
            label1 = new Label();
            dgvKorisniciNekretnina = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            Broj_Telefona = new DataGridViewTextBoxColumn();
            Datum_Useljenja = new DataGridViewTextBoxColumn();
            Datum_Iseljenja = new DataGridViewTextBoxColumn();
            btnUcitajKorisnike = new Button();
            lblNemaKorisnika = new Label();
            btnNazad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKorisniciNekretnina).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 31;
            // 
            // dgvKorisniciNekretnina
            // 
            dgvKorisniciNekretnina.AllowUserToAddRows = false;
            dgvKorisniciNekretnina.AllowUserToDeleteRows = false;
            dgvKorisniciNekretnina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisniciNekretnina.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, Broj_Telefona, Datum_Useljenja, Datum_Iseljenja });
            dgvKorisniciNekretnina.Location = new Point(12, 72);
            dgvKorisniciNekretnina.MultiSelect = false;
            dgvKorisniciNekretnina.Name = "dgvKorisniciNekretnina";
            dgvKorisniciNekretnina.ReadOnly = true;
            dgvKorisniciNekretnina.RowHeadersWidth = 51;
            dgvKorisniciNekretnina.RowTemplate.Height = 25;
            dgvKorisniciNekretnina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKorisniciNekretnina.Size = new Size(776, 343);
            dgvKorisniciNekretnina.TabIndex = 2;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "ImeKorisnika";
            Ime.HeaderText = "Ime";
            Ime.MinimumWidth = 6;
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "PrezimeKorisnika";
            Prezime.HeaderText = "Prezime";
            Prezime.MinimumWidth = 6;
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // Broj_Telefona
            // 
            Broj_Telefona.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Broj_Telefona.DataPropertyName = "BrojTelefona";
            Broj_Telefona.HeaderText = "Broj telefona";
            Broj_Telefona.MinimumWidth = 6;
            Broj_Telefona.Name = "Broj_Telefona";
            Broj_Telefona.ReadOnly = true;
            // 
            // Datum_Useljenja
            // 
            Datum_Useljenja.DataPropertyName = "DatumUseljenja";
            Datum_Useljenja.HeaderText = "Datum Useljenja";
            Datum_Useljenja.MinimumWidth = 6;
            Datum_Useljenja.Name = "Datum_Useljenja";
            Datum_Useljenja.ReadOnly = true;
            Datum_Useljenja.Width = 125;
            // 
            // Datum_Iseljenja
            // 
            Datum_Iseljenja.DataPropertyName = "DatumIseljenja";
            Datum_Iseljenja.HeaderText = "Datum Iseljenja";
            Datum_Iseljenja.MinimumWidth = 6;
            Datum_Iseljenja.Name = "Datum_Iseljenja";
            Datum_Iseljenja.ReadOnly = true;
            Datum_Iseljenja.Width = 125;
            // 
            // btnUcitajKorisnike
            // 
            btnUcitajKorisnike.Location = new Point(706, 45);
            btnUcitajKorisnike.Margin = new Padding(3, 2, 3, 2);
            btnUcitajKorisnike.Name = "btnUcitajKorisnike";
            btnUcitajKorisnike.Size = new Size(82, 22);
            btnUcitajKorisnike.TabIndex = 3;
            btnUcitajKorisnike.Text = "Ucitaj";
            btnUcitajKorisnike.UseVisualStyleBackColor = true;
            btnUcitajKorisnike.Click += btnUcitajKorisnike_Click;
            // 
            // lblNemaKorisnika
            // 
            lblNemaKorisnika.AutoSize = true;
            lblNemaKorisnika.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNemaKorisnika.Location = new Point(84, 225);
            lblNemaKorisnika.Name = "lblNemaKorisnika";
            lblNemaKorisnika.Size = new Size(628, 40);
            lblNemaKorisnika.TabIndex = 6;
            lblNemaKorisnika.Text = "Nekretnina nema jos potvrđenih rezervacija.";
            // 
            // btnNazad
            // 
            btnNazad.Location = new Point(12, 12);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(75, 23);
            btnNazad.TabIndex = 30;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            btnNazad.Click += btnNazad_Click;
            // 
            // frmKorisniciNekretnina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(btnNazad);
            Controls.Add(lblNemaKorisnika);
            Controls.Add(btnUcitajKorisnike);
            Controls.Add(dgvKorisniciNekretnina);
            Controls.Add(label1);
            Name = "frmKorisniciNekretnina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled korisnika";
            Load += frmKorisniciNekretnina_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKorisniciNekretnina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvKorisniciNekretnina;
        private Button btnUcitajKorisnike;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn Broj_Telefona;
        private DataGridViewTextBoxColumn Datum_Useljenja;
        private DataGridViewTextBoxColumn Datum_Iseljenja;
        private Label lblNemaKorisnika;
        private Button btnNazad;
    }
}