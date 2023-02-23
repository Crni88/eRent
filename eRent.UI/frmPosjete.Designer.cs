namespace eRent.UI
{
    partial class frmPosjete
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NazivNekretnine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPosjete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemePosjete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivNekretnine,
            this.korisnikImePrezime,
            this.DatumPosjete,
            this.VrijemePosjete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // NazivNekretnine
            // 
            this.NazivNekretnine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivNekretnine.DataPropertyName = "nazivNekretnine";
            this.NazivNekretnine.HeaderText = "Naziv Nekretnine";
            this.NazivNekretnine.Name = "NazivNekretnine";
            // 
            // korisnikImePrezime
            // 
            this.korisnikImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.korisnikImePrezime.DataPropertyName = "korisnikImePrezime";
            this.korisnikImePrezime.HeaderText = "Ime i prezime";
            this.korisnikImePrezime.Name = "korisnikImePrezime";
            // 
            // DatumPosjete
            // 
            this.DatumPosjete.DataPropertyName = "datumPosjete";
            this.DatumPosjete.HeaderText = "Datum Posjete";
            this.DatumPosjete.Name = "DatumPosjete";
            // 
            // VrijemePosjete
            // 
            this.VrijemePosjete.DataPropertyName = "vrijemePosjete";
            this.VrijemePosjete.HeaderText = "Vrijeme Posjete";
            this.VrijemePosjete.Name = "VrijemePosjete";
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(713, 16);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(75, 23);
            this.btnUcitaj.TabIndex = 1;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Posjete";
            // 
            // frmPosjete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPosjete";
            this.Text = "Posjete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnUcitaj;
        private Label label1;
        private DataGridViewTextBoxColumn NazivNekretnine;
        private DataGridViewTextBoxColumn korisnikImePrezime;
        private DataGridViewTextBoxColumn DatumPosjete;
        private DataGridViewTextBoxColumn VrijemePosjete;
    }
}