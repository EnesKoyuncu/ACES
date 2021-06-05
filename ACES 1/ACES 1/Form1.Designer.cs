
namespace ACES_1
{
    partial class Form1
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
            this.btnAc = new System.Windows.Forms.Button();
            this.btnKapa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(181, 94);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(141, 79);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnKapa
            // 
            this.btnKapa.Location = new System.Drawing.Point(363, 94);
            this.btnKapa.Name = "btnKapa";
            this.btnKapa.Size = new System.Drawing.Size(141, 79);
            this.btnKapa.TabIndex = 1;
            this.btnKapa.Text = "kapa";
            this.btnKapa.UseVisualStyleBackColor = true;
            this.btnKapa.Click += new System.EventHandler(this.btnKapa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKapa);
            this.Controls.Add(this.btnAc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnKapa;
    }
}

