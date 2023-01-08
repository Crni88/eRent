namespace eRent.UI
{
    partial class frmNekretninaList
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
            System.Windows.Forms.Button btnShowNekretnine;
            this.dgvNekretnineList = new System.Windows.Forms.DataGridView();
            btnShowNekretnine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNekretnineList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowNekretnine
            // 
            btnShowNekretnine.Location = new System.Drawing.Point(713, 12);
            btnShowNekretnine.Name = "btnShowNekretnine";
            btnShowNekretnine.Size = new System.Drawing.Size(75, 23);
            btnShowNekretnine.TabIndex = 1;
            btnShowNekretnine.Text = "Show";
            btnShowNekretnine.UseVisualStyleBackColor = true;
            btnShowNekretnine.Click += new System.EventHandler(this.btnShowNekretnine_Click);
            // 
            // dgvNekretnineList
            // 
            this.dgvNekretnineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNekretnineList.Location = new System.Drawing.Point(12, 91);
            this.dgvNekretnineList.Name = "dgvNekretnineList";
            this.dgvNekretnineList.RowTemplate.Height = 25;
            this.dgvNekretnineList.Size = new System.Drawing.Size(776, 347);
            this.dgvNekretnineList.TabIndex = 0;
            this.dgvNekretnineList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmNekretninaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnShowNekretnine);
            this.Controls.Add(this.dgvNekretnineList);
            this.Name = "frmNekretninaList";
            this.Text = "frmNekretninaList";
            this.Load += new System.EventHandler(this.frmNekretninaList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNekretnineList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvNekretnineList;
    }
}