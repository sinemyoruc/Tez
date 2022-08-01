
namespace TezProje
{
    partial class BireyselRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BireyselRegisterForm));
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.buttonKayit = new System.Windows.Forms.Button();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxPass.Location = new System.Drawing.Point(224, 201);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 23);
            this.textBoxPass.TabIndex = 11;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxEmail.Location = new System.Drawing.Point(224, 149);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 23);
            this.textBoxEmail.TabIndex = 10;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.pass.Location = new System.Drawing.Point(77, 204);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(38, 18);
            this.pass.TabIndex = 9;
            this.pass.Text = "Şifre";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.email.Location = new System.Drawing.Point(77, 149);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(45, 18);
            this.email.TabIndex = 8;
            this.email.Text = "Email";
            // 
            // buttonKayit
            // 
            this.buttonKayit.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonKayit.Location = new System.Drawing.Point(145, 313);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(102, 46);
            this.buttonKayit.TabIndex = 12;
            this.buttonKayit.Text = "Kayıt Ol";
            this.buttonKayit.UseVisualStyleBackColor = false;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBoxPass2.Location = new System.Drawing.Point(224, 254);
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.Size = new System.Drawing.Size(100, 23);
            this.textBoxPass2.TabIndex = 14;
            this.textBoxPass2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(77, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Şifre (Tekrar)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bireysel Kayıt";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 569);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.buttonKayit);
            this.panel2.Controls.Add(this.textBoxPass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxPass2);
            this.panel2.Controls.Add(this.pass);
            this.panel2.Location = new System.Drawing.Point(181, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 416);
            this.panel2.TabIndex = 16;
            // 
            // BireyselRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 569);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Name = "BireyselRegisterForm";
            this.Text = "Kayıt";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button buttonKayit;
        private System.Windows.Forms.TextBox textBoxPass2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}