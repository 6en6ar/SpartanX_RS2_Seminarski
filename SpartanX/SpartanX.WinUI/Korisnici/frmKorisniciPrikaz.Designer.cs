
namespace SpartanX.WinUI.Korisnici
{
    partial class frmKorisniciPrikaz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKorisniciPrikaz = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikaziKorisnike = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciPrikaz)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKorisniciPrikaz);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1317, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KorisniciGB";
            // 
            // dgvKorisniciPrikaz
            // 
            this.dgvKorisniciPrikaz.AllowUserToAddRows = false;
            this.dgvKorisniciPrikaz.AllowUserToDeleteRows = false;
            this.dgvKorisniciPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisniciPrikaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisniciPrikaz.Location = new System.Drawing.Point(3, 35);
            this.dgvKorisniciPrikaz.Name = "dgvKorisniciPrikaz";
            this.dgvKorisniciPrikaz.ReadOnly = true;
            this.dgvKorisniciPrikaz.RowHeadersWidth = 82;
            this.dgvKorisniciPrikaz.RowTemplate.Height = 41;
            this.dgvKorisniciPrikaz.Size = new System.Drawing.Size(1311, 328);
            this.dgvKorisniciPrikaz.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnPrikaziKorisnike);
            this.groupBox2.Controls.Add(this.txtIme);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1314, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PretragaKorisnika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime";
            // 
            // btnPrikaziKorisnike
            // 
            this.btnPrikaziKorisnike.Location = new System.Drawing.Point(973, 105);
            this.btnPrikaziKorisnike.Name = "btnPrikaziKorisnike";
            this.btnPrikaziKorisnike.Size = new System.Drawing.Size(344, 46);
            this.btnPrikaziKorisnike.TabIndex = 1;
            this.btnPrikaziKorisnike.Text = "Prikazi";
            this.btnPrikaziKorisnike.UseVisualStyleBackColor = true;
            this.btnPrikaziKorisnike.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(6, 109);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(897, 39);
            this.txtIme.TabIndex = 0;
            // 
            // frmKorisniciPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKorisniciPrikaz";
            this.Text = "frmKorisniciPrikaz";
            this.Load += new System.EventHandler(this.frmKorisniciPrikaz_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciPrikaz)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKorisniciPrikaz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrikaziKorisnike;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
    }
}