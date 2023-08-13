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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtKomentar = new RichTextBox();
            txtNekretnina = new TextBox();
            txtNaslov = new TextBox();
            txtIznos = new TextBox();
            btnPosalji = new Button();
            cbMjesecno = new CheckBox();
            err = new ErrorProvider(components);
            btnNazad = new Button();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(315, 30);
            label1.TabIndex = 4;
            label1.Text = "Pošalji novi zahtjev za plaćanje";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 5;
            label2.Text = "Naslov:*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 6;
            label3.Text = "Iznos:*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(240, 89);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 7;
            label4.Text = "Nekretnina";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(246, 155);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 8;
            label5.Text = "Komentar:";
            // 
            // txtKomentar
            // 
            txtKomentar.Location = new Point(246, 179);
            txtKomentar.Name = "txtKomentar";
            txtKomentar.Size = new Size(238, 114);
            txtKomentar.TabIndex = 9;
            txtKomentar.Text = "";
            // 
            // txtNekretnina
            // 
            txtNekretnina.Location = new Point(240, 113);
            txtNekretnina.Name = "txtNekretnina";
            txtNekretnina.ReadOnly = true;
            txtNekretnina.Size = new Size(238, 23);
            txtNekretnina.TabIndex = 10;
            // 
            // txtNaslov
            // 
            txtNaslov.Location = new Point(12, 113);
            txtNaslov.Name = "txtNaslov";
            txtNaslov.Size = new Size(222, 23);
            txtNaslov.TabIndex = 11;
            txtNaslov.Validating += txtNaslov_Validating;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(12, 179);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(228, 23);
            txtIznos.TabIndex = 12;
            txtIznos.Validating += txtIznos_Validating;
            // 
            // btnPosalji
            // 
            btnPosalji.Location = new Point(397, 299);
            btnPosalji.Name = "btnPosalji";
            btnPosalji.Size = new Size(81, 39);
            btnPosalji.TabIndex = 13;
            btnPosalji.Text = "Posalji";
            btnPosalji.UseVisualStyleBackColor = true;
            btnPosalji.Click += btnPosalji_Click;
            // 
            // cbMjesecno
            // 
            cbMjesecno.AutoSize = true;
            cbMjesecno.Location = new Point(12, 207);
            cbMjesecno.Margin = new Padding(3, 2, 3, 2);
            cbMjesecno.Name = "cbMjesecno";
            cbMjesecno.Size = new Size(82, 19);
            cbMjesecno.TabIndex = 14;
            cbMjesecno.Text = "Mjesecno?";
            cbMjesecno.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // btnNazad
            // 
            btnNazad.Location = new Point(15, 12);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(79, 22);
            btnNazad.TabIndex = 34;
            btnNazad.Text = "Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            btnNazad.Click += btnNazad_Click;
            // 
            // frmZahtjevZaPlacanje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(496, 350);
            Controls.Add(btnNazad);
            Controls.Add(cbMjesecno);
            Controls.Add(btnPosalji);
            Controls.Add(txtIznos);
            Controls.Add(txtNaslov);
            Controls.Add(txtNekretnina);
            Controls.Add(txtKomentar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmZahtjevZaPlacanje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zahtjev za placanje";
            Load += frmZahtjevZaPlacanje_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ErrorProvider err;
        private Button btnNazad;
    }
}