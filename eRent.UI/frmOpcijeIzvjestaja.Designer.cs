﻿namespace eRent.UI
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
            btnMjesecniPrihodiUkupnoIzvjestaj.Location = new Point(294, 13);
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
            label6.Location = new Point(12, 17);
            label6.Name = "label6";
            label6.Size = new Size(140, 15);
            label6.TabIndex = 1;
            label6.Text = "Mjesecni Prihodi Ukupno";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 209);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 3;
            label7.Text = "Lista nekretnina";
            // 
            // button2
            // 
            button2.Location = new Point(202, 212);
            button2.Name = "button2";
            button2.Size = new Size(75, 41);
            button2.TabIndex = 2;
            button2.Text = "Izvjestaj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnListaNekretninaReportGenerate;
            // 
            // button3
            // 
            button3.Location = new Point(276, 104);
            button3.Name = "button3";
            button3.Size = new Size(75, 27);
            button3.TabIndex = 4;
            button3.Text = "PDF";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnListaRezervacija_Click;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(18, 68);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 23);
            dtpFrom.TabIndex = 6;
            // 
            // dtpUntil
            // 
            dtpUntil.Location = new Point(18, 128);
            dtpUntil.Name = "dtpUntil";
            dtpUntil.Size = new Size(200, 23);
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
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 164);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervacije";
            // 
            // btnRezervacijeIzvjestaj
            // 
            btnRezervacijeIzvjestaj.Location = new Point(276, 44);
            btnRezervacijeIzvjestaj.Name = "btnRezervacijeIzvjestaj";
            btnRezervacijeIzvjestaj.Size = new Size(75, 27);
            btnRezervacijeIzvjestaj.TabIndex = 11;
            btnRezervacijeIzvjestaj.Text = "Izvjestaj";
            btnRezervacijeIzvjestaj.UseVisualStyleBackColor = true;
            btnRezervacijeIzvjestaj.Click += btnRezervacijeIzvjestaj_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 110);
            label9.Name = "label9";
            label9.Size = new Size(22, 15);
            label9.TabIndex = 10;
            label9.Text = "Do";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 50);
            label8.Name = "label8";
            label8.Size = new Size(23, 15);
            label8.TabIndex = 9;
            label8.Text = "Od";
            // 
            // cbListaNekretnina
            // 
            cbListaNekretnina.FormattingEnabled = true;
            cbListaNekretnina.Location = new Point(18, 22);
            cbListaNekretnina.Name = "cbListaNekretnina";
            cbListaNekretnina.Size = new Size(200, 23);
            cbListaNekretnina.TabIndex = 8;
            // 
            // btnMjesecniPrihodiUkupnoPDF
            // 
            btnMjesecniPrihodiUkupnoPDF.Location = new Point(213, 13);
            btnMjesecniPrihodiUkupnoPDF.Name = "btnMjesecniPrihodiUkupnoPDF";
            btnMjesecniPrihodiUkupnoPDF.Size = new Size(75, 23);
            btnMjesecniPrihodiUkupnoPDF.TabIndex = 9;
            btnMjesecniPrihodiUkupnoPDF.Text = "PDF";
            btnMjesecniPrihodiUkupnoPDF.UseVisualStyleBackColor = true;
            btnMjesecniPrihodiUkupnoPDF.Click += btnMjesecniPrihodiUkupnoPDF_Click;
            // 
            // btnListaNekretninaPDF
            // 
            btnListaNekretninaPDF.Location = new Point(288, 212);
            btnListaNekretninaPDF.Name = "btnListaNekretninaPDF";
            btnListaNekretninaPDF.Size = new Size(75, 41);
            btnListaNekretninaPDF.TabIndex = 10;
            btnListaNekretninaPDF.Text = "PDF";
            btnListaNekretninaPDF.UseVisualStyleBackColor = true;
            btnListaNekretninaPDF.Click += btnListaNekretninaPDF_Click;
            // 
            // frmOpcijeIzvjestaja
            // 
            ClientSize = new Size(381, 258);
            Controls.Add(btnListaNekretninaPDF);
            Controls.Add(btnMjesecniPrihodiUkupnoPDF);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(btnMjesecniPrihodiUkupnoIzvjestaj);
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
    }
}