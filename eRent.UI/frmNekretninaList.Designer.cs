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
            System.Windows.Forms.Button btnShowNekretnine;
            this.dgvNekretnineList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDodajNovu = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.btnRejting = new System.Windows.Forms.Button();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popunjena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Rezervacije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Detaljno = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Korisnici = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Posjete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Odrzavanje = new System.Windows.Forms.DataGridViewButtonColumn();
            btnShowNekretnine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNekretnineList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowNekretnine
            // 
            btnShowNekretnine.Location = new System.Drawing.Point(484, 10);
            btnShowNekretnine.Name = "btnShowNekretnine";
            btnShowNekretnine.Size = new System.Drawing.Size(75, 23);
            btnShowNekretnine.TabIndex = 1;
            btnShowNekretnine.Text = "Show";
            btnShowNekretnine.UseVisualStyleBackColor = true;
            btnShowNekretnine.Click += new System.EventHandler(this.btnShowNekretnine_Click);
            // 
            // dgvNekretnineList
            // 
            this.dgvNekretnineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNekretnineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNekretnineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Lokacija,
            this.Popunjena,
            this.Rezervacije,
            this.Detaljno,
            this.Korisnici,
            this.Posjete,
            this.Odrzavanje});
            this.dgvNekretnineList.Location = new System.Drawing.Point(9, 45);
            this.dgvNekretnineList.MultiSelect = false;
            this.dgvNekretnineList.Name = "dgvNekretnineList";
            this.dgvNekretnineList.RowHeadersWidth = 51;
            this.dgvNekretnineList.RowTemplate.Height = 25;
            this.dgvNekretnineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNekretnineList.Size = new System.Drawing.Size(1013, 444);
            this.dgvNekretnineList.TabIndex = 0;
            this.dgvNekretnineList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNekretnineList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretrga svih nekretnina";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(154, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 23);
            this.txtSearch.TabIndex = 3;
            // 
            // btnDodajNovu
            // 
            this.btnDodajNovu.Location = new System.Drawing.Point(947, 10);
            this.btnDodajNovu.Name = "btnDodajNovu";
            this.btnDodajNovu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajNovu.TabIndex = 4;
            this.btnDodajNovu.Text = "Dodaj Novu";
            this.btnDodajNovu.UseVisualStyleBackColor = true;
            this.btnDodajNovu.Click += new System.EventHandler(this.btnDodajNovu_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(948, 495);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzvjestaj.TabIndex = 5;
            this.btnIzvjestaj.Text = "Izvjestaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // btnRejting
            // 
            this.btnRejting.Location = new System.Drawing.Point(12, 495);
            this.btnRejting.Name = "btnRejting";
            this.btnRejting.Size = new System.Drawing.Size(75, 23);
            this.btnRejting.TabIndex = 6;
            this.btnRejting.Text = "Rejting";
            this.btnRejting.UseVisualStyleBackColor = true;
            this.btnRejting.Click += new System.EventHandler(this.btnRejting_Click);
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "NazivNekretnine";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            // 
            // Lokacija
            // 
            this.Lokacija.DataPropertyName = "grad";
            this.Lokacija.HeaderText = "Lokacija";
            this.Lokacija.MinimumWidth = 6;
            this.Lokacija.Name = "Lokacija";
            // 
            // Popunjena
            // 
            this.Popunjena.DataPropertyName = "popunjena";
            this.Popunjena.HeaderText = "Popunjena";
            this.Popunjena.MinimumWidth = 6;
            this.Popunjena.Name = "Popunjena";
            // 
            // Rezervacije
            // 
            this.Rezervacije.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Rezervacije.HeaderText = "Rezervacije";
            this.Rezervacije.MinimumWidth = 6;
            this.Rezervacije.Name = "Rezervacije";
            this.Rezervacije.Text = "Rezervacije";
            this.Rezervacije.UseColumnTextForButtonValue = true;
            this.Rezervacije.Width = 71;
            // 
            // Detaljno
            // 
            this.Detaljno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Detaljno.HeaderText = "Detaljno";
            this.Detaljno.MinimumWidth = 6;
            this.Detaljno.Name = "Detaljno";
            this.Detaljno.Text = "Detaljno";
            this.Detaljno.UseColumnTextForButtonValue = true;
            this.Detaljno.Width = 57;
            // 
            // Korisnici
            // 
            this.Korisnici.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Korisnici.HeaderText = "Korisnici";
            this.Korisnici.MinimumWidth = 6;
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Text = "Korisnici";
            this.Korisnici.UseColumnTextForButtonValue = true;
            this.Korisnici.Width = 58;
            // 
            // Posjete
            // 
            this.Posjete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Posjete.HeaderText = "Posjete";
            this.Posjete.MinimumWidth = 6;
            this.Posjete.Name = "Posjete";
            this.Posjete.Text = "Posjete";
            this.Posjete.ToolTipText = "Posjete";
            this.Posjete.UseColumnTextForButtonValue = true;
            this.Posjete.Width = 51;
            // 
            // Odrzavanje
            // 
            this.Odrzavanje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Odrzavanje.HeaderText = "Odrzavanje";
            this.Odrzavanje.MinimumWidth = 6;
            this.Odrzavanje.Name = "Odrzavanje";
            this.Odrzavanje.Text = "Odrzavanje";
            this.Odrzavanje.UseColumnTextForButtonValue = true;
            this.Odrzavanje.Width = 72;
            // 
            // frmNekretninaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 530);
            this.Controls.Add(this.btnRejting);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.btnDodajNovu);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnShowNekretnine);
            this.Controls.Add(this.dgvNekretnineList);
            this.Name = "frmNekretninaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista svih nekretnina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNekretnineList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}