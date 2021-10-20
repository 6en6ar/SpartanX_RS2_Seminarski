
namespace SpartanX.WinUI.Narudzbe
{
    partial class NarudzbePrikaz
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
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.PrikazNarudzbi = new System.Windows.Forms.Button();
            this.txtPregled = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Location = new System.Drawing.Point(13, 151);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.RowHeadersWidth = 82;
            this.dgvNarudzbe.RowTemplate.Height = 41;
            this.dgvNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbe.Size = new System.Drawing.Size(1338, 350);
            this.dgvNarudzbe.TabIndex = 0;
            this.dgvNarudzbe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellContentClick);
            this.dgvNarudzbe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellDoubleClick);
            // 
            // PrikazNarudzbi
            // 
            this.PrikazNarudzbi.Location = new System.Drawing.Point(1118, 68);
            this.PrikazNarudzbi.Name = "PrikazNarudzbi";
            this.PrikazNarudzbi.Size = new System.Drawing.Size(233, 46);
            this.PrikazNarudzbi.TabIndex = 1;
            this.PrikazNarudzbi.Text = "Pregled po kodu";
            this.PrikazNarudzbi.UseVisualStyleBackColor = true;
            this.PrikazNarudzbi.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPregled
            // 
            this.txtPregled.Location = new System.Drawing.Point(13, 75);
            this.txtPregled.Name = "txtPregled";
            this.txtPregled.Size = new System.Drawing.Size(1059, 39);
            this.txtPregled.TabIndex = 2;
            // 
            // NarudzbePrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 513);
            this.Controls.Add(this.txtPregled);
            this.Controls.Add(this.PrikazNarudzbi);
            this.Controls.Add(this.dgvNarudzbe);
            this.Name = "NarudzbePrikaz";
            this.Text = "NarudzbePrikaz";
            this.Load += new System.EventHandler(this.NarudzbePrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.Button PrikazNarudzbi;
        private System.Windows.Forms.TextBox txtPregled;
    }
}