namespace eRent.UI
{
    partial class frmSveRezervacije
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
            dgvSveRezervacije = new DataGridView();
            btnUcitaj = new Button();
            cbStatus = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnNazad = new Button();
            ImePrezime = new DataGridViewTextBoxColumn();
            brojTelefona = new DataGridViewTextBoxColumn();
            Nazivnekretnine = new DataGridViewTextBoxColumn();
            DatumPocetka = new DataGridViewTextBoxColumn();
            DatumKraja = new DataGridViewTextBoxColumn();
            Odobrena = new DataGridViewCheckBoxColumn();
            Odobri = new DataGridViewButtonColumn();
            Odbij = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSveRezervacije).BeginInit();
            SuspendLayout();
            // 
            // dgvSveRezervacije
            // 
            dgvSveRezervacije.AllowUserToAddRows = false;
            dgvSveRezervacije.AllowUserToDeleteRows = false;
            dgvSveRezervacije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSveRezervacije.Columns.AddRange(new DataGridViewColumn[] { ImePrezime, brojTelefona, Nazivnekretnine, DatumPocetka, DatumKraja, Odobrena, Odobri, Odbij });
            dgvSveRezervacije.Location = new Point(12, 73);
            dgvSveRezervacije.Name = "dgvSveRezervacije";
            dgvSveRezervacije.ReadOnly = true;
            dgvSveRezervacije.RowTemplate.Height = 25;
            dgvSveRezervacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSveRezervacije.Size = new Size(1108, 441);
            dgvSveRezervacije.TabIndex = 0;
            dgvSveRezervacije.CellContentClick += dgvSveRezervacije_CellContentClick;
            // 
            // btnUcitaj
            // 
            btnUcitaj.Location = new Point(1045, 44);
            btnUcitaj.Name = "btnUcitaj";
            btnUcitaj.Size = new Size(75, 23);
            btnUcitaj.TabIndex = 1;
            btnUcitaj.Text = "Ucitaj";
            btnUcitaj.UseVisualStyleBackColor = true;
            btnUcitaj.Click += btnUcitaj_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(797, 44);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(121, 23);
            cbStatus.TabIndex = 2;
            cbStatus.SelectedIndexChanged += cbStatus_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 3;
            label1.Text = "Sve rezervacije";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(752, 48);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Status";
            // 
            // btnNazad
            // 
            btnNazad.Location = new Point(12, 12);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(75, 23);
            btnNazad.TabIndex = 32;
            btnNazad.Text = "<- Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            btnNazad.Click += btnNazad_Click;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // brojTelefona
            // 
            brojTelefona.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            brojTelefona.DataPropertyName = "brojTelefona";
            brojTelefona.HeaderText = "Email";
            brojTelefona.Name = "brojTelefona";
            brojTelefona.ReadOnly = true;
            // 
            // Nazivnekretnine
            // 
            Nazivnekretnine.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nazivnekretnine.DataPropertyName = "Nazivnekretnine";
            Nazivnekretnine.HeaderText = "Naziv Nekretnine";
            Nazivnekretnine.Name = "Nazivnekretnine";
            Nazivnekretnine.ReadOnly = true;
            // 
            // DatumPocetka
            // 
            DatumPocetka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPocetka.DataPropertyName = "DatumPocetka";
            DatumPocetka.HeaderText = "Datum Pocetka";
            DatumPocetka.Name = "DatumPocetka";
            DatumPocetka.ReadOnly = true;
            // 
            // DatumKraja
            // 
            DatumKraja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumKraja.DataPropertyName = "DatumKraja";
            DatumKraja.HeaderText = "Datum Kraja";
            DatumKraja.Name = "DatumKraja";
            DatumKraja.ReadOnly = true;
            // 
            // Odobrena
            // 
            Odobrena.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Odobrena.DataPropertyName = "Odobrena";
            Odobrena.HeaderText = "Odobrena";
            Odobrena.Name = "Odobrena";
            Odobrena.ReadOnly = true;
            Odobrena.Width = 66;
            // 
            // Odobri
            // 
            Odobri.HeaderText = "Odobri";
            Odobri.Name = "Odobri";
            Odobri.ReadOnly = true;
            Odobri.Text = "Odobri";
            Odobri.UseColumnTextForButtonValue = true;
            // 
            // Odbij
            // 
            Odbij.HeaderText = "Odbij";
            Odbij.Name = "Odbij";
            Odbij.ReadOnly = true;
            Odbij.Text = "Odbij";
            Odbij.UseColumnTextForButtonValue = true;
            // 
            // frmSveRezervacije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 526);
            Controls.Add(btnNazad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbStatus);
            Controls.Add(btnUcitaj);
            Controls.Add(dgvSveRezervacije);
            Name = "frmSveRezervacije";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sve rezervacije";
            Load += frmSveRezervacije_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSveRezervacije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSveRezervacije;
        private Button btnUcitaj;
        private ComboBox cbStatus;
        private Label label1;
        private Label label2;
        private Button btnNazad;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn brojTelefona;
        private DataGridViewTextBoxColumn Nazivnekretnine;
        private DataGridViewTextBoxColumn DatumPocetka;
        private DataGridViewTextBoxColumn DatumKraja;
        private DataGridViewCheckBoxColumn Odobrena;
        private DataGridViewButtonColumn Odobri;
        private DataGridViewButtonColumn Odbij;
    }
}