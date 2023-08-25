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
            label7 = new Label();
            button2 = new Button();
            dtpFrom = new DateTimePicker();
            dtpUntil = new DateTimePicker();
            groupBox1 = new GroupBox();
            label10 = new Label();
            btnRezervacijeIzvjestaj = new Button();
            label9 = new Label();
            label8 = new Label();
            cbListaNekretnina = new ComboBox();
            btnListaNekretninaPDF = new Button();
            btnNazad = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 52);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 3;
            label7.Text = "Lista nekretnina";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(463, 42);
            button2.Name = "button2";
            button2.Size = new Size(99, 41);
            button2.TabIndex = 2;
            button2.Text = "Izvjestaj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnListaNekretninaReportGenerate;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(16, 117);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(388, 29);
            dtpFrom.TabIndex = 6;
            // 
            // dtpUntil
            // 
            dtpUntil.Location = new Point(16, 200);
            dtpUntil.Name = "dtpUntil";
            dtpUntil.Size = new Size(388, 29);
            dtpUntil.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnRezervacijeIzvjestaj);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cbListaNekretnina);
            groupBox1.Controls.Add(dtpUntil);
            groupBox1.Controls.Add(dtpFrom);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(568, 245);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervacije";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 32);
            label10.Name = "label10";
            label10.Size = new Size(90, 21);
            label10.TabIndex = 12;
            label10.Text = "Nekretnina";
            // 
            // btnRezervacijeIzvjestaj
            // 
            btnRezervacijeIzvjestaj.Location = new Point(463, 113);
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
            label9.Location = new Point(16, 172);
            label9.Name = "label9";
            label9.Size = new Size(31, 21);
            label9.TabIndex = 10;
            label9.Text = "Do";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 93);
            label8.Name = "label8";
            label8.Size = new Size(32, 21);
            label8.TabIndex = 9;
            label8.Text = "Od";
            // 
            // cbListaNekretnina
            // 
            cbListaNekretnina.FormattingEnabled = true;
            cbListaNekretnina.Location = new Point(16, 56);
            cbListaNekretnina.Name = "cbListaNekretnina";
            cbListaNekretnina.Size = new Size(388, 29);
            cbListaNekretnina.TabIndex = 8;
            // 
            // btnListaNekretninaPDF
            // 
            btnListaNekretninaPDF.Location = new Point(358, 42);
            btnListaNekretninaPDF.Name = "btnListaNekretninaPDF";
            btnListaNekretninaPDF.Size = new Size(99, 40);
            btnListaNekretninaPDF.TabIndex = 10;
            btnListaNekretninaPDF.Text = "PDF";
            btnListaNekretninaPDF.UseVisualStyleBackColor = true;
            btnListaNekretninaPDF.Click += btnListaNekretninaPDF_Click;
            // 
            // btnNazad
            // 
            btnNazad.Location = new Point(20, 12);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(75, 23);
            btnNazad.TabIndex = 34;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            btnNazad.Click += btnNazad_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnListaNekretninaPDF);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(20, 305);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(568, 120);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nekretnine";
            // 
            // frmOpcijeIzvjestaja
            // 
            ClientSize = new Size(600, 437);
            Controls.Add(btnNazad);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmOpcijeIzvjestaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporti";
            Load += frmOpcijeIzvjestaja_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
        private Label label7;
        private Button button2;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpUntil;
        private GroupBox groupBox1;
        private ComboBox cbListaNekretnina;
        private Label label8;
        private Label label9;
        private Button btnRezervacijeIzvjestaj;
        private Button btnListaNekretninaPDF;
        private Button btnNazad;
        private Label label10;
        private GroupBox groupBox3;
    }
}