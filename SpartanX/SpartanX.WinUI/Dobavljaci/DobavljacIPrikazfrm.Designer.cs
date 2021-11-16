
namespace SpartanX.WinUI.Dobavljaci
{
    partial class DobavljacIPrikazfrm
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
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            this.txtDobavljaci = new System.Windows.Forms.TextBox();
            this.btnPrikaziDob = new System.Windows.Forms.Button();
            this.btnDodajDob = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDobavljaci);
            this.groupBox1.Location = new System.Drawing.Point(9, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1224, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DobavljaciPrikaz";
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDobavljaci.Location = new System.Drawing.Point(3, 35);
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.RowHeadersWidth = 82;
            this.dgvDobavljaci.RowTemplate.Height = 41;
            this.dgvDobavljaci.Size = new System.Drawing.Size(1218, 286);
            this.dgvDobavljaci.TabIndex = 0;
            // 
            // txtDobavljaci
            // 
            this.txtDobavljaci.BackColor = System.Drawing.SystemColors.Info;
            this.txtDobavljaci.Location = new System.Drawing.Point(12, 66);
            this.txtDobavljaci.Name = "txtDobavljaci";
            this.txtDobavljaci.Size = new System.Drawing.Size(986, 39);
            this.txtDobavljaci.TabIndex = 1;
            // 
            // btnPrikaziDob
            // 
            this.btnPrikaziDob.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrikaziDob.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrikaziDob.Location = new System.Drawing.Point(1025, 66);
            this.btnPrikaziDob.Name = "btnPrikaziDob";
            this.btnPrikaziDob.Size = new System.Drawing.Size(205, 46);
            this.btnPrikaziDob.TabIndex = 2;
            this.btnPrikaziDob.Text = "Prikazi";
            this.btnPrikaziDob.UseVisualStyleBackColor = false;
            this.btnPrikaziDob.Click += new System.EventHandler(this.btnPrikaziDob_Click);
            // 
            // btnDodajDob
            // 
            this.btnDodajDob.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDodajDob.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodajDob.Location = new System.Drawing.Point(1025, 506);
            this.btnDodajDob.Name = "btnDodajDob";
            this.btnDodajDob.Size = new System.Drawing.Size(205, 46);
            this.btnDodajDob.TabIndex = 3;
            this.btnDodajDob.Text = "Dodaj novog";
            this.btnDodajDob.UseVisualStyleBackColor = false;
            this.btnDodajDob.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Traži:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DobavljacIPrikazfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajDob);
            this.Controls.Add(this.btnPrikaziDob);
            this.Controls.Add(this.txtDobavljaci);
            this.Controls.Add(this.groupBox1);
            this.Name = "DobavljacIPrikazfrm";
            this.Text = "DobavljacIPrikazfrm";
            this.Load += new System.EventHandler(this.DobavljacIPrikazfrm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDobavljaci;
        private System.Windows.Forms.TextBox txtDobavljaci;
        private System.Windows.Forms.Button btnPrikaziDob;
        private System.Windows.Forms.Button btnDodajDob;
        private System.Windows.Forms.Label label1;
    }
}