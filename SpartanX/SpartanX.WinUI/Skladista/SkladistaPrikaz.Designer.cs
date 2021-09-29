
namespace SpartanX.WinUI.Skladista
{
    partial class SkladistaPrikaz
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
            this.dgvSkladista = new System.Windows.Forms.DataGridView();
            this.btnPrikaziSkl = new System.Windows.Forms.Button();
            this.txtSkladista = new System.Windows.Forms.TextBox();
            this.btnNovoSkladiste = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSkladista);
            this.groupBox1.Location = new System.Drawing.Point(13, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1274, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SklPrikazgb";
            // 
            // dgvSkladista
            // 
            this.dgvSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkladista.Location = new System.Drawing.Point(3, 35);
            this.dgvSkladista.Name = "dgvSkladista";
            this.dgvSkladista.RowHeadersWidth = 82;
            this.dgvSkladista.RowTemplate.Height = 41;
            this.dgvSkladista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkladista.Size = new System.Drawing.Size(1268, 280);
            this.dgvSkladista.TabIndex = 0;
            this.dgvSkladista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkladista_CellDoubleClick);
            // 
            // btnPrikaziSkl
            // 
            this.btnPrikaziSkl.Location = new System.Drawing.Point(966, 124);
            this.btnPrikaziSkl.Name = "btnPrikaziSkl";
            this.btnPrikaziSkl.Size = new System.Drawing.Size(318, 46);
            this.btnPrikaziSkl.TabIndex = 1;
            this.btnPrikaziSkl.Text = "Prikazi";
            this.btnPrikaziSkl.UseVisualStyleBackColor = true;
            this.btnPrikaziSkl.Click += new System.EventHandler(this.btnPrikaziSkl_Click);
            // 
            // txtSkladista
            // 
            this.txtSkladista.Location = new System.Drawing.Point(16, 131);
            this.txtSkladista.Name = "txtSkladista";
            this.txtSkladista.Size = new System.Drawing.Size(933, 39);
            this.txtSkladista.TabIndex = 2;
            // 
            // btnNovoSkladiste
            // 
            this.btnNovoSkladiste.Location = new System.Drawing.Point(966, 544);
            this.btnNovoSkladiste.Name = "btnNovoSkladiste";
            this.btnNovoSkladiste.Size = new System.Drawing.Size(321, 46);
            this.btnNovoSkladiste.TabIndex = 3;
            this.btnNovoSkladiste.Text = "Novo skladiste";
            this.btnNovoSkladiste.UseVisualStyleBackColor = true;
            this.btnNovoSkladiste.Click += new System.EventHandler(this.button1_Click);
            // 
            // SkladistaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 602);
            this.Controls.Add(this.btnNovoSkladiste);
            this.Controls.Add(this.txtSkladista);
            this.Controls.Add(this.btnPrikaziSkl);
            this.Controls.Add(this.groupBox1);
            this.Name = "SkladistaPrikaz";
            this.Text = "SkladistaPrikaz";
            this.Load += new System.EventHandler(this.SkladistaPrikaz_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSkladista;
        private System.Windows.Forms.Button btnPrikaziSkl;
        private System.Windows.Forms.TextBox txtSkladista;
        private System.Windows.Forms.Button btnNovoSkladiste;
    }
}