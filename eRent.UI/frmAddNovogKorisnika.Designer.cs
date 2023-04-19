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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.txtKorisnikIme = new System.Windows.Forms.TextBox();
            this.txtKorisnikPrezime = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnDodajNovogKorisnika = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUloga = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisnicko Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisnicko Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(100, 152);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(60, 15);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // txtKorisnikIme
            // 
            this.txtKorisnikIme.Location = new System.Drawing.Point(55, 24);
            this.txtKorisnikIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKorisnikIme.Name = "txtKorisnikIme";
            this.txtKorisnikIme.Size = new System.Drawing.Size(150, 23);
            this.txtKorisnikIme.TabIndex = 5;
            this.txtKorisnikIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnikIme_Validating);
            // 
            // txtKorisnikPrezime
            // 
            this.txtKorisnikPrezime.Location = new System.Drawing.Point(55, 71);
            this.txtKorisnikPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKorisnikPrezime.Name = "txtKorisnikPrezime";
            this.txtKorisnikPrezime.Size = new System.Drawing.Size(150, 23);
            this.txtKorisnikPrezime.TabIndex = 6;
            this.txtKorisnikPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnikPrezime_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(54, 120);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 23);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(54, 169);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(152, 23);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // btnDodajNovogKorisnika
            // 
            this.btnDodajNovogKorisnika.Location = new System.Drawing.Point(89, 305);
            this.btnDodajNovogKorisnika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajNovogKorisnika.Name = "btnDodajNovogKorisnika";
            this.btnDodajNovogKorisnika.Size = new System.Drawing.Size(82, 30);
            this.btnDodajNovogKorisnika.TabIndex = 9;
            this.btnDodajNovogKorisnika.Text = "Dodaj";
            this.btnDodajNovogKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajNovogKorisnika.Click += new System.EventHandler(this.btnDodajNovogKorisnika_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(54, 278);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 23);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // cbUloga
            // 
            this.cbUloga.FormattingEnabled = true;
            this.cbUloga.Location = new System.Drawing.Point(55, 225);
            this.cbUloga.Name = "cbUloga";
            this.cbUloga.Size = new System.Drawing.Size(151, 23);
            this.cbUloga.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Uloga";
            // 
            // frmAddNovogKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUloga);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajNovogKorisnika);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtKorisnikPrezime);
            this.Controls.Add(this.txtKorisnikIme);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddNovogKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novog korisnika";
            this.Load += new System.EventHandler(this.frmAddNovogKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label label5;
        private Label label4;
        private ComboBox cbUloga;
    }
}