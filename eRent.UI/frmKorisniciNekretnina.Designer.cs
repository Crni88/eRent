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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKorisniciNekretnina = new System.Windows.Forms.DataGridView();
            this.btnUcitajKorisnike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciNekretnina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled korisnika";
            // 
            // dgvKorisniciNekretnina
            // 
            this.dgvKorisniciNekretnina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisniciNekretnina.Location = new System.Drawing.Point(14, 51);
            this.dgvKorisniciNekretnina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKorisniciNekretnina.Name = "dgvKorisniciNekretnina";
            this.dgvKorisniciNekretnina.RowHeadersWidth = 51;
            this.dgvKorisniciNekretnina.RowTemplate.Height = 25;
            this.dgvKorisniciNekretnina.Size = new System.Drawing.Size(887, 533);
            this.dgvKorisniciNekretnina.TabIndex = 2;
            // 
            // btnUcitajKorisnike
            // 
            this.btnUcitajKorisnike.Location = new System.Drawing.Point(142, 12);
            this.btnUcitajKorisnike.Name = "btnUcitajKorisnike";
            this.btnUcitajKorisnike.Size = new System.Drawing.Size(94, 29);
            this.btnUcitajKorisnike.TabIndex = 3;
            this.btnUcitajKorisnike.Text = "Ucitaj";
            this.btnUcitajKorisnike.UseVisualStyleBackColor = true;
            this.btnUcitajKorisnike.Click += new System.EventHandler(this.btnUcitajKorisnike_Click);
            // 
            // frmKorisniciNekretnina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnUcitajKorisnike);
            this.Controls.Add(this.dgvKorisniciNekretnina);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmKorisniciNekretnina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled korisnika";
            this.Load += new System.EventHandler(this.frmKorisniciNekretnina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciNekretnina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvKorisniciNekretnina;
        private Button btnUcitajKorisnike;
    }
}