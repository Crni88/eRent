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
            btnListaRezervacija = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnMjesecniPrihodiUkupno = new Button();
            label4 = new Label();
            btnListaKorisnika = new Button();
            label5 = new Label();
            btnPrihodiZaNekretninu = new Button();
            btnMjesecniPrihodiUkupnoIzvjestaj = new Button();
            label6 = new Label();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            dtpFrom = new DateTimePicker();
            dtpUntil = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnRezervacijeIzvjestaj = new Button();
            label9 = new Label();
            label8 = new Label();
            cbListaNekretnina = new ComboBox();
            btnMjesecniPrihodiUkupnoPDF = new Button();
            btnListaNekretninaPDF = new Button();
            label10 = new Label();
            label11 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnListaRezervacija
            // 
            btnListaRezervacija.Location = new Point(29, 185);
            btnListaRezervacija.Margin = new Padding(3, 4, 3, 4);
            btnListaRezervacija.Name = "btnListaRezervacija";
            btnListaRezervacija.Size = new Size(89, 23);
            btnListaRezervacija.TabIndex = 0;
            btnListaRezervacija.Text = "Izvještaj";
            btnListaRezervacija.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // btnMjesecniPrihodiUkupno
            // 
            btnMjesecniPrihodiUkupno.Location = new Point(0, 0);
            btnMjesecniPrihodiUkupno.Name = "btnMjesecniPrihodiUkupno";
            btnMjesecniPrihodiUkupno.Size = new Size(75, 23);
            btnMjesecniPrihodiUkupno.TabIndex = 0;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // btnListaKorisnika
            // 
            btnListaKorisnika.Location = new Point(0, 0);
            btnListaKorisnika.Name = "btnListaKorisnika";
            btnListaKorisnika.Size = new Size(75, 23);
            btnListaKorisnika.TabIndex = 0;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // btnPrihodiZaNekretninu
            // 
            btnPrihodiZaNekretninu.Location = new Point(0, 0);
            btnPrihodiZaNekretninu.Name = "btnPrihodiZaNekretninu";
            btnPrihodiZaNekretninu.Size = new Size(75, 23);
            btnPrihodiZaNekretninu.TabIndex = 0;
            // 
            // btnMjesecniPrihodiUkupnoIzvjestaj
            // 
            btnMjesecniPrihodiUkupnoIzvjestaj.Location = new Point(392, 53);
            btnMjesecniPrihodiUkupnoIzvjestaj.Name = "btnMjesecniPrihodiUkupnoIzvjestaj";
            btnMjesecniPrihodiUkupnoIzvjestaj.Size = new Size(75, 24);
            btnMjesecniPrihodiUkupnoIzvjestaj.TabIndex = 0;
            btnMjesecniPrihodiUkupnoIzvjestaj.Text = "Izvjestaj";
            btnMjesecniPrihodiUkupnoIzvjestaj.UseVisualStyleBackColor = true;
            btnMjesecniPrihodiUkupnoIzvjestaj.Click += btnMjesecniPrihodiUkupno_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 56);
            label6.Name = "label6";
            label6.Size = new Size(192, 21);
            label6.TabIndex = 1;
            label6.Text = "Mjesecni Prihodi Ukupno";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(20, 306);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 3;
            label7.Text = "Lista nekretnina";
            // 
            // button2
            // 
            button2.Location = new Point(200, 298);
            button2.Name = "button2";
            button2.Size = new Size(75, 41);
            button2.TabIndex = 2;
            button2.Text = "Izvjestaj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnListaNekretninaReportGenerate;
            // 
            // button3
            // 
            button3.Location = new Point(342, 167);
            button3.Name = "button3";
            button3.Size = new Size(99, 27);
            button3.TabIndex = 4;
            button3.Text = "PDF";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnListaRezervacija_Click;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(17, 92);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(320, 29);
            dtpFrom.TabIndex = 6;
            // 
            // dtpUntil
            // 
            dtpUntil.Location = new Point(19, 167);
            dtpUntil.Name = "dtpUntil";
            dtpUntil.Size = new Size(318, 29);
            dtpUntil.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRezervacijeIzvjestaj);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbListaNekretnina);
            groupBox1.Controls.Add(dtpUntil);
            groupBox1.Controls.Add(dtpFrom);
            groupBox1.Controls.Add(button3);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 202);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervacije";
            // 
            // btnRezervacijeIzvjestaj
            // 
            btnRezervacijeIzvjestaj.Location = new Point(342, 88);
            btnRezervacijeIzvjestaj.Name = "btnRezervacijeIzvjestaj";
            btnRezervacijeIzvjestaj.Size = new Size(99, 40);
            btnRezervacijeIzvjestaj.TabIndex = 11;
            btnRezervacijeIzvjestaj.Text = "Izvjestaj";
            btnRezervacijeIzvjestaj.UseVisualStyleBackColor = true;
            btnRezervacijeIzvjestaj.Click += btnRezervacijeIzvjestaj_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 143);
            label9.Name = "label9";
            label9.Size = new Size(31, 21);
            label9.TabIndex = 10;
            label9.Text = "Do";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 68);
            label8.Name = "label8";
            label8.Size = new Size(32, 21);
            label8.TabIndex = 9;
            label8.Text = "Od";
            // 
            // cbListaNekretnina
            // 
            cbListaNekretnina.FormattingEnabled = true;
            cbListaNekretnina.Location = new Point(18, 22);
            cbListaNekretnina.Name = "cbListaNekretnina";
            cbListaNekretnina.Size = new Size(318, 29);
            cbListaNekretnina.TabIndex = 8;
            // 
            // btnMjesecniPrihodiUkupnoPDF
            // 
            btnMjesecniPrihodiUkupnoPDF.Location = new Point(311, 53);
            btnMjesecniPrihodiUkupnoPDF.Name = "btnMjesecniPrihodiUkupnoPDF";
            btnMjesecniPrihodiUkupnoPDF.Size = new Size(75, 23);
            btnMjesecniPrihodiUkupnoPDF.TabIndex = 9;
            btnMjesecniPrihodiUkupnoPDF.Text = "PDF";
            btnMjesecniPrihodiUkupnoPDF.UseVisualStyleBackColor = true;
            btnMjesecniPrihodiUkupnoPDF.Click += btnMjesecniPrihodiUkupnoPDF_Click;
            // 
            // btnListaNekretninaPDF
            // 
            btnListaNekretninaPDF.Location = new Point(302, 298);
            btnListaNekretninaPDF.Name = "btnListaNekretninaPDF";
            btnListaNekretninaPDF.Size = new Size(141, 41);
            btnListaNekretninaPDF.TabIndex = 10;
            btnListaNekretninaPDF.Text = "PDF";
            btnListaNekretninaPDF.UseVisualStyleBackColor = true;
            btnListaNekretninaPDF.Click += btnListaNekretninaPDF_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(37, 9);
            label10.Name = "label10";
            label10.Size = new Size(59, 21);
            label10.TabIndex = 33;
            label10.Text = "Nazad";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(16, 8);
            label11.Name = "label11";
            label11.Size = new Size(28, 21);
            label11.TabIndex = 32;
            label11.Text = "<-";
            label11.Click += label11_Click;
            // 
            // frmOpcijeIzvjestaja
            // 
            ClientSize = new Size(508, 351);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(btnListaNekretninaPDF);
            Controls.Add(btnMjesecniPrihodiUkupnoPDF);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(btnMjesecniPrihodiUkupnoIzvjestaj);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmOpcijeIzvjestaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporti";
            Load += frmOpcijeIzvjestaja_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnMjesecniPrihodiUkupnoIzvjestaj;
        private Label label6;
        private Label label7;
        private Button button2;
        private Button button3;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpUntil;
        private GroupBox groupBox1;
        private ComboBox cbListaNekretnina;
        private Label label8;
        private Label label9;
        private Button btnRezervacijeIzvjestaj;
        private Button btnMjesecniPrihodiUkupnoPDF;
        private Button btnListaNekretninaPDF;
        private Label label10;
        private Label label11;
    }
}