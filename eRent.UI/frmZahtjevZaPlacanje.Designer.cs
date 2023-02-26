namespace eRent.UI
{
    partial class frmZahtjevZaPlacanje
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.RichTextBox();
            this.txtNekretnina = new System.Windows.Forms.TextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.cbMjesecno = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pošalji novi zahtjev za plaćanje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naslov:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iznos:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(274, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nekretnina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(281, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Komentar:";
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(281, 239);
            this.txtKomentar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(271, 151);
            this.txtKomentar.TabIndex = 9;
            this.txtKomentar.Text = "";
            // 
            // txtNekretnina
            // 
            this.txtNekretnina.Location = new System.Drawing.Point(274, 97);
            this.txtNekretnina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNekretnina.Name = "txtNekretnina";
            this.txtNekretnina.ReadOnly = true;
            this.txtNekretnina.Size = new System.Drawing.Size(271, 27);
            this.txtNekretnina.TabIndex = 10;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(14, 97);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(253, 27);
            this.txtNaslov.TabIndex = 11;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(14, 239);
            this.txtIznos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(260, 27);
            this.txtIznos.TabIndex = 12;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(454, 399);
            this.btnPosalji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(93, 52);
            this.btnPosalji.TabIndex = 13;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // cbMjesecno
            // 
            this.cbMjesecno.AutoSize = true;
            this.cbMjesecno.Location = new System.Drawing.Point(14, 366);
            this.cbMjesecno.Name = "cbMjesecno";
            this.cbMjesecno.Size = new System.Drawing.Size(101, 24);
            this.cbMjesecno.TabIndex = 14;
            this.cbMjesecno.Text = "Mjesecno?";
            this.cbMjesecno.UseVisualStyleBackColor = true;
            // 
            // frmZahtjevZaPlacanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 467);
            this.Controls.Add(this.cbMjesecno);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.txtNekretnina);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmZahtjevZaPlacanje";
            this.Text = "Zahtjev za placanje";
            this.Load += new System.EventHandler(this.frmZahtjevZaPlacanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox txtKomentar;
        private TextBox txtNekretnina;
        private TextBox txtNaslov;
        private TextBox txtIznos;
        private Button btnPosalji;
        private CheckBox cbMjesecno;
    }
}