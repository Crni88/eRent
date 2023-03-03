namespace eRent.UI
{
    partial class frmRejting
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
            this.dgvRejting = new System.Windows.Forms.DataGridView();
            this.Nekretnina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rejting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejting)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRejting
            // 
            this.dgvRejting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRejting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nekretnina,
            this.Korisnik,
            this.Rejting,
            this.Komentar});
            this.dgvRejting.Location = new System.Drawing.Point(12, 36);
            this.dgvRejting.Name = "dgvRejting";
            this.dgvRejting.RowTemplate.Height = 25;
            this.dgvRejting.Size = new System.Drawing.Size(776, 402);
            this.dgvRejting.TabIndex = 0;
            // 
            // Nekretnina
            // 
            this.Nekretnina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nekretnina.DataPropertyName = "Nekretnina";
            this.Nekretnina.HeaderText = "Nekretnina";
            this.Nekretnina.Name = "Nekretnina";
            // 
            // Korisnik
            // 
            this.Korisnik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Korisnik.DataPropertyName = "ImePrezime";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            // 
            // Rejting
            // 
            this.Rejting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Rejting.DataPropertyName = "Rejting1";
            this.Rejting.HeaderText = "Rejting";
            this.Rejting.Name = "Rejting";
            this.Rejting.Width = 69;
            // 
            // Komentar
            // 
            this.Komentar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Komentar.DataPropertyName = "Komentar";
            this.Komentar.HeaderText = "Komentar";
            this.Komentar.Name = "Komentar";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(713, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Ucitaj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rejting";
            // 
            // frmRejting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvRejting);
            this.Name = "frmRejting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejting";
            this.Load += new System.EventHandler(this.frmRejting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvRejting;
        private Button btnLoad;
        private DataGridViewTextBoxColumn Nekretnina;
        private DataGridViewTextBoxColumn Korisnik;
        private DataGridViewTextBoxColumn Rejting;
        private DataGridViewTextBoxColumn Komentar;
        private Label label1;
    }
}