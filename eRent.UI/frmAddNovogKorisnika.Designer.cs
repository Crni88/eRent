namespace eRent.UI
{
    partial class frmAddNovogKorisnika
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
            Username = new Label();
            txtKorisnikIme = new TextBox();
            txtKorisnikPrezime = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            btnDodajNovogKorisnika = new Button();
            err = new ErrorProvider(components);
            txtPassword = new TextBox();
            lblPassword = new Label();
            cbUloga = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Korisnicko Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 72);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 1;
            label2.Text = "Korisnicko Prezime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 137);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "E-mail";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(114, 203);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // txtKorisnikIme
            // 
            txtKorisnikIme.Location = new Point(63, 32);
            txtKorisnikIme.Name = "txtKorisnikIme";
            txtKorisnikIme.Size = new Size(171, 27);
            txtKorisnikIme.TabIndex = 5;
            txtKorisnikIme.Validating += txtKorisnikIme_Validating;
            // 
            // txtKorisnikPrezime
            // 
            txtKorisnikPrezime.Location = new Point(63, 95);
            txtKorisnikPrezime.Name = "txtKorisnikPrezime";
            txtKorisnikPrezime.Size = new Size(171, 27);
            txtKorisnikPrezime.TabIndex = 6;
            txtKorisnikPrezime.Validating += txtKorisnikPrezime_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(62, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(173, 27);
            txtEmail.TabIndex = 7;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(62, 225);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(173, 27);
            txtUsername.TabIndex = 8;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // btnDodajNovogKorisnika
            // 
            btnDodajNovogKorisnika.Location = new Point(102, 407);
            btnDodajNovogKorisnika.Name = "btnDodajNovogKorisnika";
            btnDodajNovogKorisnika.Size = new Size(94, 40);
            btnDodajNovogKorisnika.TabIndex = 9;
            btnDodajNovogKorisnika.Text = "Dodaj";
            btnDodajNovogKorisnika.UseVisualStyleBackColor = true;
            btnDodajNovogKorisnika.Click += btnDodajNovogKorisnika_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(62, 371);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(173, 27);
            txtPassword.TabIndex = 11;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(117, 348);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // cbUloga
            // 
            cbUloga.FormattingEnabled = true;
            cbUloga.Location = new Point(63, 300);
            cbUloga.Margin = new Padding(3, 4, 3, 4);
            cbUloga.Name = "cbUloga";
            cbUloga.Size = new Size(172, 28);
            cbUloga.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 276);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 13;
            label4.Text = "Uloga";
            // 
            // frmAddNovogKorisnika
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 451);
            Controls.Add(label4);
            Controls.Add(cbUloga);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnDodajNovogKorisnika);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtKorisnikPrezime);
            Controls.Add(txtKorisnikIme);
            Controls.Add(Username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddNovogKorisnika";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj novog korisnika";
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label Username;
        private TextBox txtKorisnikIme;
        private TextBox txtKorisnikPrezime;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private Button btnDodajNovogKorisnika;
        private ErrorProvider err;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label label4;
        private ComboBox cbUloga;
    }
}