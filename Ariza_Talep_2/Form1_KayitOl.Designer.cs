
namespace Ariza_Talep_2
{
    partial class Form1_KayitOl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_KayitOl));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_kullanici_adi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btn_KAYDET = new DevExpress.XtraEditors.SimpleButton();
            this.txt_sifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_adi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanici_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Location = new System.Drawing.Point(425, 106);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(212, 110);
            this.panelControl1.TabIndex = 40;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 32);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(194, 36);
            this.labelControl9.TabIndex = 25;
            this.labelControl9.Text = "     Kullanıcı Adı ve Şifreniz\r\nSisteme Girişte Kullanılacaktır..";
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.Location = new System.Drawing.Point(216, 167);
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Properties.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanici_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_kullanici_adi.Size = new System.Drawing.Size(130, 24);
            this.txt_kullanici_adi.TabIndex = 39;
            this.txt_kullanici_adi.TextChanged += new System.EventHandler(this.txt_kullanici_adi_TextChanged);
            this.txt_kullanici_adi.Validating += new System.ComponentModel.CancelEventHandler(this.txt_kullanici_adi_Validating);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(84, 170);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(101, 18);
            this.labelControl8.TabIndex = 38;
            this.labelControl8.Text = "KULLANICI ADI:";
            // 
            // btn_KAYDET
            // 
            this.btn_KAYDET.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KAYDET.Appearance.Options.UseFont = true;
            this.btn_KAYDET.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_KAYDET.ImageOptions.Image")));
            this.btn_KAYDET.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_KAYDET.Location = new System.Drawing.Point(486, 318);
            this.btn_KAYDET.Name = "btn_KAYDET";
            this.btn_KAYDET.Size = new System.Drawing.Size(121, 42);
            this.btn_KAYDET.TabIndex = 36;
            this.btn_KAYDET.Text = "KAYDET";
            this.btn_KAYDET.Click += new System.EventHandler(this.btn_KAYDET_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(216, 321);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Properties.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Properties.Appearance.Options.UseFont = true;
            this.txt_sifre.Properties.UseSystemPasswordChar = true;
            this.txt_sifre.Size = new System.Drawing.Size(130, 24);
            this.txt_sifre.TabIndex = 35;
            this.txt_sifre.Validating += new System.ComponentModel.CancelEventHandler(this.txt_sifre_Validating);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(84, 324);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 18);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Şifre:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(84, 211);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 18);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "BÖLÜMÜ";
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(216, 123);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Properties.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_adi.Size = new System.Drawing.Size(130, 24);
            this.txt_adi.TabIndex = 28;
            this.txt_adi.Validating += new System.ComponentModel.CancelEventHandler(this.txt_adi_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(84, 126);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 18);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "AD SOYAD:";
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.EditValue = "Seçiniz..";
            this.comboBoxEdit2.Location = new System.Drawing.Point(216, 208);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEdit2.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.NullText = "";
            this.comboBoxEdit2.Properties.PopupSizeable = false;
            this.comboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.comboBoxEdit2.Size = new System.Drawing.Size(130, 24);
            this.comboBoxEdit2.TabIndex = 37;
            this.comboBoxEdit2.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxEdit2_Validating);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.LineVisible = true;
            this.labelControl5.Location = new System.Drawing.Point(173, 60);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 19);
            this.labelControl5.TabIndex = 41;
            this.labelControl5.Text = "KAYIT OL";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(361, 323);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "Göster";
            this.checkEdit1.Size = new System.Drawing.Size(85, 22);
            this.checkEdit1.TabIndex = 44;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // Form1_KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 434);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.txt_kullanici_adi);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btn_KAYDET);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.comboBoxEdit2);
            this.Name = "Form1_KayitOl";
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.Form1_KayitOl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanici_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_kullanici_adi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btn_KAYDET;
        private DevExpress.XtraEditors.TextEdit txt_sifre;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_adi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}