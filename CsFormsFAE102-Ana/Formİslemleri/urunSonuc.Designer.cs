
namespace CsFormsFAE102_Ana.Formİslemleri
{
    partial class urunSonuc
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblKdvFiyat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kdv\'li Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kdv Oranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(111, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün Adı";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.Location = new System.Drawing.Point(211, 64);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(161, 20);
            this.lblUrunAd.TabIndex = 11;
            this.lblUrunAd.Text = "label5";
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.Location = new System.Drawing.Point(211, 109);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(198, 21);
            this.lblUrunFiyat.TabIndex = 11;
            this.lblUrunFiyat.Text = "label5";
            // 
            // lblKdv
            // 
            this.lblKdv.Location = new System.Drawing.Point(211, 145);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(198, 37);
            this.lblKdv.TabIndex = 11;
            this.lblKdv.Text = "label5";
            // 
            // lblKdvFiyat
            // 
            this.lblKdvFiyat.Location = new System.Drawing.Point(211, 182);
            this.lblKdvFiyat.Name = "lblKdvFiyat";
            this.lblKdvFiyat.Size = new System.Drawing.Size(198, 27);
            this.lblKdvFiyat.TabIndex = 11;
            this.lblKdvFiyat.Text = "label5";
            // 
            // urunSonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKdvFiyat);
            this.Controls.Add(this.lblKdv);
            this.Controls.Add(this.lblUrunFiyat);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "urunSonuc";
            this.Text = "urunSonuc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUrunAd;
        public System.Windows.Forms.Label lblUrunFiyat;
        public System.Windows.Forms.Label lblKdv;
        public System.Windows.Forms.Label lblKdvFiyat;
    }
}