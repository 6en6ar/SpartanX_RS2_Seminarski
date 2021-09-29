
namespace SpartanX.WinUI.Skladista
{
    partial class frmSkladisteDetalji
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSpasiSkladiste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(132, 49);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(390, 39);
            this.txtNaziv.TabIndex = 0;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(132, 134);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(390, 39);
            this.txtAdresa.TabIndex = 1;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(132, 212);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(390, 39);
            this.txtOpis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis:";
            // 
            // btnSpasiSkladiste
            // 
            this.btnSpasiSkladiste.Location = new System.Drawing.Point(372, 309);
            this.btnSpasiSkladiste.Name = "btnSpasiSkladiste";
            this.btnSpasiSkladiste.Size = new System.Drawing.Size(150, 46);
            this.btnSpasiSkladiste.TabIndex = 6;
            this.btnSpasiSkladiste.Text = "Spasi";
            this.btnSpasiSkladiste.UseVisualStyleBackColor = true;
            this.btnSpasiSkladiste.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSkladisteDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 459);
            this.Controls.Add(this.btnSpasiSkladiste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNaziv);
            this.Name = "frmSkladisteDetalji";
            this.Text = "frmSkladisteDetalji";
            this.Load += new System.EventHandler(this.frmSkladisteDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSpasiSkladiste;
    }
}