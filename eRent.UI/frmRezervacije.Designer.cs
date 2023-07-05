namespace eRent.UI
{
    partial class frmRezervacije
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
            label1 = new Label();
            dgvRezervacije = new DataGridView();
            Naslov = new DataGridViewTextBoxColumn();
            Komentar = new DataGridViewTextBoxColumn();
            PaymentId = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            isProcessed = new DataGridViewCheckBoxColumn();
            btnLoadRezervacije = new Button();
            lblImeNekretnine = new Label();
            lblNemaPlacanja = new Label();
            btnNazad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRezervacije).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 0;
            label1.Text = "Rezervacije za";
            // 
            // dgvRezervacije
            // 
            dgvRezervacije.AllowUserToAddRows = false;
            dgvRezervacije.AllowUserToDeleteRows = false;
            dgvRezervacije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezervacije.Columns.AddRange(new DataGridViewColumn[] { Naslov, Komentar, PaymentId, Iznos, isProcessed });
            dgvRezervacije.Location = new Point(15, 68);
            dgvRezervacije.Name = "dgvRezervacije";
            dgvRezervacije.ReadOnly = true;
            dgvRezervacije.RowTemplate.Height = 25;
            dgvRezervacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRezervacije.Size = new Size(776, 370);
            dgvRezervacije.TabIndex = 1;
            // 
            // Naslov
            // 
            Naslov.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naslov.DataPropertyName = "Naslov";
            Naslov.HeaderText = "Naslov";
            Naslov.Name = "Naslov";
            Naslov.ReadOnly = true;
            // 
            // Komentar
            // 
            Komentar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Komentar.DataPropertyName = "Komentar";
            Komentar.HeaderText = "Komentar";
            Komentar.Name = "Komentar";
            Komentar.ReadOnly = true;
            // 
            // PaymentId
            // 
            PaymentId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PaymentId.DataPropertyName = "PaymentId";
            PaymentId.HeaderText = "Payment Id";
            PaymentId.Name = "PaymentId";
            PaymentId.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Iznos";
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // isProcessed
            // 
            isProcessed.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            isProcessed.DataPropertyName = "isProcessed";
            isProcessed.HeaderText = "Placena";
            isProcessed.Name = "isProcessed";
            isProcessed.ReadOnly = true;
            isProcessed.Width = 54;
            // 
            // btnLoadRezervacije
            // 
            btnLoadRezervacije.Location = new Point(713, 35);
            btnLoadRezervacije.Name = "btnLoadRezervacije";
            btnLoadRezervacije.Size = new Size(75, 23);
            btnLoadRezervacije.TabIndex = 2;
            btnLoadRezervacije.Text = "Ucitaj";
            btnLoadRezervacije.UseVisualStyleBackColor = true;
            btnLoadRezervacije.Click += btnLoadRezervacije_Click;
            // 
            // lblImeNekretnine
            // 
            lblImeNekretnine.AutoSize = true;
            lblImeNekretnine.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblImeNekretnine.Location = new Point(238, 27);
            lblImeNekretnine.Name = "lblImeNekretnine";
            lblImeNekretnine.Size = new Size(0, 30);
            lblImeNekretnine.TabIndex = 3;
            // 
            // lblNemaPlacanja
            // 
            lblNemaPlacanja.AutoSize = true;
            lblNemaPlacanja.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNemaPlacanja.Location = new Point(105, 230);
            lblNemaPlacanja.Name = "lblNemaPlacanja";
            lblNemaPlacanja.Size = new Size(0, 32);
            lblNemaPlacanja.TabIndex = 30;
            // 
            // btnNazad
            // 
            btnNazad.Location = new Point(12, 5);
            btnNazad.Name = "btnNazad";
            btnNazad.Size = new Size(75, 23);
            btnNazad.TabIndex = 31;
            btnNazad.Text = "<- Nazad";
            btnNazad.UseVisualStyleBackColor = true;
            btnNazad.Click += btnNazad_Click;
            // 
            // frmRezervacije
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNazad);
            Controls.Add(lblNemaPlacanja);
            Controls.Add(lblImeNekretnine);
            Controls.Add(btnLoadRezervacije);
            Controls.Add(dgvRezervacije);
            Controls.Add(label1);
            Name = "frmRezervacije";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezervacije";
            Load += frmRezervacije_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRezervacije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvRezervacije;
        private Button btnRezervacije;
        private Button btnLoadRezervacije;
        private DataGridViewTextBoxColumn Naslov;
        private DataGridViewTextBoxColumn Komentar;
        private DataGridViewTextBoxColumn PaymentId;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewCheckBoxColumn isProcessed;
        private Label lblImeNekretnine;
        private Label lblNemaPlacanja;
        private Button btnNazad;
    }
}