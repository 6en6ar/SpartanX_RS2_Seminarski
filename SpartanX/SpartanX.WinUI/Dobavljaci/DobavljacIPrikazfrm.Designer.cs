﻿
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDobavljaci);
            this.groupBox1.Location = new System.Drawing.Point(12, 228);
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
            this.txtDobavljaci.Location = new System.Drawing.Point(15, 157);
            this.txtDobavljaci.Name = "txtDobavljaci";
            this.txtDobavljaci.Size = new System.Drawing.Size(986, 39);
            this.txtDobavljaci.TabIndex = 1;
            // 
            // btnPrikaziDob
            // 
            this.btnPrikaziDob.Location = new System.Drawing.Point(1028, 157);
            this.btnPrikaziDob.Name = "btnPrikaziDob";
            this.btnPrikaziDob.Size = new System.Drawing.Size(205, 46);
            this.btnPrikaziDob.TabIndex = 2;
            this.btnPrikaziDob.Text = "Prikazi";
            this.btnPrikaziDob.UseVisualStyleBackColor = true;
            // 
            // DobavljacIPrikazfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 564);
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
    }
}