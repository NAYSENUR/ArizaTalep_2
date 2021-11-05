
namespace Ariza_Talep_2
{
    partial class Form2_KullanıcıEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_KullanıcıEkrani));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtn_yenitalep = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_yenisorun = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_talepvesorunlar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_mesajlar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_MesajSayisi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Goruntule = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.DarkBlue;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtn_yenitalep,
            this.barBtn_yenisorun,
            this.barBtn_talepvesorunlar,
            this.barBtn_mesajlar,
            this.barBtn_MesajSayisi,
            this.barBtn_Goruntule});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsPageCategories.AutoCorrectForeColor = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 161);
            // 
            // barBtn_yenitalep
            // 
            this.barBtn_yenitalep.Caption = "YENİ TALEP";
            this.barBtn_yenitalep.Id = 2;
            this.barBtn_yenitalep.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_yenitalep.ImageOptions.Image")));
            this.barBtn_yenitalep.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_yenitalep.ImageOptions.LargeImage")));
            this.barBtn_yenitalep.ItemAppearance.Normal.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtn_yenitalep.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtn_yenitalep.Name = "barBtn_yenitalep";
            this.barBtn_yenitalep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_yenitalep_ItemClick);
            // 
            // barBtn_yenisorun
            // 
            this.barBtn_yenisorun.Caption = "YENİ SORUN";
            this.barBtn_yenisorun.Id = 3;
            this.barBtn_yenisorun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_yenisorun.ImageOptions.Image")));
            this.barBtn_yenisorun.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_yenisorun.ImageOptions.LargeImage")));
            this.barBtn_yenisorun.ItemAppearance.Normal.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtn_yenisorun.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtn_yenisorun.Name = "barBtn_yenisorun";
            this.barBtn_yenisorun.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_yenisorun_ItemClick);
            // 
            // barBtn_talepvesorunlar
            // 
            this.barBtn_talepvesorunlar.Caption = "TALEP/SORUNLAR";
            this.barBtn_talepvesorunlar.Id = 4;
            this.barBtn_talepvesorunlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_talepvesorunlar.ImageOptions.Image")));
            this.barBtn_talepvesorunlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_talepvesorunlar.ImageOptions.LargeImage")));
            this.barBtn_talepvesorunlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtn_talepvesorunlar.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtn_talepvesorunlar.Name = "barBtn_talepvesorunlar";
            this.barBtn_talepvesorunlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_talepvesorunlar_ItemClick);
            // 
            // barBtn_mesajlar
            // 
            this.barBtn_mesajlar.Caption = "MESAJLAR";
            this.barBtn_mesajlar.Id = 5;
            this.barBtn_mesajlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_mesajlar.ImageOptions.Image")));
            this.barBtn_mesajlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_mesajlar.ImageOptions.LargeImage")));
            this.barBtn_mesajlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtn_mesajlar.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtn_mesajlar.Name = "barBtn_mesajlar";
            this.barBtn_mesajlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_mesajlar_ItemClick);
            // 
            // barBtn_MesajSayisi
            // 
            this.barBtn_MesajSayisi.Caption = "1";
            this.barBtn_MesajSayisi.Id = 6;
            this.barBtn_MesajSayisi.ItemAppearance.Normal.BackColor = System.Drawing.Color.Crimson;
            this.barBtn_MesajSayisi.ItemAppearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.barBtn_MesajSayisi.ItemAppearance.Normal.Options.UseBackColor = true;
            this.barBtn_MesajSayisi.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barBtn_MesajSayisi.Name = "barBtn_MesajSayisi";
            // 
            // barBtn_Goruntule
            // 
            this.barBtn_Goruntule.Caption = "GÖRÜNTÜLE";
            this.barBtn_Goruntule.Id = 9;
            this.barBtn_Goruntule.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtn_Goruntule.ImageOptions.Image")));
            this.barBtn_Goruntule.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtn_Goruntule.ImageOptions.LargeImage")));
            this.barBtn_Goruntule.ItemAppearance.Normal.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barBtn_Goruntule.ItemAppearance.Normal.Options.UseFont = true;
            this.barBtn_Goruntule.Name = "barBtn_Goruntule";
            this.barBtn_Goruntule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Goruntule_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "TALEP ve SORUNLAR";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_talepvesorunlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barBtn_Goruntule);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtn_yenitalep);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtn_yenisorun);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_mesajlar);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_MesajSayisi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form2_KullanıcıEkrani
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form2_KullanıcıEkrani";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Kullanıcı Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_KullanıcıEkrani_FormClosing);
            this.Load += new System.EventHandler(this.Form2_KullanıcıEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtn_yenitalep;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barBtn_yenisorun;
        private DevExpress.XtraBars.BarButtonItem barBtn_talepvesorunlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barBtn_mesajlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtn_Goruntule;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        public DevExpress.XtraBars.BarButtonItem barBtn_MesajSayisi;
    }
}