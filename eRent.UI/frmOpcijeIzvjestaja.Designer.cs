namespace eRent.UI
{
    partial class frmOpcijeIzvjestaja
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
            this.btnListaRezervacija = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMjesecniPrihodiUkupno = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListaKorisnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaRezervacija
            // 
            this.btnListaRezervacija.Location = new System.Drawing.Point(259, 99);
            this.btnListaRezervacija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaRezervacija.Name = "btnListaRezervacija";
            this.btnListaRezervacija.Size = new System.Drawing.Size(102, 31);
            this.btnListaRezervacija.TabIndex = 0;
            this.btnListaRezervacija.Text = "Izvještaj";
            this.btnListaRezervacija.UseVisualStyleBackColor = true;
            this.btnListaRezervacija.Click += new System.EventHandler(this.btnListaRezervacija_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izvjestaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mjesecni prihodi (ukupno)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista Nekretnina";
            // 
            // btnMjesecniPrihodiUkupno
            // 
            this.btnMjesecniPrihodiUkupno.Location = new System.Drawing.Point(50, 99);
            this.btnMjesecniPrihodiUkupno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMjesecniPrihodiUkupno.Name = "btnMjesecniPrihodiUkupno";
            this.btnMjesecniPrihodiUkupno.Size = new System.Drawing.Size(102, 31);
            this.btnMjesecniPrihodiUkupno.TabIndex = 3;
            this.btnMjesecniPrihodiUkupno.Text = "Izvještaj";
            this.btnMjesecniPrihodiUkupno.UseVisualStyleBackColor = true;
            this.btnMjesecniPrihodiUkupno.Click += new System.EventHandler(this.btnMjesecniPrihodiUkupno_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(248, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lista rezervacija";
            // 
            // btnListaKorisnika
            // 
            this.btnListaKorisnika.Location = new System.Drawing.Point(50, 175);
            this.btnListaKorisnika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaKorisnika.Name = "btnListaKorisnika";
            this.btnListaKorisnika.Size = new System.Drawing.Size(102, 31);
            this.btnListaKorisnika.TabIndex = 5;
            this.btnListaKorisnika.Text = "Izvještaj";
            this.btnListaKorisnika.UseVisualStyleBackColor = true;
            this.btnListaKorisnika.Click += new System.EventHandler(this.btnListaNekretnina_Click);
            // 
            // frmOpcijeIzvjestaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 243);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnListaKorisnika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMjesecniPrihodiUkupno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListaRezervacija);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOpcijeIzvjestaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvjestaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnListaRezervacija;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnMjesecniPrihodiUkupno;
        private Label label4;
        private Button btnListaKorisnika;
    }
}