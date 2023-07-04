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
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 44);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 89);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Prezime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 138);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "E-mail";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(103, 187);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 3;
            Username.Text = "Username";
            // 
            // txtKorisnikIme
            // 
            txtKorisnikIme.Location = new Point(58, 59);
            txtKorisnikIme.Margin = new Padding(3, 2, 3, 2);
            txtKorisnikIme.Name = "txtKorisnikIme";
            txtKorisnikIme.Size = new Size(150, 23);
            txtKorisnikIme.TabIndex = 5;
            txtKorisnikIme.Validating += txtKorisnikIme_Validating;
            // 
            // txtKorisnikPrezime
            // 
            txtKorisnikPrezime.Location = new Point(58, 106);
            txtKorisnikPrezime.Margin = new Padding(3, 2, 3, 2);
            txtKorisnikPrezime.Name = "txtKorisnikPrezime";
            txtKorisnikPrezime.Size = new Size(150, 23);
            txtKorisnikPrezime.TabIndex = 6;
            txtKorisnikPrezime.Validating += txtKorisnikPrezime_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(57, 155);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 7;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(57, 204);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(152, 23);
            txtUsername.TabIndex = 8;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // btnDodajNovogKorisnika
            // 
            btnDodajNovogKorisnika.Location = new Point(90, 350);
            btnDodajNovogKorisnika.Margin = new Padding(3, 2, 3, 2);
            btnDodajNovogKorisnika.Name = "btnDodajNovogKorisnika";
            btnDodajNovogKorisnika.Size = new Size(82, 30);
            btnDodajNovogKorisnika.TabIndex = 9;
            btnDodajNovogKorisnika.Text = "Spasi";
            btnDodajNovogKorisnika.UseVisualStyleBackColor = true;
            btnDodajNovogKorisnika.Click += btnDodajNovogKorisnika_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(57, 313);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(152, 23);
            txtPassword.TabIndex = 11;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(105, 296);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // cbUloga
            // 
            cbUloga.FormattingEnabled = true;
            cbUloga.Location = new Point(58, 260);
            cbUloga.Name = "cbUloga";
            cbUloga.Size = new Size(151, 23);
            cbUloga.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 242);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 13;
            label4.Text = "Uloga";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(33, 9);
            label8.Name = "label8";
            label8.Size = new Size(59, 21);
            label8.TabIndex = 33;
            label8.Text = "Nazad";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 8);
            label7.Name = "label7";
            label7.Size = new Size(28, 21);
            label7.TabIndex = 32;
            label7.Text = "<-";
            label7.Click += label7_Click;
            // 
            // frmAddNovogKorisnika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(264, 416);
            Controls.Add(label8);
            Controls.Add(label7);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label8;
        private Label label7;
    }
}