namespace eRent.UI
{
    partial class frmNekretninaList
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
            Button btnShowNekretnine;
            dgvNekretnineList = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Lokacija = new DataGridViewTextBoxColumn();
            Popunjena = new DataGridViewCheckBoxColumn();
            Placanja = new DataGridViewButtonColumn();
            Detaljno = new DataGridViewButtonColumn();
            Korisnici = new DataGridViewButtonColumn();
            Posjete = new DataGridViewButtonColumn();
            Odrzavanje = new DataGridViewButtonColumn();
            Obrisi = new DataGridViewButtonColumn();
            label1 = new Label();
            txtSearch = new TextBox();
            btnDodajNovu = new Button();
            btnSveRezervacije = new Button();
            btnDodajKorisnika = new Button();
            btnRejting = new Button();
            btnIzvjestaj = new Button();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            btnShowNekretnine = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNekretnineList).BeginInit();
            SuspendLayout();
            // 
            // btnShowNekretnine
            // 
            btnShowNekretnine.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowNekretnine.Location = new Point(622, 132);
            btnShowNekretnine.Name = "btnShowNekretnine";
            btnShowNekretnine.Size = new Size(87, 25);
            btnShowNekretnine.TabIndex = 1;
            btnShowNekretnine.Text = "Prikazi";
            btnShowNekretnine.UseVisualStyleBackColor = true;
            btnShowNekretnine.Click += btnShowNekretnine_Click;
            // 
            // dgvNekretnineList
            // 
            dgvNekretnineList.AllowUserToAddRows = false;
            dgvNekretnineList.AllowUserToDeleteRows = false;
            dgvNekretnineList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNekretnineList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNekretnineList.Columns.AddRange(new DataGridViewColumn[] { Naziv, Lokacija, Popunjena, Placanja, Detaljno, Korisnici, Posjete, Odrzavanje, Obrisi });
            dgvNekretnineList.Location = new Point(12, 176);
            dgvNekretnineList.MultiSelect = false;
            dgvNekretnineList.Name = "dgvNekretnineList";
            dgvNekretnineList.ReadOnly = true;
            dgvNekretnineList.RowHeadersWidth = 51;
            dgvNekretnineList.RowTemplate.Height = 25;
            dgvNekretnineList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNekretnineList.Size = new Size(1252, 444);
            dgvNekretnineList.TabIndex = 0;
            dgvNekretnineList.CellContentClick += dgvNekretnineList_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "NazivNekretnine";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Lokacija
            // 
            Lokacija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Lokacija.DataPropertyName = "grad";
            Lokacija.HeaderText = "Lokacija";
            Lokacija.MinimumWidth = 6;
            Lokacija.Name = "Lokacija";
            Lokacija.ReadOnly = true;
            // 
            // Popunjena
            // 
            Popunjena.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Popunjena.DataPropertyName = "izdvojena";
            Popunjena.HeaderText = "Izdvojena";
            Popunjena.MinimumWidth = 6;
            Popunjena.Name = "Popunjena";
            Popunjena.ReadOnly = true;
            Popunjena.Width = 65;
            // 
            // Placanja
            // 
            Placanja.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Placanja.HeaderText = "Placanja";
            Placanja.Name = "Placanja";
            Placanja.ReadOnly = true;
            Placanja.Text = "Placanja";
            Placanja.UseColumnTextForButtonValue = true;
            Placanja.Width = 57;
            // 
            // Detaljno
            // 
            Detaljno.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Detaljno.HeaderText = "Detaljno";
            Detaljno.MinimumWidth = 6;
            Detaljno.Name = "Detaljno";
            Detaljno.ReadOnly = true;
            Detaljno.Text = "Detaljno";
            Detaljno.UseColumnTextForButtonValue = true;
            Detaljno.Width = 58;
            // 
            // Korisnici
            // 
            Korisnici.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Korisnici.HeaderText = "Korisnici";
            Korisnici.MinimumWidth = 6;
            Korisnici.Name = "Korisnici";
            Korisnici.ReadOnly = true;
            Korisnici.Text = "Korisnici";
            Korisnici.UseColumnTextForButtonValue = true;
            Korisnici.Width = 58;
            // 
            // Posjete
            // 
            Posjete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Posjete.HeaderText = "Obilasci";
            Posjete.MinimumWidth = 6;
            Posjete.Name = "Posjete";
            Posjete.ReadOnly = true;
            Posjete.Text = "Obilasci";
            Posjete.ToolTipText = "Obilasci";
            Posjete.UseColumnTextForButtonValue = true;
            Posjete.Width = 55;
            // 
            // Odrzavanje
            // 
            Odrzavanje.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Odrzavanje.HeaderText = "Odrzavanje";
            Odrzavanje.MinimumWidth = 6;
            Odrzavanje.Name = "Odrzavanje";
            Odrzavanje.ReadOnly = true;
            Odrzavanje.Text = "Odrzavanje";
            Odrzavanje.UseColumnTextForButtonValue = true;
            Odrzavanje.Width = 73;
            // 
            // Obrisi
            // 
            Obrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Obrisi.HeaderText = "Obrisi";
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Obrisi";
            Obrisi.UseColumnTextForButtonValue = true;
            Obrisi.Width = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 131);
            label1.Name = "label1";
            label1.Size = new Size(215, 25);
            label1.TabIndex = 2;
            label1.Text = "Pretraga svih nekretnina";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(233, 133);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(383, 23);
            txtSearch.TabIndex = 3;
            // 
            // btnDodajNovu
            // 
            btnDodajNovu.BackColor = Color.ForestGreen;
            btnDodajNovu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDodajNovu.ForeColor = SystemColors.HighlightText;
            btnDodajNovu.Location = new Point(1137, 131);
            btnDodajNovu.Name = "btnDodajNovu";
            btnDodajNovu.Size = new Size(127, 35);
            btnDodajNovu.TabIndex = 4;
            btnDodajNovu.Text = "Dodaj Novu";
            btnDodajNovu.UseVisualStyleBackColor = false;
            btnDodajNovu.Click += btnDodajNovu_Click;
            // 
            // btnSveRezervacije
            // 
            btnSveRezervacije.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSveRezervacije.Location = new Point(761, 27);
            btnSveRezervacije.Name = "btnSveRezervacije";
            btnSveRezervacije.Size = new Size(165, 34);
            btnSveRezervacije.TabIndex = 12;
            btnSveRezervacije.Text = "Sve rezervacije";
            btnSveRezervacije.UseVisualStyleBackColor = true;
            btnSveRezervacije.Click += btnSveRezervacije_Click_1;
            // 
            // btnDodajKorisnika
            // 
            btnDodajKorisnika.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDodajKorisnika.Location = new Point(1042, 27);
            btnDodajKorisnika.Margin = new Padding(3, 2, 3, 2);
            btnDodajKorisnika.Name = "btnDodajKorisnika";
            btnDodajKorisnika.Size = new Size(106, 34);
            btnDodajKorisnika.TabIndex = 11;
            btnDodajKorisnika.Text = "Korisnici";
            btnDodajKorisnika.UseVisualStyleBackColor = true;
            btnDodajKorisnika.Click += btnDodajKorisnika_Click_1;
            // 
            // btnRejting
            // 
            btnRejting.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRejting.Location = new Point(932, 27);
            btnRejting.Name = "btnRejting";
            btnRejting.Size = new Size(104, 34);
            btnRejting.TabIndex = 10;
            btnRejting.Text = "Rejting";
            btnRejting.UseVisualStyleBackColor = true;
            btnRejting.Click += btnRejting_Click_1;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIzvjestaj.Location = new Point(1154, 27);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(102, 33);
            btnIzvjestaj.TabIndex = 9;
            btnIzvjestaj.Text = "Izvjestaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 27);
            label2.Name = "label2";
            label2.Size = new Size(87, 37);
            label2.TabIndex = 13;
            label2.Text = "eRent";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.DarkGray;
            progressBar1.Location = new Point(12, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1252, 70);
            progressBar1.TabIndex = 14;
            progressBar1.Value = 100;
            // 
            // frmNekretninaList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 632);
            Controls.Add(label2);
            Controls.Add(btnSveRezervacije);
            Controls.Add(btnDodajKorisnika);
            Controls.Add(btnRejting);
            Controls.Add(btnIzvjestaj);
            Controls.Add(btnDodajNovu);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnShowNekretnine);
            Controls.Add(dgvNekretnineList);
            Controls.Add(progressBar1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmNekretninaList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista svih nekretnina";
            Load += frmNekretninaList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNekretnineList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNekretnineList;
        private Label label1;
        private TextBox txtSearch;
        private DataGridViewCheckBoxColumn izdvojena;
        private Button btnDodajNovu;
        private Button btnSveRezervacije;
        private Button btnDodajKorisnika;
        private Button btnRejting;
        private Button btnIzvjestaj;
        private Label label2;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Lokacija;
        private DataGridViewCheckBoxColumn Popunjena;
        private DataGridViewButtonColumn Placanja;
        private DataGridViewButtonColumn Detaljno;
        private DataGridViewButtonColumn Korisnici;
        private DataGridViewButtonColumn Posjete;
        private DataGridViewButtonColumn Odrzavanje;
        private DataGridViewButtonColumn Obrisi;
        private ProgressBar progressBar1;
    }
}