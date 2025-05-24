namespace Selam
{
    partial class bSelam
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.bSelamla = new System.Windows.Forms.Button();
            this.bKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Adınız:";
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(84, 42);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(136, 26);
            this.tbAd.TabIndex = 1;
            // 
            // bSelamla
            // 
            this.bSelamla.Location = new System.Drawing.Point(114, 108);
            this.bSelamla.Name = "bSelamla";
            this.bSelamla.Size = new System.Drawing.Size(75, 35);
            this.bSelamla.TabIndex = 2;
            this.bSelamla.Text = "&Selamla";
            this.bSelamla.UseVisualStyleBackColor = true;
            this.bSelamla.Click += new System.EventHandler(this.bSelamla_Click);
            // 
            // bKapat
            // 
            this.bKapat.Location = new System.Drawing.Point(114, 161);
            this.bKapat.Name = "bKapat";
            this.bKapat.Size = new System.Drawing.Size(75, 30);
            this.bKapat.TabIndex = 3;
            this.bKapat.Text = "&Kapat:";
            this.bKapat.UseVisualStyleBackColor = true;
            this.bKapat.Click += new System.EventHandler(this.bKapat_Click);
            // 
            // bSelam
            // 
            this.AcceptButton = this.bSelamla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bKapat;
            this.ClientSize = new System.Drawing.Size(359, 283);
            this.Controls.Add(this.bKapat);
            this.Controls.Add(this.bSelamla);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.label1);
            this.Name = "bSelam";
            this.Text = "Selam";
            this.Load += new System.EventHandler(this.bSelam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Button bSelamla;
        private System.Windows.Forms.Button bKapat;
    }
}

