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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.korsnikIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikPrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUcitajKorisnike = new System.Windows.Forms.Button();
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.korsnikIme,
            this.korisnikPrezime,
            this.email,
            this.username});
            this.dgvKorisnici.Location = new System.Drawing.Point(12, 64);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowHeadersWidth = 51;
            this.dgvKorisnici.RowTemplate.Height = 29;
            this.dgvKorisnici.Size = new System.Drawing.Size(776, 374);
            this.dgvKorisnici.TabIndex = 0;
            // 
            // korsnikIme
            // 
            this.korsnikIme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.korsnikIme.DataPropertyName = "korsnikIme";
            this.korsnikIme.HeaderText = "Korisnik Ime";
            this.korsnikIme.MinimumWidth = 6;
            this.korsnikIme.Name = "korsnikIme";
            this.korsnikIme.ReadOnly = true;
            // 
            // korisnikPrezime
            // 
            this.korisnikPrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.korisnikPrezime.DataPropertyName = "korisnikPrezime";
            this.korisnikPrezime.HeaderText = "Korisnik Prezime";
            this.korisnikPrezime.MinimumWidth = 6;
            this.korisnikPrezime.Name = "korisnikPrezime";
            this.korisnikPrezime.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // btnUcitajKorisnike
            // 
            this.btnUcitajKorisnike.Location = new System.Drawing.Point(12, 12);
            this.btnUcitajKorisnike.Name = "btnUcitajKorisnike";
            this.btnUcitajKorisnike.Size = new System.Drawing.Size(94, 29);
            this.btnUcitajKorisnike.TabIndex = 1;
            this.btnUcitajKorisnike.Text = "Ucitaj";
            this.btnUcitajKorisnike.UseVisualStyleBackColor = true;
            this.btnUcitajKorisnike.Click += new System.EventHandler(this.btnUcitajKorisnike_Click);
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Location = new System.Drawing.Point(694, 12);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(94, 29);
            this.btnDodajKorisnika.TabIndex = 2;
            this.btnDodajKorisnika.Text = "Dodaj";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // frmSviKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.btnUcitajKorisnike);
            this.Controls.Add(this.dgvKorisnici);
            this.Name = "frmSviKorisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Svi korisnici";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvKorisnici;
        private Button btnUcitajKorisnike;
        private Button btnDodajKorisnika;
        private DataGridViewTextBoxColumn korsnikIme;
        private DataGridViewTextBoxColumn korisnikPrezime;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn username;
    }
}