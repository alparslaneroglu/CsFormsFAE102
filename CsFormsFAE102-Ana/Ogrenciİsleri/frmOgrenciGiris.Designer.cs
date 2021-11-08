
namespace CsFormsFAE102_Ana.Ogrenciİsleri
{
    partial class frmOgrenciGiris
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
            this.btnOgrenciGiris = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.scOgr = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBolum = new System.Windows.Forms.ComboBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.DataGridView();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.mTxtTc = new System.Windows.Forms.MaskedTextBox();
            this.mTxtOgrNo = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrenciNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scOgr)).BeginInit();
            this.scOgr.Panel1.SuspendLayout();
            this.scOgr.Panel2.SuspendLayout();
            this.scOgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOgrenciGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOgrenciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOgrenciGiris.Location = new System.Drawing.Point(0, 0);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(1349, 45);
            this.btnOgrenciGiris.TabIndex = 0;
            this.btnOgrenciGiris.Text = "Öğrenci Giriş";
            this.btnOgrenciGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(121, 51);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(145, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(121, 87);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(145, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(121, 115);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(145, 22);
            this.txtTc.TabIndex = 1;
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(121, 143);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(145, 22);
            this.txtOgrNo.TabIndex = 1;
            // 
            // scOgr
            // 
            this.scOgr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scOgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scOgr.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scOgr.Location = new System.Drawing.Point(0, 45);
            this.scOgr.Name = "scOgr";
            this.scOgr.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scOgr.Panel1
            // 
            this.scOgr.Panel1.Controls.Add(this.btnSil);
            this.scOgr.Panel1.Controls.Add(this.btnKaydet);
            this.scOgr.Panel1.Controls.Add(this.mTxtOgrNo);
            this.scOgr.Panel1.Controls.Add(this.mTxtTc);
            this.scOgr.Panel1.Controls.Add(this.btnTemizle);
            this.scOgr.Panel1.Controls.Add(this.label6);
            this.scOgr.Panel1.Controls.Add(this.label5);
            this.scOgr.Panel1.Controls.Add(this.txtBolum);
            this.scOgr.Panel1.Controls.Add(this.txtSehir);
            this.scOgr.Panel1.Controls.Add(this.label4);
            this.scOgr.Panel1.Controls.Add(this.label3);
            this.scOgr.Panel1.Controls.Add(this.label2);
            this.scOgr.Panel1.Controls.Add(this.label1);
            this.scOgr.Panel1.Controls.Add(this.txtAd);
            this.scOgr.Panel1.Controls.Add(this.txtOgrNo);
            this.scOgr.Panel1.Controls.Add(this.txtSoyad);
            this.scOgr.Panel1.Controls.Add(this.txtTc);
            // 
            // scOgr.Panel2
            // 
            this.scOgr.Panel2.Controls.Add(this.liste);
            this.scOgr.Size = new System.Drawing.Size(1349, 640);
            this.scOgr.SplitterDistance = 346;
            this.scOgr.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(898, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bolumler :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(898, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sehirler :";
            // 
            // txtBolum
            // 
            this.txtBolum.FormattingEnabled = true;
            this.txtBolum.Location = new System.Drawing.Point(998, 73);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(226, 24);
            this.txtBolum.TabIndex = 3;
            // 
            // txtSehir
            // 
            this.txtSehir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSehir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(998, 38);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(226, 24);
            this.txtSehir.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "ogr no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "tcno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad:";
            // 
            // liste
            // 
            this.liste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.Ad,
            this.Soyad,
            this.TcNo,
            this.OgrenciNo,
            this.Sehir,
            this.Bolum,
            this.isActive});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.MultiSelect = false;
            this.liste.Name = "liste";
            this.liste.ReadOnly = true;
            this.liste.RowHeadersWidth = 51;
            this.liste.RowTemplate.Height = 24;
            this.liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.liste.Size = new System.Drawing.Size(1345, 286);
            this.liste.TabIndex = 0;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(21, 294);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(130, 36);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // mTxtTc
            // 
            this.mTxtTc.Location = new System.Drawing.Point(290, 120);
            this.mTxtTc.Mask = "00000000000";
            this.mTxtTc.Name = "mTxtTc";
            this.mTxtTc.Size = new System.Drawing.Size(134, 22);
            this.mTxtTc.TabIndex = 6;
            // 
            // mTxtOgrNo
            // 
            this.mTxtOgrNo.Location = new System.Drawing.Point(290, 148);
            this.mTxtOgrNo.Mask = "0000999999";
            this.mTxtOgrNo.Name = "mTxtOgrNo";
            this.mTxtOgrNo.Size = new System.Drawing.Size(134, 22);
            this.mTxtOgrNo.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1101, 283);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(123, 30);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(195, 296);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 33);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 48;
            // 
            // Sira
            // 
            this.Sira.HeaderText = "Sıra No";
            this.Sira.MinimumWidth = 6;
            this.Sira.Name = "Sira";
            this.Sira.ReadOnly = true;
            this.Sira.Width = 125;
            // 
            // Ad
            // 
            this.Ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Soyad
            // 
            this.Soyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            // 
            // TcNo
            // 
            this.TcNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TcNo.HeaderText = "Tc No";
            this.TcNo.MinimumWidth = 6;
            this.TcNo.Name = "TcNo";
            this.TcNo.ReadOnly = true;
            this.TcNo.Width = 75;
            // 
            // OgrenciNo
            // 
            this.OgrenciNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OgrenciNo.HeaderText = "Ogrenci No";
            this.OgrenciNo.MinimumWidth = 6;
            this.OgrenciNo.Name = "OgrenciNo";
            this.OgrenciNo.ReadOnly = true;
            this.OgrenciNo.Width = 109;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sehir.HeaderText = "Sehir";
            this.Sehir.MinimumWidth = 6;
            this.Sehir.Name = "Sehir";
            this.Sehir.ReadOnly = true;
            // 
            // Bolum
            // 
            this.Bolum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bolum.HeaderText = "Bolum";
            this.Bolum.MinimumWidth = 6;
            this.Bolum.Name = "Bolum";
            this.Bolum.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.HeaderText = "Durum";
            this.isActive.MinimumWidth = 6;
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isActive.Width = 125;
            // 
            // frmOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 685);
            this.Controls.Add(this.scOgr);
            this.Controls.Add(this.btnOgrenciGiris);
            this.Name = "frmOgrenciGiris";
            this.Text = "frmOgrenciGiris";
            this.Load += new System.EventHandler(this.frmOgrenciGiris_Load);
            this.scOgr.Panel1.ResumeLayout(false);
            this.scOgr.Panel1.PerformLayout();
            this.scOgr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scOgr)).EndInit();
            this.scOgr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btnOgrenciGiris;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.SplitContainer scOgr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtBolum;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.MaskedTextBox mTxtTc;
        private System.Windows.Forms.MaskedTextBox mTxtOgrNo;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrenciNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bolum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
    }
}