
namespace TezProje
{
    partial class BireyselPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BireyselPage));
            this.textBoxArama = new System.Windows.Forms.TextBox();
            this.buttonAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxArama
            // 
            this.textBoxArama.Location = new System.Drawing.Point(155, 32);
            this.textBoxArama.Name = "textBoxArama";
            this.textBoxArama.Size = new System.Drawing.Size(546, 22);
            this.textBoxArama.TabIndex = 0;
            // 
            // buttonAra
            // 
            this.buttonAra.BackColor = System.Drawing.Color.Snow;
            this.buttonAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonAra.Location = new System.Drawing.Point(707, 21);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(85, 42);
            this.buttonAra.TabIndex = 1;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = false;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(380, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "İŞ İLANLARI";
            // 
            // buttonCV
            // 
            this.buttonCV.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonCV.Location = new System.Drawing.Point(1026, 21);
            this.buttonCV.Name = "buttonCV";
            this.buttonCV.Size = new System.Drawing.Size(153, 42);
            this.buttonCV.TabIndex = 3;
            this.buttonCV.Text = "CV Ekle";
            this.buttonCV.UseVisualStyleBackColor = false;
            this.buttonCV.Click += new System.EventHandler(this.buttonCV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // BireyselPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1213, 915);
            this.Controls.Add(this.textBoxArama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.buttonCV);
            this.Controls.Add(this.label1);
            this.Name = "BireyselPage";
            this.Text = "BireyselPage";
            this.Load += new System.EventHandler(this.BireyselPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxArama;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCV;
        private System.Windows.Forms.Label label2;
    }
}