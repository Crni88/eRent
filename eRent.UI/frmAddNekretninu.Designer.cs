﻿namespace eRent.UI
{
    partial class frmAddNekretninu
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
            pbSlikaNekretnine = new PictureBox();
            btnDodajSliku = new Button();
            label2 = new Label();
            txtNaziv = new TextBox();
            txtCijena = new TextBox();
            label3 = new Label();
            txtGrad = new TextBox();
            txtBrojKvadrata = new TextBox();
            label4 = new Label();
            txtBrojSoba = new TextBox();
            label5 = new Label();
            Cijena = new Label();
            txtOpis = new RichTextBox();
            label6 = new Label();
            cbPetFriendly = new CheckBox();
            cbNamjestena = new CheckBox();
            cbMiran = new CheckBox();
            cbNoSmoking = new CheckBox();
            btnSpasi = new Button();
            cbPopunjena = new CheckBox();
            cbIzdvojena = new CheckBox();
            cbOsvjetljen = new CheckBox();
            err = new ErrorProvider(components);
            ofdSlikaNekretnine = new OpenFileDialog();
            cbTihoNaselje = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSlikaNekretnine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbSlikaNekretnine
            // 
            pbSlikaNekretnine.Location = new Point(12, 68);
            pbSlikaNekretnine.Name = "pbSlikaNekretnine";
            pbSlikaNekretnine.Size = new Size(250, 301);
            pbSlikaNekretnine.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlikaNekretnine.TabIndex = 1;
            pbSlikaNekretnine.TabStop = false;
            // 
            // btnDodajSliku
            // 
            btnDodajSliku.Location = new Point(77, 375);
            btnDodajSliku.Name = "btnDodajSliku";
            btnDodajSliku.Size = new Size(116, 37);
            btnDodajSliku.TabIndex = 2;
            btnDodajSliku.Text = "Dodaj Sliku";
            btnDodajSliku.UseVisualStyleBackColor = true;
            btnDodajSliku.Click += btnDodajSliku_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(302, 27);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "Unesi Naziv*";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(302, 45);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(207, 27);
            txtNaziv.TabIndex = 5;
            txtNaziv.Validating += txtNaziv_Validating;
            // 
            // txtCijena
            // 
            txtCijena.Location = new Point(592, 45);
            txtCijena.Name = "txtCijena";
            txtCijena.Size = new Size(196, 27);
            txtCijena.TabIndex = 6;
            txtCijena.Validating += txtCijena_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(302, 90);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Grad*";
            // 
            // txtGrad
            // 
            txtGrad.Location = new Point(302, 108);
            txtGrad.Name = "txtGrad";
            txtGrad.Size = new Size(207, 27);
            txtGrad.TabIndex = 8;
            txtGrad.Validating += txtGrad_Validating;
            // 
            // txtBrojKvadrata
            // 
            txtBrojKvadrata.Location = new Point(302, 166);
            txtBrojKvadrata.Name = "txtBrojKvadrata";
            txtBrojKvadrata.Size = new Size(207, 27);
            txtBrojKvadrata.TabIndex = 9;
            txtBrojKvadrata.Validating += txtBrojKvadrata_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(302, 148);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 10;
            label4.Text = "Broj kvadrata*";
            // 
            // txtBrojSoba
            // 
            txtBrojSoba.Location = new Point(302, 237);
            txtBrojSoba.Name = "txtBrojSoba";
            txtBrojSoba.Size = new Size(207, 27);
            txtBrojSoba.TabIndex = 11;
            txtBrojSoba.Validating += txtBrojSoba_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(302, 219);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 12;
            label5.Text = "Broj soba*";
            // 
            // Cijena
            // 
            Cijena.AutoSize = true;
            Cijena.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cijena.Location = new Point(592, 27);
            Cijena.Name = "Cijena";
            Cijena.Size = new Size(99, 20);
            Cijena.TabIndex = 13;
            Cijena.Text = "Cijena rente*";
            // 
            // txtOpis
            // 
            txtOpis.Location = new Point(546, 237);
            txtOpis.Name = "txtOpis";
            txtOpis.Size = new Size(242, 132);
            txtOpis.TabIndex = 14;
            txtOpis.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(546, 219);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 15;
            label6.Text = "Detaljan opis";
            // 
            // cbPetFriendly
            // 
            cbPetFriendly.AutoSize = true;
            cbPetFriendly.Location = new Point(592, 110);
            cbPetFriendly.Name = "cbPetFriendly";
            cbPetFriendly.Size = new Size(114, 24);
            cbPetFriendly.TabIndex = 16;
            cbPetFriendly.Text = "Pet Friendly";
            cbPetFriendly.UseVisualStyleBackColor = true;
            // 
            // cbNamjestena
            // 
            cbNamjestena.AutoSize = true;
            cbNamjestena.Location = new Point(302, 277);
            cbNamjestena.Name = "cbNamjestena";
            cbNamjestena.Size = new Size(115, 24);
            cbNamjestena.TabIndex = 17;
            cbNamjestena.Text = "Namještena";
            cbNamjestena.UseVisualStyleBackColor = true;
            // 
            // cbMiran
            // 
            cbMiran.AutoSize = true;
            cbMiran.Location = new Point(700, 110);
            cbMiran.Name = "cbMiran";
            cbMiran.Size = new Size(72, 24);
            cbMiran.TabIndex = 18;
            cbMiran.Text = "Miran";
            cbMiran.UseVisualStyleBackColor = true;
            // 
            // cbNoSmoking
            // 
            cbNoSmoking.AutoSize = true;
            cbNoSmoking.Location = new Point(700, 153);
            cbNoSmoking.Name = "cbNoSmoking";
            cbNoSmoking.Size = new Size(116, 24);
            cbNoSmoking.TabIndex = 19;
            cbNoSmoking.Text = "No smoking";
            cbNoSmoking.UseVisualStyleBackColor = true;
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(713, 375);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(75, 37);
            btnSpasi.TabIndex = 21;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // cbPopunjena
            // 
            cbPopunjena.AutoSize = true;
            cbPopunjena.Location = new Point(302, 301);
            cbPopunjena.Name = "cbPopunjena";
            cbPopunjena.Size = new Size(105, 24);
            cbPopunjena.TabIndex = 22;
            cbPopunjena.Text = "Popunjena";
            cbPopunjena.UseVisualStyleBackColor = true;
            // 
            // cbIzdvojena
            // 
            cbIzdvojena.AutoSize = true;
            cbIzdvojena.Location = new Point(302, 325);
            cbIzdvojena.Name = "cbIzdvojena";
            cbIzdvojena.Size = new Size(98, 24);
            cbIzdvojena.TabIndex = 23;
            cbIzdvojena.Text = "Izdvojena";
            cbIzdvojena.UseVisualStyleBackColor = true;
            // 
            // cbOsvjetljen
            // 
            cbOsvjetljen.AutoSize = true;
            cbOsvjetljen.Location = new Point(592, 153);
            cbOsvjetljen.Name = "cbOsvjetljen";
            cbOsvjetljen.Size = new Size(100, 24);
            cbOsvjetljen.TabIndex = 24;
            cbOsvjetljen.Text = "Osvjetljen";
            cbOsvjetljen.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // ofdSlikaNekretnine
            // 
            ofdSlikaNekretnine.FileName = "openFileDialog1";
            // 
            // cbTihoNaselje
            // 
            cbTihoNaselje.AutoSize = true;
            cbTihoNaselje.Location = new Point(592, 178);
            cbTihoNaselje.Name = "cbTihoNaselje";
            cbTihoNaselje.Size = new Size(117, 24);
            cbTihoNaselje.TabIndex = 25;
            cbTihoNaselje.Text = "Tiho Naselje";
            cbTihoNaselje.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(126, 35);
            button1.TabIndex = 28;
            button1.Text = "<- Nazad";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAddNekretninu
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(802, 424);
            Controls.Add(button1);
            Controls.Add(cbTihoNaselje);
            Controls.Add(cbOsvjetljen);
            Controls.Add(cbIzdvojena);
            Controls.Add(cbPopunjena);
            Controls.Add(btnSpasi);
            Controls.Add(cbNoSmoking);
            Controls.Add(cbMiran);
            Controls.Add(cbNamjestena);
            Controls.Add(cbPetFriendly);
            Controls.Add(label6);
            Controls.Add(txtOpis);
            Controls.Add(Cijena);
            Controls.Add(label5);
            Controls.Add(txtBrojSoba);
            Controls.Add(label4);
            Controls.Add(txtBrojKvadrata);
            Controls.Add(txtGrad);
            Controls.Add(label3);
            Controls.Add(txtCijena);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(btnDodajSliku);
            Controls.Add(pbSlikaNekretnine);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmAddNekretninu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalji nekretnine";
            ((System.ComponentModel.ISupportInitialize)pbSlikaNekretnine).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbSlikaNekretnine;
        private Button btnDodajSliku;
        private Label label2;
        private TextBox txtNaziv;
        private TextBox txtCijena;
        private Label label3;
        private TextBox txtGrad;
        private TextBox txtBrojKvadrata;
        private Label label4;
        private TextBox txtBrojSoba;
        private Label label5;
        private Label Cijena;
        private RichTextBox txtOpis;
        private Label label6;
        private CheckBox cbPetFriendly;
        private CheckBox cbNamjestena;
        private CheckBox cbMiran;
        private CheckBox cbNoSmoking;
        private Button btnSpasi;
        private CheckBox cbPopunjena;
        private CheckBox cbIzdvojena;
        private CheckBox cbOsvjetljen;
        private ErrorProvider err;
        private OpenFileDialog ofdSlikaNekretnine;
        private CheckBox cbTihoNaselje;
        private Button button1;
    }
}