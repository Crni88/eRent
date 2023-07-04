namespace eRent.UI
{
    partial class frmSviKorisnici
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
            dgvKorisnici = new DataGridView();
            korsnikIme = new DataGridViewTextBoxColumn();
            korisnikPrezime = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            Uredi = new DataGridViewButtonColumn();
            Obrisi = new DataGridViewButtonColumn();
            btnUcitajKorisnike = new Button();
            btnDodajKorisnika = new Button();
            txtUsername = new TextBox();
            lblUsername = new Label();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).BeginInit();
            SuspendLayout();
            // 
            // dgvKorisnici
            // 
            dgvKorisnici.AllowUserToAddRows = false;
            dgvKorisnici.AllowUserToDeleteRows = false;
            dgvKorisnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisnici.Columns.AddRange(new DataGridViewColumn[] { korsnikIme, korisnikPrezime, email, username, Uredi, Obrisi });
            dgvKorisnici.Location = new Point(10, 75);
            dgvKorisnici.Margin = new Padding(3, 2, 3, 2);
            dgvKorisnici.Name = "dgvKorisnici";
            dgvKorisnici.ReadOnly = true;
            dgvKorisnici.RowHeadersWidth = 51;
            dgvKorisnici.RowTemplate.Height = 29;
            dgvKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKorisnici.Size = new Size(679, 253);
            dgvKorisnici.TabIndex = 0;
            dgvKorisnici.CellContentClick += dgvKorisnici_CellContentClick;
            // 
            // korsnikIme
            // 
            korsnikIme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            korsnikIme.DataPropertyName = "korsnikIme";
            korsnikIme.HeaderText = "Korisnik Ime";
            korsnikIme.MinimumWidth = 6;
            korsnikIme.Name = "korsnikIme";
            korsnikIme.ReadOnly = true;
            // 
            // korisnikPrezime
            // 
            korisnikPrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            korisnikPrezime.DataPropertyName = "korisnikPrezime";
            korisnikPrezime.HeaderText = "Korisnik Prezime";
            korisnikPrezime.MinimumWidth = 6;
            korisnikPrezime.Name = "korisnikPrezime";
            korisnikPrezime.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // username
            // 
            username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            username.DataPropertyName = "username";
            username.HeaderText = "Username";
            username.MinimumWidth = 6;
            username.Name = "username";
            username.ReadOnly = true;
            // 
            // Uredi
            // 
            Uredi.HeaderText = "Uredi";
            Uredi.Name = "Uredi";
            Uredi.ReadOnly = true;
            Uredi.Text = "Uredi";
            Uredi.ToolTipText = "Uredi";
            Uredi.UseColumnTextForButtonValue = true;
            // 
            // Obrisi
            // 
            Obrisi.HeaderText = "Obrisi";
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Obrisi";
            Obrisi.UseColumnTextForButtonValue = true;
            // 
            // btnUcitajKorisnike
            // 
            btnUcitajKorisnike.Location = new Point(509, 39);
            btnUcitajKorisnike.Margin = new Padding(3, 2, 3, 2);
            btnUcitajKorisnike.Name = "btnUcitajKorisnike";
            btnUcitajKorisnike.Size = new Size(91, 28);
            btnUcitajKorisnike.TabIndex = 1;
            btnUcitajKorisnike.Text = "Ucitaj";
            btnUcitajKorisnike.UseVisualStyleBackColor = true;
            btnUcitajKorisnike.Click += btnUcitajKorisnike_Click;
            // 
            // btnDodajKorisnika
            // 
            btnDodajKorisnika.Location = new Point(606, 36);
            btnDodajKorisnika.Margin = new Padding(3, 2, 3, 2);
            btnDodajKorisnika.Name = "btnDodajKorisnika";
            btnDodajKorisnika.Size = new Size(82, 35);
            btnDodajKorisnika.TabIndex = 2;
            btnDodajKorisnika.Text = "Dodaj";
            btnDodajKorisnika.UseVisualStyleBackColor = true;
            btnDodajKorisnika.Click += btnDodajKorisnika_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(335, 40);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(168, 23);
            txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(293, 41);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(36, 21);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Ime";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(33, 9);
            label8.Name = "label8";
            label8.Size = new Size(59, 21);
            label8.TabIndex = 31;
            label8.Text = "Nazad";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 8);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 30;
            label7.Text = "<-";
            label7.Click += label7_Click;
            // 
            // frmSviKorisnici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(btnDodajKorisnika);
            Controls.Add(btnUcitajKorisnike);
            Controls.Add(dgvKorisnici);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmSviKorisnici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Svi korisnici";
            Load += frmSviKorisnici_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKorisnici;
        private Button btnUcitajKorisnike;
        private Button btnDodajKorisnika;
        private DataGridViewTextBoxColumn korsnikIme;
        private DataGridViewTextBoxColumn korisnikPrezime;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn username;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label label8;
        private Label label7;
    }
}