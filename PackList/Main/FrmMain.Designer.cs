namespace QR_CodeScanner.Main
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            BtnQrCodeOkut = new DevExpress.XtraBars.BarButtonItem();
            BtnQrIslemleri = new DevExpress.XtraBars.BarButtonItem();
            BtnRaporlar = new DevExpress.XtraBars.BarButtonItem();
            BtnEtiketler = new DevExpress.XtraBars.BarButtonItem();
            BtnKullanicilar = new DevExpress.XtraBars.BarButtonItem();
            BtnVeritabaniAyarlari = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            BtnBaglantiAyarlari = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            Raporlama = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, BtnQrCodeOkut, BtnQrIslemleri, BtnRaporlar, BtnEtiketler, BtnKullanicilar, BtnVeritabaniAyarlari, barButtonItem7, BtnBaglantiAyarlari });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 9;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new System.Drawing.Size(1118, 170);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // BtnQrCodeOkut
            // 
            BtnQrCodeOkut.Caption = "Qr Code Okut";
            BtnQrCodeOkut.Id = 1;
            BtnQrCodeOkut.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnQrCodeOkut.ImageOptions.SvgImage");
            BtnQrCodeOkut.Name = "BtnQrCodeOkut";
            BtnQrCodeOkut.ItemClick += BtnQrCodeOkut_ItemClick;
            // 
            // BtnQrIslemleri
            // 
            BtnQrIslemleri.Caption = "QR İşlemleri";
            BtnQrIslemleri.Id = 2;
            BtnQrIslemleri.ImageOptions.SvgImage = PackList.Properties.Resources.editnames4;
            BtnQrIslemleri.Name = "BtnQrIslemleri";
            BtnQrIslemleri.ItemClick += BtnQrIslemleri_ItemClick;
            // 
            // BtnRaporlar
            // 
            BtnRaporlar.Caption = "Raporlar";
            BtnRaporlar.Id = 3;
            BtnRaporlar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnRaporlar.ImageOptions.SvgImage");
            BtnRaporlar.Name = "BtnRaporlar";
            BtnRaporlar.ItemClick += BtnRaporlar_ItemClick;
            // 
            // BtnEtiketler
            // 
            BtnEtiketler.Caption = "Etiketler";
            BtnEtiketler.Id = 4;
            BtnEtiketler.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnEtiketler.ImageOptions.SvgImage");
            BtnEtiketler.Name = "BtnEtiketler";
            BtnEtiketler.ItemClick += BtnEtiketler_ItemClick;
            // 
            // BtnKullanicilar
            // 
            BtnKullanicilar.Caption = "Kullanıcılar";
            BtnKullanicilar.Id = 5;
            BtnKullanicilar.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnKullanicilar.ImageOptions.SvgImage");
            BtnKullanicilar.Name = "BtnKullanicilar";
            BtnKullanicilar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            BtnKullanicilar.ItemClick += BtnKullanicilar_ItemClick;
            // 
            // BtnVeritabaniAyarlari
            // 
            BtnVeritabaniAyarlari.Caption = "Veritabanı İşlemleri";
            BtnVeritabaniAyarlari.Enabled = false;
            BtnVeritabaniAyarlari.Id = 6;
            BtnVeritabaniAyarlari.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnVeritabaniAyarlari.ImageOptions.SvgImage");
            BtnVeritabaniAyarlari.Name = "BtnVeritabaniAyarlari";
            BtnVeritabaniAyarlari.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            BtnVeritabaniAyarlari.ItemClick += BtnVeritabaniAyarlari_ItemClick;
            // 
            // barButtonItem7
            // 
            barButtonItem7.Caption = "barButtonItem7";
            barButtonItem7.Id = 7;
            barButtonItem7.Name = "barButtonItem7";
            // 
            // BtnBaglantiAyarlari
            // 
            BtnBaglantiAyarlari.Caption = "Bağlantı Ayarları";
            BtnBaglantiAyarlari.Id = 8;
            BtnBaglantiAyarlari.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnBaglantiAyarlari.ImageOptions.SvgImage");
            BtnBaglantiAyarlari.Name = "BtnBaglantiAyarlari";
            BtnBaglantiAyarlari.ItemClick += BtnBaglantiAyarlari_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, Raporlama, ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(BtnQrCodeOkut);
            ribbonPageGroup1.ItemLinks.Add(BtnQrIslemleri);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "QR İşlemleri";
            // 
            // Raporlama
            // 
            Raporlama.ItemLinks.Add(BtnRaporlar);
            Raporlama.ItemLinks.Add(BtnEtiketler);
            Raporlama.Name = "Raporlama";
            Raporlama.Text = "Raporlama";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(BtnBaglantiAyarlari);
            ribbonPageGroup2.ItemLinks.Add(BtnKullanicilar);
            ribbonPageGroup2.ItemLinks.Add(BtnVeritabaniAyarlari);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Ayarlar";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new System.Drawing.Point(0, 638);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(1118, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1118, 669);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IsMdiContainer = true;
            Name = "FrmMain";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "Ana Sayfa";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            FormClosed += FrmMain_FormClosed;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BtnQrCodeOkut;
        private DevExpress.XtraBars.BarButtonItem BtnQrIslemleri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Raporlama;
        private DevExpress.XtraBars.BarButtonItem BtnRaporlar;
        private DevExpress.XtraBars.BarButtonItem BtnEtiketler;
        private DevExpress.XtraBars.BarButtonItem BtnKullanicilar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnVeritabaniAyarlari;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnBaglantiAyarlari;
    }
}