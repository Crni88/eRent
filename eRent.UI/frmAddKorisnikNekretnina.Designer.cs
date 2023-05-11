namespace eRent.UI
{
    partial class frmAddKorisnikNekretnina
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
            pbKorisnikSlika = new PictureBox();
            btnKorisnikSlika = new Button();
            Ime = new Label();
            txtIme = new TextBox();
            txtBrojTelefona = new TextBox();
            label2 = new Label();
            txtPrezime = new TextBox();
            label3 = new Label();
            dtpDatumUseljenja = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dtpDatumIseljenja = new DateTimePicker();
            btnDodajKorisnika = new Button();
            ofdKorisnikNekretnina = new OpenFileDialog();
            err = new ErrorProvider(components);
            btnObrisi = new Button();
            ((System.ComponentModel.ISupportInitialize)pbKorisnikSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(307, 37);
            label1.TabIndex = 0;
            label1.Text = "Dodaj novog korisnika";
            // 
            // pbKorisnikSlika
            // 
            pbKorisnikSlika.Location = new Point(14, 61);
            pbKorisnikSlika.Margin = new Padding(3, 4, 3, 4);
            pbKorisnikSlika.Name = "pbKorisnikSlika";
            pbKorisnikSlika.Size = new Size(366, 440);
            pbKorisnikSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKorisnikSlika.TabIndex = 1;
            pbKorisnikSlika.TabStop = false;
            // 
            // btnKorisnikSlika
            // 
            btnKorisnikSlika.Location = new Point(139, 509);
            btnKorisnikSlika.Margin = new Padding(3, 4, 3, 4);
            btnKorisnikSlika.Name = "btnKorisnikSlika";
            btnKorisnikSlika.Size = new Size(86, 31);
            btnKorisnikSlika.TabIndex = 2;
            btnKorisnikSlika.Text = "Dodaj sliku";
            btnKorisnikSlika.UseVisualStyleBackColor = true;
            btnKorisnikSlika.Click += btnKorisnikSlika_Click;
            // 
            // Ime
            // 
            Ime.AutoSize = true;
            Ime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Ime.Location = new Point(386, 61);
            Ime.Name = "Ime";
            Ime.Size = new Size(52, 28);
            Ime.TabIndex = 3;
            Ime.Text = "Ime*";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(386, 97);
            txtIme.Margin = new Padding(3, 4, 3, 4);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(187, 27);
            txtIme.TabIndex = 4;
            txtIme.Validating += txtIme_Validating;
            // 
            // txtBrojTelefona
            // 
            txtBrojTelefona.Location = new Point(386, 292);
            txtBrojTelefona.Margin = new Padding(3, 4, 3, 4);
            txtBrojTelefona.Name = "txtBrojTelefona";
            txtBrojTelefona.PlaceholderText = "123 456 789";
            txtBrojTelefona.Size = new Size(187, 27);
            txtBrojTelefona.TabIndex = 6;
            txtBrojTelefona.Validating += txtBrojTelefona_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(386, 260);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 5;
            label2.Text = "Broj telefona*";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(386, 188);
            txtPrezime.Margin = new Padding(3, 4, 3, 4);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(187, 27);
            txtPrezime.TabIndex = 8;
            txtPrezime.Validating += txtPrezime_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(386, 156);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 7;
            label3.Text = "Prezime*";
            // 
            // dtpDatumUseljenja
            // 
            dtpDatumUseljenja.Location = new Point(595, 97);
            dtpDatumUseljenja.Margin = new Padding(3, 4, 3, 4);
            dtpDatumUseljenja.Name = "dtpDatumUseljenja";
            dtpDatumUseljenja.Size = new Size(305, 27);
            dtpDatumUseljenja.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(595, 61);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 10;
            label4.Text = "Datum useljenja";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(595, 156);
            label5.Name = "label5";
            label5.Size = new Size(145, 28);
            label5.TabIndex = 12;
            label5.Text = "Datum iseljenja";
            // 
            // dtpDatumIseljenja
            // 
            dtpDatumIseljenja.Location = new Point(595, 188);
            dtpDatumIseljenja.Margin = new Padding(3, 4, 3, 4);
            dtpDatumIseljenja.Name = "dtpDatumIseljenja";
            dtpDatumIseljenja.Size = new Size(305, 27);
            dtpDatumIseljenja.TabIndex = 11;
            // 
            // btnDodajKorisnika
            // 
            btnDodajKorisnika.Location = new Point(814, 288);
            btnDodajKorisnika.Margin = new Padding(3, 4, 3, 4);
            btnDodajKorisnika.Name = "btnDodajKorisnika";
            btnDodajKorisnika.Size = new Size(86, 31);
            btnDodajKorisnika.TabIndex = 13;
            btnDodajKorisnika.Text = "Dodaj";
            btnDodajKorisnika.UseVisualStyleBackColor = true;
            btnDodajKorisnika.Click += btnDodajKorisnika_Click;
            // 
            // ofdKorisnikNekretnina
            // 
            ofdKorisnikNekretnina.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(488, 428);
            btnObrisi.Margin = new Padding(3, 4, 3, 4);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(86, 73);
            btnObrisi.TabIndex = 14;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // frmAddKorisnikNekretnina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 571);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodajKorisnika);
            Controls.Add(label5);
            Controls.Add(dtpDatumIseljenja);
            Controls.Add(label4);
            Controls.Add(dtpDatumUseljenja);
            Controls.Add(txtPrezime);
            Controls.Add(label3);
            Controls.Add(txtBrojTelefona);
            Controls.Add(label2);
            Controls.Add(txtIme);
            Controls.Add(Ime);
            Controls.Add(btnKorisnikSlika);
            Controls.Add(pbKorisnikSlika);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAddKorisnikNekretnina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj novog korisnika";
            ((System.ComponentModel.ISupportInitialize)pbKorisnikSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbKorisnikSlika;
        private Button btnKorisnikSlika;
        private Label Ime;
        private TextBox txtIme;
        private TextBox txtBrojTelefona;
        private Label label2;
        private TextBox txtPrezime;
        private Label label3;
        private DateTimePicker dtpDatumUseljenja;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpDatumIseljenja;
        private Button btnDodajKorisnika;
        private OpenFileDialog ofdKorisnikNekretnina;
        private ErrorProvider err;
        private Button btnObrisi;
    }
}