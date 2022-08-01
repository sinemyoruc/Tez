
namespace TezProje
{
    partial class KurumsalPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KurumsalPage));
            this.buttonIlan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAra = new System.Windows.Forms.Button();
            this.textBoxArama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonIlan
            // 
            this.buttonIlan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonIlan.Location = new System.Drawing.Point(1026, 22);
            this.buttonIlan.Name = "buttonIlan";
            this.buttonIlan.Size = new System.Drawing.Size(130, 40);
            this.buttonIlan.TabIndex = 0;
            this.buttonIlan.Text = "İş İlanı Yayınla";
            this.buttonIlan.UseVisualStyleBackColor = false;
            this.buttonIlan.Click += new System.EventHandler(this.buttonIlan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(360, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "ÖZGEÇMİŞLER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.OldLace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(83, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // buttonAra
            // 
            this.buttonAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAra.Location = new System.Drawing.Point(750, 21);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(85, 41);
            this.buttonAra.TabIndex = 6;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = false;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // textBoxArama
            // 
            this.textBoxArama.Location = new System.Drawing.Point(198, 27);
            this.textBoxArama.Name = "textBoxArama";
            this.textBoxArama.Size = new System.Drawing.Size(546, 22);
            this.textBoxArama.TabIndex = 4;
            // 
            // KurumsalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1245, 975);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.textBoxArama);
            this.Controls.Add(this.buttonIlan);
            this.Name = "KurumsalPage";
            this.Text = "KurumsalPage";
            this.Load += new System.EventHandler(this.KurumsalPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.TextBox textBoxArama;
    }
}