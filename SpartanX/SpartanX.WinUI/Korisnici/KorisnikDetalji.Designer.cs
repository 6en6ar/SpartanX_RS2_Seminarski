
namespace SpartanX.WinUI.Korisnici
{
    partial class KorisnikDetalji
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPotvrdiPass = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.clbUloge = new System.Windows.Forms.CheckedListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPotvrdiPass);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o korisniku";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPotvrdiPass
            // 
            this.txtPotvrdiPass.Location = new System.Drawing.Point(256, 350);
            this.txtPotvrdiPass.Name = "txtPotvrdiPass";
            this.txtPotvrdiPass.Size = new System.Drawing.Size(549, 39);
            this.txtPotvrdiPass.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(256, 296);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(549, 39);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(256, 237);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(549, 39);
            this.txtUsername.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(256, 178);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(549, 39);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(256, 116);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(549, 39);
            this.txtPrezime.TabIndex = 7;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(256, 59);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(549, 39);
            this.txtIme.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Potvrdi password:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(617, 528);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(211, 36);
            this.cbStatus.TabIndex = 1;
            this.cbStatus.Text = "Status korisnika";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 32);
            this.label7.TabIndex = 3;
            this.label7.Text = "Uloge korisnika:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 709);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 73);
            this.button2.TabIndex = 5;
            this.button2.Text = "Spasi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clbUloge
            // 
            this.clbUloge.FormattingEnabled = true;
            this.clbUloge.Location = new System.Drawing.Point(13, 581);
            this.clbUloge.Name = "clbUloge";
            this.clbUloge.Size = new System.Drawing.Size(581, 184);
            this.clbUloge.TabIndex = 6;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // KorisnikDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 803);
            this.Controls.Add(this.clbUloge);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.groupBox1);
            this.Name = "KorisnikDetalji";
            this.Text = "KorisnikDetalji";
            this.Load += new System.EventHandler(this.KorisnikDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtPotvrdiPass;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox clbUloge;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}