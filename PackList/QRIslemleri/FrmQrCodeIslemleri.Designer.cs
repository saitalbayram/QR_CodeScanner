namespace QR_CodeScanner.QRIslemleri
{
    partial class FrmQrCodeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQrCodeIslemleri));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            posetPaketBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            SilinecekSatir = new DevExpress.XtraGrid.Columns.GridColumn();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colPosetBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            colPaketBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
            barButtonItemDuzenle = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSil = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemYeniKodOkut = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemTekrarYazdir = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemGorunumuKaydet = new DevExpress.XtraBars.BarButtonItem();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            simpleButtonVazgec = new DevExpress.XtraEditors.SimpleButton();
            simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)posetPaketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(pictureEdit1);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(941, 96);
            panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl2.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseForeColor = true;
            labelControl2.Location = new System.Drawing.Point(576, 74);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(353, 16);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Bu ekrandan silme ve düzenleme işlemleri yapabilirsiniz";
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new System.Drawing.Point(12, 6);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit1.Size = new System.Drawing.Size(92, 85);
            pictureEdit1.TabIndex = 3;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(110, 35);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(170, 33);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "QR İşlemleri";
            // 
            // gridControl1
            // 
            gridControl1.DataSource = posetPaketBindingSource;
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(0, 96);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(941, 479);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // posetPaketBindingSource
            // 
            posetPaketBindingSource.DataSource = typeof(EntityLayer.Concrete.PosetPaket);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { SilinecekSatir, colID, colPosetBarkod, colPaketBarkod, colUserID, colCreatedDate });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.CellValueChanged += gridView1_CellValueChanged;
            gridView1.RowUpdated += gridView1_RowUpdated;
            gridView1.MouseDown += gridView1_MouseDown;
            // 
            // SilinecekSatir
            // 
            SilinecekSatir.Caption = "Silinecek Satır";
            SilinecekSatir.Name = "SilinecekSatir";
            // 
            // colID
            // 
            colID.FieldName = "ID";
            colID.Name = "colID";
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 35;
            // 
            // colPosetBarkod
            // 
            colPosetBarkod.Caption = "Poşet Barkod";
            colPosetBarkod.FieldName = "PosetBarkod";
            colPosetBarkod.Name = "colPosetBarkod";
            colPosetBarkod.Visible = true;
            colPosetBarkod.VisibleIndex = 1;
            colPosetBarkod.Width = 175;
            // 
            // colPaketBarkod
            // 
            colPaketBarkod.FieldName = "PaketBarkod";
            colPaketBarkod.Name = "colPaketBarkod";
            colPaketBarkod.Visible = true;
            colPaketBarkod.VisibleIndex = 2;
            colPaketBarkod.Width = 175;
            // 
            // colUserID
            // 
            colUserID.Caption = "Oluşturan";
            colUserID.FieldName = "UserID";
            colUserID.Name = "colUserID";
            colUserID.Visible = true;
            colUserID.VisibleIndex = 3;
            colUserID.Width = 175;
            // 
            // colCreatedDate
            // 
            colCreatedDate.Caption = "Oluşturma Tarihi";
            colCreatedDate.FieldName = "CreatedDate";
            colCreatedDate.Name = "colCreatedDate";
            colCreatedDate.Visible = true;
            colCreatedDate.VisibleIndex = 4;
            colCreatedDate.Width = 178;
            // 
            // popupMenu1
            // 
            popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemDuzenle), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemSil), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemYeniKodOkut), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemTekrarYazdir), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemGorunumuKaydet) });
            popupMenu1.Manager = barManager1;
            popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItemDuzenle
            // 
            barButtonItemDuzenle.Caption = "Düzenle";
            barButtonItemDuzenle.Id = 0;
            barButtonItemDuzenle.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemDuzenle.ImageOptions.SvgImage");
            barButtonItemDuzenle.Name = "barButtonItemDuzenle";
            barButtonItemDuzenle.ItemClick += barButtonItemDuzenle_ItemClick;
            // 
            // barButtonItemSil
            // 
            barButtonItemSil.Caption = "Sil";
            barButtonItemSil.Id = 1;
            barButtonItemSil.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemSil.ImageOptions.SvgImage");
            barButtonItemSil.Name = "barButtonItemSil";
            barButtonItemSil.ItemClick += barButtonItemSil_ItemClick;
            // 
            // barButtonItemYeniKodOkut
            // 
            barButtonItemYeniKodOkut.Caption = "Yeni Kod Okut";
            barButtonItemYeniKodOkut.Id = 2;
            barButtonItemYeniKodOkut.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemYeniKodOkut.ImageOptions.SvgImage");
            barButtonItemYeniKodOkut.Name = "barButtonItemYeniKodOkut";
            barButtonItemYeniKodOkut.ItemClick += barButtonItemYeniKodOkut_ItemClick;
            // 
            // barButtonItemTekrarYazdir
            // 
            barButtonItemTekrarYazdir.Caption = "Tekrar Yazdır";
            barButtonItemTekrarYazdir.Id = 3;
            barButtonItemTekrarYazdir.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemTekrarYazdir.ImageOptions.SvgImage");
            barButtonItemTekrarYazdir.Name = "barButtonItemTekrarYazdir";
            barButtonItemTekrarYazdir.ItemClick += barButtonItemTekrarYazdir_ItemClick;
            // 
            // barButtonItemGorunumuKaydet
            // 
            barButtonItemGorunumuKaydet.Caption = "Görünümü Kaydet";
            barButtonItemGorunumuKaydet.Id = 4;
            barButtonItemGorunumuKaydet.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemGorunumuKaydet.ImageOptions.SvgImage");
            barButtonItemGorunumuKaydet.Name = "barButtonItemGorunumuKaydet";
            barButtonItemGorunumuKaydet.ItemClick += barButtonItemGorunumuKaydet_ItemClick;
            // 
            // barManager1
            // 
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemDuzenle, barButtonItemSil, barButtonItemYeniKodOkut, barButtonItemTekrarYazdir, barButtonItemGorunumuKaydet });
            barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(941, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 575);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(941, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 575);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(941, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 575);
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(simpleButtonVazgec);
            panelControl2.Controls.Add(simpleButtonKaydet);
            panelControl2.Controls.Add(labelControl3);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl2.Location = new System.Drawing.Point(0, 543);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(941, 32);
            panelControl2.TabIndex = 5;
            // 
            // simpleButtonVazgec
            // 
            simpleButtonVazgec.Dock = System.Windows.Forms.DockStyle.Right;
            simpleButtonVazgec.Location = new System.Drawing.Point(789, 2);
            simpleButtonVazgec.Name = "simpleButtonVazgec";
            simpleButtonVazgec.Size = new System.Drawing.Size(75, 28);
            simpleButtonVazgec.TabIndex = 6;
            simpleButtonVazgec.Text = "Vazgeç";
            // 
            // simpleButtonKaydet
            // 
            simpleButtonKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            simpleButtonKaydet.Location = new System.Drawing.Point(864, 2);
            simpleButtonKaydet.Name = "simpleButtonKaydet";
            simpleButtonKaydet.Size = new System.Drawing.Size(75, 28);
            simpleButtonKaydet.TabIndex = 5;
            simpleButtonKaydet.Text = "Kaydet";
            simpleButtonKaydet.Click += simpleButtonKaydet_Click;
            // 
            // labelControl3
            // 
            labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new System.Drawing.Point(1317, 74);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(353, 16);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Bu ekrandan silme ve düzenleme işlemleri yapabilirsiniz";
            // 
            // FrmQrCodeIslemleri
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(941, 575);
            Controls.Add(panelControl2);
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FrmQrCodeIslemleri";
            Text = "QrCodeIslemleri";
            Load += FrmQrCodeIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)posetPaketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource posetPaketBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPosetBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colPaketBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDuzenle;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSil;
        private DevExpress.XtraBars.BarButtonItem barButtonItemYeniKodOkut;
        private DevExpress.XtraBars.BarButtonItem barButtonItemTekrarYazdir;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGorunumuKaydet;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonVazgec;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraGrid.Columns.GridColumn SilinecekSatir;
    }
}