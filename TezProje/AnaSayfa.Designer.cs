
namespace TezProje
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bireysel = new System.Windows.Forms.Button();
            this.kurumsal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bireysel);
            this.panel1.Controls.Add(this.kurumsal);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 751);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 30.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(203, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kariyer Sitesine Hoşgeldiniz";
            // 
            // bireysel
            // 
            this.bireysel.BackColor = System.Drawing.Color.PeachPuff;
            this.bireysel.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bireysel.Location = new System.Drawing.Point(531, 411);
            this.bireysel.Name = "bireysel";
            this.bireysel.Size = new System.Drawing.Size(214, 87);
            this.bireysel.TabIndex = 4;
            this.bireysel.Text = "Bireysel Giriş";
            this.bireysel.UseVisualStyleBackColor = false;
            this.bireysel.Click += new System.EventHandler(this.bireysel_Click_1);
            // 
            // kurumsal
            // 
            this.kurumsal.BackColor = System.Drawing.Color.LightSalmon;
            this.kurumsal.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold);
            this.kurumsal.Location = new System.Drawing.Point(242, 411);
            this.kurumsal.Name = "kurumsal";
            this.kurumsal.Size = new System.Drawing.Size(252, 87);
            this.kurumsal.TabIndex = 3;
            this.kurumsal.Text = "Kurumsal Giriş";
            this.kurumsal.UseVisualStyleBackColor = false;
            this.kurumsal.Click += new System.EventHandler(this.kurumsal_Click_1);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 751);
            this.Controls.Add(this.panel1);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bireysel;
        private System.Windows.Forms.Button kurumsal;
    }
}

