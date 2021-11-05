
namespace Ariza_Talep_2
{
    partial class Form1_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Giris));
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_kullanici_giris_sifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_kullanici_giris_adi = new DevExpress.XtraEditors.TextEdit();
            this.btn_Giris = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanici_giris_sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanici_giris_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hyperlinkLabelControl1.Appearance.Options.UseFont = true;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(71, 258);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(123, 16);
            this.hyperlinkLabelControl1.TabIndex = 12;
            this.hyperlinkLabelControl1.Text = "Üye Değilsen Kayıt Ol";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sitka Small", 9.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(63, 127);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 18);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Şifre:";
            // 
            // txt_kullanici_giris_sifre
            // 
            this.txt_kullanici_giris_sifre.Location = new System.Drawing.Point(199, 127);
            this.txt_kullanici_giris_sifre.Name = "txt_kullanici_giris_sifre";
            this.txt_kullanici_giris_sifre.Properties.Appearance.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanici_giris_sifre.Properties.Appearance.Options.UseFont = true;
            this.txt_kullanici_giris_sifre.Properties.UseSystemPasswordChar = true;
            this.txt_kullanici_giris_sifre.Size = new System.Drawing.Size(108, 22);
            this.txt_kullanici_giris_sifre.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Small", 9.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(63, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 18);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // txt_kullanici_giris_adi
            // 
            this.txt_kullanici_giris_adi.Location = new System.Drawing.Point(199, 78);
            this.txt_kullanici_giris_adi.Name = "txt_kullanici_giris_adi";
            this.txt_kullanici_giris_adi.Properties.Appearance.Font = new System.Drawing.Font("Sitka Small", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanici_giris_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_kullanici_giris_adi.Size = new System.Drawing.Size(108, 22);
            this.txt_kullanici_giris_adi.TabIndex = 8;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Appearance.Options.UseFont = true;
            this.btn_Giris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Giris.ImageOptions.Image")));
            this.btn_Giris.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_Giris.Location = new System.Drawing.Point(258, 190);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(116, 43);
            this.btn_Giris.TabIndex = 7;
            this.btn_Giris.Text = "GİRİŞ YAP";
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(153, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 19);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "GİRİŞ YAP";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(322, 127);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Göster";
            this.checkEdit1.Size = new System.Drawing.Size(75, 22);
            this.checkEdit1.TabIndex = 14;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // Form1_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 317);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_kullanici_giris_sifre);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_kullanici_giris_adi);
            this.Controls.Add(this.btn_Giris);
            this.Name = "Form1_Giris";
            this.Text = "Giriş Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Giris_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanici_giris_sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanici_giris_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_kullanici_giris_sifre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_kullanici_giris_adi;
        private DevExpress.XtraEditors.SimpleButton btn_Giris;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}