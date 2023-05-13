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
            Rezervacije = new DataGridViewButtonColumn();
            Detaljno = new DataGridViewButtonColumn();
            Korisnici = new DataGridViewButtonColumn();
            Posjete = new DataGridViewButtonColumn();
            Odrzavanje = new DataGridViewButtonColumn();
            label1 = new Label();
            txtSearch = new TextBox();
            btnDodajNovu = new Button();
            btnIzvjestaj = new Button();
            btnRejting = new Button();
            btnDodajKorisnika = new Button();
            btnShowNekretnine = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNekretnineList).BeginInit();
            SuspendLayout();
            // 
            // btnShowNekretnine
            // 
            btnShowNekretnine.Location = new Point(554, 16);
            btnShowNekretnine.Margin = new Padding(3, 4, 3, 4);
            btnShowNekretnine.Name = "btnShowNekretnine";
            btnShowNekretnine.Size = new Size(91, 31);
            btnShowNekretnine.TabIndex = 1;
            btnShowNekretnine.Text = "Show";
            btnShowNekretnine.UseVisualStyleBackColor = true;
            btnShowNekretnine.Click += btnShowNekretnine_Click;
            // 
            // dgvNekretnineList
            // 
            dgvNekretnineList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNekretnineList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNekretnineList.Columns.AddRange(new DataGridViewColumn[] { Naziv, Lokacija, Popunjena, Rezervacije, Detaljno, Korisnici, Posjete, Odrzavanje });
            dgvNekretnineList.Location = new Point(10, 60);
            dgvNekretnineList.Margin = new Padding(3, 4, 3, 4);
            dgvNekretnineList.MultiSelect = false;
            dgvNekretnineList.Name = "dgvNekretnineList";
            dgvNekretnineList.RowHeadersWidth = 51;
            dgvNekretnineList.RowTemplate.Height = 25;
            dgvNekretnineList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNekretnineList.Size = new Size(1158, 592);
            dgvNekretnineList.TabIndex = 0;
            dgvNekretnineList.CellContentClick += dgvNekretnineList_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.DataPropertyName = "NazivNekretnine";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            // 
            // Lokacija
            // 
            Lokacija.DataPropertyName = "grad";
            Lokacija.HeaderText = "Lokacija";
            Lokacija.MinimumWidth = 6;
            Lokacija.Name = "Lokacija";
            // 
            // Popunjena
            // 
            Popunjena.DataPropertyName = "popunjena";
            Popunjena.HeaderText = "Popunjena";
            Popunjena.MinimumWidth = 6;
            Popunjena.Name = "Popunjena";
            // 
            // Rezervacije
            // 
            Rezervacije.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Rezervacije.HeaderText = "Rezervacije";
            Rezervacije.MinimumWidth = 6;
            Rezervacije.Name = "Rezervacije";
            Rezervacije.Text = "Rezervacije";
            Rezervacije.UseColumnTextForButtonValue = true;
            Rezervacije.Width = 90;
            // 
            // Detaljno
            // 
            Detaljno.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Detaljno.HeaderText = "Detaljno";
            Detaljno.MinimumWidth = 6;
            Detaljno.Name = "Detaljno";
            Detaljno.Text = "Detaljno";
            Detaljno.UseColumnTextForButtonValue = true;
            Detaljno.Width = 72;
            // 
            // Korisnici
            // 
            Korisnici.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Korisnici.HeaderText = "Korisnici";
            Korisnici.MinimumWidth = 6;
            Korisnici.Name = "Korisnici";
            Korisnici.Text = "Korisnici";
            Korisnici.UseColumnTextForButtonValue = true;
            Korisnici.Width = 71;
            // 
            // Posjete
            // 
            Posjete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Posjete.HeaderText = "Posjete";
            Posjete.MinimumWidth = 6;
            Posjete.Name = "Posjete";
            Posjete.Text = "Posjete";
            Posjete.ToolTipText = "Posjete";
            Posjete.UseColumnTextForButtonValue = true;
            Posjete.Width = 62;
            // 
            // Odrzavanje
            // 
            Odrzavanje.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Odrzavanje.HeaderText = "Odrzavanje";
            Odrzavanje.MinimumWidth = 6;
            Odrzavanje.Name = "Odrzavanje";
            Odrzavanje.Text = "Odrzavanje";
            Odrzavanje.UseColumnTextForButtonValue = true;
            Odrzavanje.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 2;
            label1.Text = "Pretrga svih nekretnina";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(176, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(371, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnDodajNovu
            // 
            btnDodajNovu.Location = new Point(1082, 13);
            btnDodajNovu.Margin = new Padding(3, 4, 3, 4);
            btnDodajNovu.Name = "btnDodajNovu";
            btnDodajNovu.Size = new Size(86, 31);
            btnDodajNovu.TabIndex = 4;
            btnDodajNovu.Text = "Dodaj Novu";
            btnDodajNovu.UseVisualStyleBackColor = true;
            btnDodajNovu.Click += btnDodajNovu_Click;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(1083, 660);
            btnIzvjestaj.Margin = new Padding(3, 4, 3, 4);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(86, 31);
            btnIzvjestaj.TabIndex = 5;
            btnIzvjestaj.Text = "Izvjestaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // btnRejting
            // 
            btnRejting.Location = new Point(14, 660);
            btnRejting.Margin = new Padding(3, 4, 3, 4);
            btnRejting.Name = "btnRejting";
            btnRejting.Size = new Size(86, 31);
            btnRejting.TabIndex = 6;
            btnRejting.Text = "Rejting";
            btnRejting.UseVisualStyleBackColor = true;
            btnRejting.Click += btnRejting_Click;
            // 
            // btnDodajKorisnika
            // 
            btnDodajKorisnika.Location = new Point(139, 659);
            btnDodajKorisnika.Name = "btnDodajKorisnika";
            btnDodajKorisnika.Size = new Size(96, 32);
            btnDodajKorisnika.TabIndex = 7;
            btnDodajKorisnika.Text = "Korisnici";
            btnDodajKorisnika.UseVisualStyleBackColor = true;
            btnDodajKorisnika.Click += btnDodajKorisnika_Click;
            // 
            // frmNekretninaList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 707);
            Controls.Add(btnDodajKorisnika);
            Controls.Add(btnRejting);
            Controls.Add(btnIzvjestaj);
            Controls.Add(btnDodajNovu);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnShowNekretnine);
            Controls.Add(dgvNekretnineList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNekretninaList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista svih nekretnina";
            Load += this.frmNekretninaList_Load;
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
        private Button btnIzvjestaj;
        private Button btnRejting;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Lokacija;
        private DataGridViewCheckBoxColumn Popunjena;
        private DataGridViewButtonColumn Rezervacije;
        private DataGridViewButtonColumn Detaljno;
        private DataGridViewButtonColumn Korisnici;
        private DataGridViewButtonColumn Posjete;
        private DataGridViewButtonColumn Odrzavanje;
        private Button btnDodajKorisnika;
    }
}