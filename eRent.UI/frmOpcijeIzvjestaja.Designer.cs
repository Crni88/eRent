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
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrihodiZaNekretninu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaRezervacija
            // 
            this.btnListaRezervacija.Location = new System.Drawing.Point(50, 254);
            this.btnListaRezervacija.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaRezervacija.Name = "btnListaRezervacija";
            this.btnListaRezervacija.Size = new System.Drawing.Size(89, 23);
            this.btnListaRezervacija.TabIndex = 0;
            this.btnListaRezervacija.Text = "Izvještaj";
            this.btnListaRezervacija.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izvjestaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mjesecni prihodi (ukupno)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista Korisnika";
            // 
            // btnMjesecniPrihodiUkupno
            // 
            this.btnMjesecniPrihodiUkupno.Location = new System.Drawing.Point(29, 74);
            this.btnMjesecniPrihodiUkupno.Name = "btnMjesecniPrihodiUkupno";
            this.btnMjesecniPrihodiUkupno.Size = new System.Drawing.Size(89, 23);
            this.btnMjesecniPrihodiUkupno.TabIndex = 3;
            this.btnMjesecniPrihodiUkupno.Text = "Izvještaj";
            this.btnMjesecniPrihodiUkupno.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lista rezervacija";
            // 
            // btnListaKorisnika
            // 
            this.btnListaKorisnika.Location = new System.Drawing.Point(29, 131);
            this.btnListaKorisnika.Name = "btnListaKorisnika";
            this.btnListaKorisnika.Size = new System.Drawing.Size(89, 23);
            this.btnListaKorisnika.TabIndex = 5;
            this.btnListaKorisnika.Text = "Izvještaj";
            this.btnListaKorisnika.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(192, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prihodi za nekretninu";
            // 
            // btnPrihodiZaNekretninu
            // 
            this.btnPrihodiZaNekretninu.Location = new System.Drawing.Point(203, 131);
            this.btnPrihodiZaNekretninu.Name = "btnPrihodiZaNekretninu";
            this.btnPrihodiZaNekretninu.Size = new System.Drawing.Size(89, 23);
            this.btnPrihodiZaNekretninu.TabIndex = 7;
            this.btnPrihodiZaNekretninu.Text = "Izvještaj";
            this.btnPrihodiZaNekretninu.UseVisualStyleBackColor = true;
            this.btnPrihodiZaNekretninu.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 323);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnListaKorisnika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMjesecniPrihodiUkupno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListaRezervacija);
            this.Name = "frmIzvjestaj";
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
        private Label label5;
        private Button btnPrihodiZaNekretninu;
    }
}