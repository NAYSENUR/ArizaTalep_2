
namespace Ariza_Talep_2
{
    partial class Form4_mdi_KullanicilarGoruntule_Duzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_mdi_KullanicilarGoruntule_Duzenle));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_yetki_ver = new DevExpress.XtraEditors.SimpleButton();
            this.btn_yetki_iptal = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kullanici_düzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kullanici_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btn_yetki_ver);
            this.panelControl1.Controls.Add(this.btn_yetki_iptal);
            this.panelControl1.Controls.Add(this.btn_kullanici_düzenle);
            this.panelControl1.Controls.Add(this.btn_kullanici_Sil);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(610, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(190, 260);
            this.panelControl1.TabIndex = 6;
            // 
            // btn_yetki_ver
            // 
            this.btn_yetki_ver.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetki_ver.Appearance.Options.UseFont = true;
            this.btn_yetki_ver.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_yetki_ver.ImageOptions.Image")));
            this.btn_yetki_ver.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_yetki_ver.Location = new System.Drawing.Point(13, 133);
            this.btn_yetki_ver.Name = "btn_yetki_ver";
            this.btn_yetki_ver.Size = new System.Drawing.Size(156, 51);
            this.btn_yetki_ver.TabIndex = 2;
            this.btn_yetki_ver.Text = "YÖNETİCİ\r\nYETKİSİ VER";
            this.btn_yetki_ver.Click += new System.EventHandler(this.btn_yetki_ver_Click);
            // 
            // btn_yetki_iptal
            // 
            this.btn_yetki_iptal.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetki_iptal.Appearance.Options.UseFont = true;
            this.btn_yetki_iptal.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomRight;
            this.btn_yetki_iptal.Location = new System.Drawing.Point(13, 189);
            this.btn_yetki_iptal.Name = "btn_yetki_iptal";
            this.btn_yetki_iptal.Size = new System.Drawing.Size(156, 51);
            this.btn_yetki_iptal.TabIndex = 3;
            this.btn_yetki_iptal.Text = "YÖNETİCİ YETKİSİNİ\r\nİPTAL ET";
            this.btn_yetki_iptal.Click += new System.EventHandler(this.btn_yetki_iptal_Click);
            // 
            // btn_kullanici_düzenle
            // 
            this.btn_kullanici_düzenle.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullanici_düzenle.Appearance.Options.UseFont = true;
            this.btn_kullanici_düzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kullanici_düzenle.ImageOptions.Image")));
            this.btn_kullanici_düzenle.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_kullanici_düzenle.Location = new System.Drawing.Point(13, 19);
            this.btn_kullanici_düzenle.Name = "btn_kullanici_düzenle";
            this.btn_kullanici_düzenle.Size = new System.Drawing.Size(156, 51);
            this.btn_kullanici_düzenle.TabIndex = 0;
            this.btn_kullanici_düzenle.Text = "DÜZENLE";
            this.btn_kullanici_düzenle.Click += new System.EventHandler(this.btn_kullanici_düzenle_Click);
            // 
            // btn_kullanici_Sil
            // 
            this.btn_kullanici_Sil.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kullanici_Sil.Appearance.Options.UseFont = true;
            this.btn_kullanici_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kullanici_Sil.ImageOptions.Image")));
            this.btn_kullanici_Sil.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_kullanici_Sil.Location = new System.Drawing.Point(13, 77);
            this.btn_kullanici_Sil.Name = "btn_kullanici_Sil";
            this.btn_kullanici_Sil.Size = new System.Drawing.Size(156, 51);
            this.btn_kullanici_Sil.TabIndex = 1;
            this.btn_kullanici_Sil.Text = "SİL";
            this.btn_kullanici_Sil.Click += new System.EventHandler(this.btn_kullanici_Sil_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(597, 260);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // Form4_mdi_KullanicilarGoruntule_Duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form4_mdi_KullanicilarGoruntule_Duzenle";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.Form4_mdi_KullanicilarGoruntule_Duzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_yetki_ver;
        private DevExpress.XtraEditors.SimpleButton btn_yetki_iptal;
        private DevExpress.XtraEditors.SimpleButton btn_kullanici_düzenle;
        private DevExpress.XtraEditors.SimpleButton btn_kullanici_Sil;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}