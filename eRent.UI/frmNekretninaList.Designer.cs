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
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popunjena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Aktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Pregled = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Rezervacije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Detaljno = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Korisnici = new System.Windows.Forms.DataGridViewButtonColumn();
            btnShowNekretnine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNekretnineList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowNekretnine
            // 
            btnShowNekretnine.Location = new System.Drawing.Point(543, 15);
            btnShowNekretnine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnShowNekretnine.Name = "btnShowNekretnine";
            btnShowNekretnine.Size = new System.Drawing.Size(86, 31);
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
            this.Aktivna,
            this.Pregled,
            this.Rezervacije,
            this.Detaljno,
            this.Korisnici});
            this.dgvNekretnineList.Location = new System.Drawing.Point(11, 52);
            this.dgvNekretnineList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNekretnineList.MultiSelect = false;
            this.dgvNekretnineList.Name = "dgvNekretnineList";
            this.dgvNekretnineList.RowHeadersWidth = 51;
            this.dgvNekretnineList.RowTemplate.Height = 25;
            this.dgvNekretnineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNekretnineList.Size = new System.Drawing.Size(1158, 592);
            this.dgvNekretnineList.TabIndex = 0;
            this.dgvNekretnineList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNekretnineList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretrga svih nekretnina";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(165, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(371, 27);
            this.txtSearch.TabIndex = 3;
            // 
            // btnDodajNovu
            // 
            this.btnDodajNovu.Location = new System.Drawing.Point(1082, 13);
            this.btnDodajNovu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajNovu.Name = "btnDodajNovu";
            this.btnDodajNovu.Size = new System.Drawing.Size(86, 31);
            this.btnDodajNovu.TabIndex = 4;
            this.btnDodajNovu.Text = "Dodaj Novu";
            this.btnDodajNovu.UseVisualStyleBackColor = true;
            this.btnDodajNovu.Click += new System.EventHandler(this.btnDodajNovu_Click);
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
            // Aktivna
            // 
            this.Aktivna.DataPropertyName = "izdvojena";
            this.Aktivna.HeaderText = "Aktivna";
            this.Aktivna.MinimumWidth = 6;
            this.Aktivna.Name = "Aktivna";
            // 
            // Pregled
            // 
            this.Pregled.HeaderText = "Pregled";
            this.Pregled.MinimumWidth = 6;
            this.Pregled.Name = "Pregled";
            this.Pregled.Text = "Pregled";
            this.Pregled.UseColumnTextForButtonValue = true;
            // 
            // Rezervacije
            // 
            this.Rezervacije.HeaderText = "Rezervacije";
            this.Rezervacije.MinimumWidth = 6;
            this.Rezervacije.Name = "Rezervacije";
            this.Rezervacije.Text = "Rezervacije";
            this.Rezervacije.UseColumnTextForButtonValue = true;
            // 
            // Detaljno
            // 
            this.Detaljno.HeaderText = "Detaljno";
            this.Detaljno.MinimumWidth = 6;
            this.Detaljno.Name = "Detaljno";
            this.Detaljno.Text = "Detaljno";
            this.Detaljno.UseColumnTextForButtonValue = true;
            // 
            // Korisnici
            // 
            this.Korisnici.HeaderText = "Korisnici";
            this.Korisnici.MinimumWidth = 6;
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Text = "Korisnici";
            this.Korisnici.UseColumnTextForButtonValue = true;
            // 
            // frmNekretninaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 660);
            this.Controls.Add(this.btnDodajNovu);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnShowNekretnine);
            this.Controls.Add(this.dgvNekretnineList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNekretninaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNekretninaList";
            this.Load += new System.EventHandler(this.frmNekretninaList_Load);
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
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Lokacija;
        private DataGridViewCheckBoxColumn Popunjena;
        private DataGridViewCheckBoxColumn Aktivna;
        private DataGridViewButtonColumn Pregled;
        private DataGridViewButtonColumn Rezervacije;
        private DataGridViewButtonColumn Detaljno;
        private DataGridViewButtonColumn Korisnici;
    }
}