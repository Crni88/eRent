namespace eRent.UI
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSlikaNekretnine = new System.Windows.Forms.PictureBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtBrojKvadrata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojSoba = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cijena = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPetFriendly = new System.Windows.Forms.CheckBox();
            this.cbNamjestena = new System.Windows.Forms.CheckBox();
            this.cbMiran = new System.Windows.Forms.CheckBox();
            this.cbNoSmoking = new System.Windows.Forms.CheckBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.cbPopunjena = new System.Windows.Forms.CheckBox();
            this.cbIzdvojena = new System.Windows.Forms.CheckBox();
            this.cbOsvjetljen = new System.Windows.Forms.CheckBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaNekretnine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj novu nekretninu";
            // 
            // pbSlikaNekretnine
            // 
            this.pbSlikaNekretnine.Location = new System.Drawing.Point(12, 27);
            this.pbSlikaNekretnine.Name = "pbSlikaNekretnine";
            this.pbSlikaNekretnine.Size = new System.Drawing.Size(250, 342);
            this.pbSlikaNekretnine.TabIndex = 1;
            this.pbSlikaNekretnine.TabStop = false;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(95, 375);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 2;
            this.btnDodajSliku.Text = "Dodaj Sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unesi Naziv*";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(302, 45);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(207, 23);
            this.txtNaziv.TabIndex = 5;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(592, 45);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(196, 23);
            this.txtCijena.TabIndex = 6;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grad";
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(302, 108);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(207, 23);
            this.txtGrad.TabIndex = 8;
            // 
            // txtBrojKvadrata
            // 
            this.txtBrojKvadrata.Location = new System.Drawing.Point(302, 166);
            this.txtBrojKvadrata.Name = "txtBrojKvadrata";
            this.txtBrojKvadrata.Size = new System.Drawing.Size(207, 23);
            this.txtBrojKvadrata.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Broj kvadrata";
            // 
            // txtBrojSoba
            // 
            this.txtBrojSoba.Location = new System.Drawing.Point(302, 237);
            this.txtBrojSoba.Name = "txtBrojSoba";
            this.txtBrojSoba.Size = new System.Drawing.Size(207, 23);
            this.txtBrojSoba.TabIndex = 11;
            this.txtBrojSoba.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojSoba_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Broj soba*";
            // 
            // Cijena
            // 
            this.Cijena.AutoSize = true;
            this.Cijena.Location = new System.Drawing.Point(592, 27);
            this.Cijena.Name = "Cijena";
            this.Cijena.Size = new System.Drawing.Size(45, 15);
            this.Cijena.TabIndex = 13;
            this.Cijena.Text = "Cijena*";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(546, 237);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(242, 132);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Detaljan opis";
            // 
            // cbPetFriendly
            // 
            this.cbPetFriendly.AutoSize = true;
            this.cbPetFriendly.Location = new System.Drawing.Point(592, 110);
            this.cbPetFriendly.Name = "cbPetFriendly";
            this.cbPetFriendly.Size = new System.Drawing.Size(88, 19);
            this.cbPetFriendly.TabIndex = 16;
            this.cbPetFriendly.Text = "Pet Friendly";
            this.cbPetFriendly.UseVisualStyleBackColor = true;
            // 
            // cbNamjestena
            // 
            this.cbNamjestena.AutoSize = true;
            this.cbNamjestena.Location = new System.Drawing.Point(302, 277);
            this.cbNamjestena.Name = "cbNamjestena";
            this.cbNamjestena.Size = new System.Drawing.Size(89, 19);
            this.cbNamjestena.TabIndex = 17;
            this.cbNamjestena.Text = "Namještena";
            this.cbNamjestena.UseVisualStyleBackColor = true;
            // 
            // cbMiran
            // 
            this.cbMiran.AutoSize = true;
            this.cbMiran.Location = new System.Drawing.Point(700, 110);
            this.cbMiran.Name = "cbMiran";
            this.cbMiran.Size = new System.Drawing.Size(57, 19);
            this.cbMiran.TabIndex = 18;
            this.cbMiran.Text = "Miran";
            this.cbMiran.UseVisualStyleBackColor = true;
            // 
            // cbNoSmoking
            // 
            this.cbNoSmoking.AutoSize = true;
            this.cbNoSmoking.Location = new System.Drawing.Point(700, 153);
            this.cbNoSmoking.Name = "cbNoSmoking";
            this.cbNoSmoking.Size = new System.Drawing.Size(91, 19);
            this.cbNoSmoking.TabIndex = 19;
            this.cbNoSmoking.Text = "No smoking";
            this.cbNoSmoking.UseVisualStyleBackColor = true;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(713, 415);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 21;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // cbPopunjena
            // 
            this.cbPopunjena.AutoSize = true;
            this.cbPopunjena.Location = new System.Drawing.Point(302, 301);
            this.cbPopunjena.Name = "cbPopunjena";
            this.cbPopunjena.Size = new System.Drawing.Size(83, 19);
            this.cbPopunjena.TabIndex = 22;
            this.cbPopunjena.Text = "Popunjena";
            this.cbPopunjena.UseVisualStyleBackColor = true;
            // 
            // cbIzdvojena
            // 
            this.cbIzdvojena.AutoSize = true;
            this.cbIzdvojena.Location = new System.Drawing.Point(302, 325);
            this.cbIzdvojena.Name = "cbIzdvojena";
            this.cbIzdvojena.Size = new System.Drawing.Size(76, 19);
            this.cbIzdvojena.TabIndex = 23;
            this.cbIzdvojena.Text = "Izdvojena";
            this.cbIzdvojena.UseVisualStyleBackColor = true;
            // 
            // cbOsvjetljen
            // 
            this.cbOsvjetljen.AutoSize = true;
            this.cbOsvjetljen.Location = new System.Drawing.Point(592, 153);
            this.cbOsvjetljen.Name = "cbOsvjetljen";
            this.cbOsvjetljen.Size = new System.Drawing.Size(78, 19);
            this.cbOsvjetljen.TabIndex = 24;
            this.cbOsvjetljen.Text = "Osvjetljen";
            this.cbOsvjetljen.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmAddNekretninu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbOsvjetljen);
            this.Controls.Add(this.cbIzdvojena);
            this.Controls.Add(this.cbPopunjena);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.cbNoSmoking);
            this.Controls.Add(this.cbMiran);
            this.Controls.Add(this.cbNamjestena);
            this.Controls.Add(this.cbPetFriendly);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Cijena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrojSoba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrojKvadrata);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.pbSlikaNekretnine);
            this.Controls.Add(this.label1);
            this.Name = "frmAddNekretninu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novu nekretninu";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaNekretnine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
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
        private RichTextBox richTextBox1;
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
    }
}