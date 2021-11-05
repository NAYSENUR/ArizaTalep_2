
namespace Ariza_Talep_2
{
    partial class Form4_mdi_bildiri_turu_ekle_sil
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
            this.btn_Ekle = new DevExpress.XtraEditors.SimpleButton();
            this.txt_bildiri_turu_adi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_tur_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bildiri_turu_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Appearance.Options.UseFont = true;
            this.btn_Ekle.Location = new System.Drawing.Point(169, 69);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(76, 26);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_bildiri_turu_adi
            // 
            this.txt_bildiri_turu_adi.Location = new System.Drawing.Point(23, 70);
            this.txt_bildiri_turu_adi.Name = "txt_bildiri_turu_adi";
            this.txt_bildiri_turu_adi.Properties.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bildiri_turu_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_bildiri_turu_adi.Size = new System.Drawing.Size(120, 24);
            this.txt_bildiri_turu_adi.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(200, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Eklemek İstediğiniz Bildiri Türü:";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(52, 16);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(350, 221);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.btn_tur_Sil);
            this.panelControl2.Location = new System.Drawing.Point(459, 200);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(289, 44);
            this.panelControl2.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(143, 18);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Seçili Bildiri Türünü Sil";
            // 
            // btn_tur_Sil
            // 
            this.btn_tur_Sil.Appearance.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tur_Sil.Appearance.Options.UseFont = true;
            this.btn_tur_Sil.Location = new System.Drawing.Point(169, 11);
            this.btn_tur_Sil.Name = "btn_tur_Sil";
            this.btn_tur_Sil.Size = new System.Drawing.Size(76, 26);
            this.btn_tur_Sil.TabIndex = 8;
            this.btn_tur_Sil.Text = "Sil";
            this.btn_tur_Sil.Click += new System.EventHandler(this.btn_tur_Sil_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Ekle);
            this.panelControl1.Controls.Add(this.txt_bildiri_turu_adi);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(459, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(289, 144);
            this.panelControl1.TabIndex = 14;
            // 
            // Form4_mdi_bildiri_turu_ekle_sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form4_mdi_bildiri_turu_ekle_sil";
            this.Text = "Bildiri Türü Belirle";
            this.Load += new System.EventHandler(this.Form4_mdi_bildiri_turu_ekle_sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_bildiri_turu_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Ekle;
        private DevExpress.XtraEditors.TextEdit txt_bildiri_turu_adi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_tur_Sil;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}