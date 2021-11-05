
namespace CsFormsFAE102_Ana.Ogrenciİsleri
{
    partial class frmBolumGiris
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scBolumler = new System.Windows.Forms.SplitContainer();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTamSil = new System.Windows.Forms.Button();
            this.chkPasif = new System.Windows.Forms.CheckBox();
            this.rbHepsi = new System.Windows.Forms.RadioButton();
            this.rbAktif = new System.Windows.Forms.RadioButton();
            this.rbPasif = new System.Windows.Forms.RadioButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBolumler)).BeginInit();
            this.scBolumler.Panel1.SuspendLayout();
            this.scBolumler.Panel2.SuspendLayout();
            this.scBolumler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Size = new System.Drawing.Size(616, 456);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // scBolumler
            // 
            this.scBolumler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scBolumler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBolumler.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scBolumler.Location = new System.Drawing.Point(0, 0);
            this.scBolumler.Name = "scBolumler";
            this.scBolumler.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBolumler.Panel1
            // 
            this.scBolumler.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.scBolumler.Panel1.Controls.Add(this.rbPasif);
            this.scBolumler.Panel1.Controls.Add(this.rbAktif);
            this.scBolumler.Panel1.Controls.Add(this.rbHepsi);
            this.scBolumler.Panel1.Controls.Add(this.chkPasif);
            this.scBolumler.Panel1.Controls.Add(this.btnTamSil);
            this.scBolumler.Panel1.Controls.Add(this.btnSil);
            this.scBolumler.Panel1.Controls.Add(this.btnTemizle);
            this.scBolumler.Panel1.Controls.Add(this.btnKaydet);
            this.scBolumler.Panel1.Controls.Add(this.txtBolumAdi);
            this.scBolumler.Panel1.Controls.Add(this.label1);
            // 
            // scBolumler.Panel2
            // 
            this.scBolumler.Panel2.Controls.Add(this.Liste);
            this.scBolumler.Size = new System.Drawing.Size(616, 456);
            this.scBolumler.SplitterDistance = 126;
            this.scBolumler.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(0, 57);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(83, 23);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Location = new System.Drawing.Point(472, 72);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(137, 47);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kayıt";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBolumAdi.Location = new System.Drawing.Point(0, 29);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(612, 22);
            this.txtBolumAdi.TabIndex = 1;
            this.txtBolumAdi.TextChanged += new System.EventHandler(this.txtBolumAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BolumAdi,
            this.isActive});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(612, 322);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(89, 57);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(126, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTamSil
            // 
            this.btnTamSil.Location = new System.Drawing.Point(3, 88);
            this.btnTamSil.Name = "btnTamSil";
            this.btnTamSil.Size = new System.Drawing.Size(80, 26);
            this.btnTamSil.TabIndex = 5;
            this.btnTamSil.Text = "TamSilme";
            this.btnTamSil.UseVisualStyleBackColor = true;
            this.btnTamSil.Click += new System.EventHandler(this.btnTamSil_Click);
            // 
            // chkPasif
            // 
            this.chkPasif.Location = new System.Drawing.Point(89, 92);
            this.chkPasif.Name = "chkPasif";
            this.chkPasif.Size = new System.Drawing.Size(89, 20);
            this.chkPasif.TabIndex = 6;
            this.chkPasif.Text = "Pasif";
            this.chkPasif.UseVisualStyleBackColor = true;
            this.chkPasif.CheckedChanged += new System.EventHandler(this.chkPasif_CheckedChanged);
            // 
            // rbHepsi
            // 
            this.rbHepsi.Checked = true;
            this.rbHepsi.Location = new System.Drawing.Point(216, 57);
            this.rbHepsi.Name = "rbHepsi";
            this.rbHepsi.Size = new System.Drawing.Size(121, 22);
            this.rbHepsi.TabIndex = 7;
            this.rbHepsi.TabStop = true;
            this.rbHepsi.Text = "Hepsi";
            this.rbHepsi.UseVisualStyleBackColor = true;
            this.rbHepsi.CheckedChanged += new System.EventHandler(this.rbHepsi_CheckedChanged);
            // 
            // rbAktif
            // 
            this.rbAktif.Location = new System.Drawing.Point(216, 84);
            this.rbAktif.Name = "rbAktif";
            this.rbAktif.Size = new System.Drawing.Size(110, 21);
            this.rbAktif.TabIndex = 7;
            this.rbAktif.Text = "Aktifler";
            this.rbAktif.UseVisualStyleBackColor = true;
            this.rbAktif.CheckedChanged += new System.EventHandler(this.rbAktif_CheckedChanged);
            // 
            // rbPasif
            // 
            this.rbPasif.Location = new System.Drawing.Point(343, 57);
            this.rbPasif.Name = "rbPasif";
            this.rbPasif.Size = new System.Drawing.Size(93, 21);
            this.rbPasif.TabIndex = 7;
            this.rbPasif.Text = "Pasifler";
            this.rbPasif.UseVisualStyleBackColor = true;
            this.rbPasif.CheckedChanged += new System.EventHandler(this.rbPasif_CheckedChanged);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Sıra No";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 84;
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BolumAdi.HeaderText = "Bolum";
            this.BolumAdi.MinimumWidth = 6;
            this.BolumAdi.Name = "BolumAdi";
            this.BolumAdi.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.HeaderText = "Durum";
            this.isActive.MinimumWidth = 6;
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Width = 125;
            // 
            // frmBolumGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 456);
            this.Controls.Add(this.scBolumler);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmBolumGiris";
            this.Text = "frmBolumGiris";
            this.Load += new System.EventHandler(this.frmBolumGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.scBolumler.Panel1.ResumeLayout(false);
            this.scBolumler.Panel1.PerformLayout();
            this.scBolumler.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBolumler)).EndInit();
            this.scBolumler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer scBolumler;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTamSil;
        private System.Windows.Forms.CheckBox chkPasif;
        private System.Windows.Forms.RadioButton rbPasif;
        private System.Windows.Forms.RadioButton rbAktif;
        private System.Windows.Forms.RadioButton rbHepsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumAdi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
    }
}