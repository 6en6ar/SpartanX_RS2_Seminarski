
namespace SpartanX.WinUI.Proizvodi
{
    partial class frmProizvodiPrikaz
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
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.txtProizvodi = new System.Windows.Forms.TextBox();
            this.btnProizvodi = new System.Windows.Forms.Button();
            this.cmbvrsta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNoviPro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProizvodi);
            this.groupBox1.Location = new System.Drawing.Point(2, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1277, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ProizvodiPrikaz";
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProizvodi.Location = new System.Drawing.Point(3, 35);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 82;
            this.dgvProizvodi.RowTemplate.Height = 41;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(1271, 341);
            this.dgvProizvodi.TabIndex = 0;
            this.dgvProizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellContentClick);
            this.dgvProizvodi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellDoubleClick);
            // 
            // txtProizvodi
            // 
            this.txtProizvodi.Location = new System.Drawing.Point(139, 51);
            this.txtProizvodi.Name = "txtProizvodi";
            this.txtProizvodi.Size = new System.Drawing.Size(442, 39);
            this.txtProizvodi.TabIndex = 1;
            // 
            // btnProizvodi
            // 
            this.btnProizvodi.Location = new System.Drawing.Point(1117, 54);
            this.btnProizvodi.Name = "btnProizvodi";
            this.btnProizvodi.Size = new System.Drawing.Size(150, 46);
            this.btnProizvodi.TabIndex = 2;
            this.btnProizvodi.Text = "Prikazi";
            this.btnProizvodi.UseVisualStyleBackColor = true;
            this.btnProizvodi.Click += new System.EventHandler(this.btnProizvodi_Click);
            // 
            // cmbvrsta
            // 
            this.cmbvrsta.FormattingEnabled = true;
            this.cmbvrsta.Location = new System.Drawing.Point(815, 54);
            this.cmbvrsta.Name = "cmbvrsta";
            this.cmbvrsta.Size = new System.Drawing.Size(242, 40);
            this.cmbvrsta.TabIndex = 3;
            this.cmbvrsta.SelectedIndexChanged += new System.EventHandler(this.cmbvrsta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vrsta proizvoda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv:";
            // 
            // btnNoviPro
            // 
            this.btnNoviPro.Location = new System.Drawing.Point(1033, 510);
            this.btnNoviPro.Name = "btnNoviPro";
            this.btnNoviPro.Size = new System.Drawing.Size(243, 64);
            this.btnNoviPro.TabIndex = 6;
            this.btnNoviPro.Text = "Novi proizvod";
            this.btnNoviPro.UseVisualStyleBackColor = true;
            this.btnNoviPro.Click += new System.EventHandler(this.btnNoviPro_Click);
            // 
            // frmProizvodiPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 586);
            this.Controls.Add(this.btnNoviPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbvrsta);
            this.Controls.Add(this.btnProizvodi);
            this.Controls.Add(this.txtProizvodi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProizvodiPrikaz";
            this.Text = "frmProizvodiPrikaz";
            this.Load += new System.EventHandler(this.frmProizvodiPrikaz_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.TextBox txtProizvodi;
        private System.Windows.Forms.Button btnProizvodi;
        private System.Windows.Forms.ComboBox cmbvrsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNoviPro;
    }
}