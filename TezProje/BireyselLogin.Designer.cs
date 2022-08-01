
namespace TezProje
{
    partial class BireyselLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BireyselLogin));
            this.email = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.PapayaWhip;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(77, 159);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(51, 20);
            this.email.TabIndex = 0;
            this.email.Text = "Email";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.BackColor = System.Drawing.Color.PapayaWhip;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.pass.ForeColor = System.Drawing.Color.Black;
            this.pass.Location = new System.Drawing.Point(77, 211);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(44, 20);
            this.pass.TabIndex = 2;
            this.pass.Text = "Şifre";
            // 
            // buttonGiris
            // 
            this.buttonGiris.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGiris.ForeColor = System.Drawing.Color.Black;
            this.buttonGiris.Location = new System.Drawing.Point(118, 277);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(121, 54);
            this.buttonGiris.TabIndex = 4;
            this.buttonGiris.Text = "Giriş Yap";
            this.buttonGiris.UseVisualStyleBackColor = false;
            this.buttonGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(179, 159);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(179, 209);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 22);
            this.textBoxPass.TabIndex = 7;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bireysel Giriş";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 566);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonGiris);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.pass);
            this.panel2.Controls.Add(this.textBoxPass);
            this.panel2.Location = new System.Drawing.Point(202, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 433);
            this.panel2.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(50, 358);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(264, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hesabınız yoksa kaydolmak için tıklayınız";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BireyselLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 567);
            this.Controls.Add(this.panel1);
            this.Name = "BireyselLogin";
            this.Text = "Giriş";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}