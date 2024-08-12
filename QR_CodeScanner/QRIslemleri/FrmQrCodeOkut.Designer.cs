namespace QR_CodeScanner
{
    partial class FrmQrCodeOkut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQrCodeOkut));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEditPaketBarkod = new DevExpress.XtraEditors.TextEdit();
            textEditPosetBarkod = new DevExpress.XtraEditors.TextEdit();
            listBoxControl1 = new DevExpress.Utils.Html.HtmlTemplateCollection();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            posetPaketBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colPosetBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            colPaketBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            popupMenuGrid = new DevExpress.XtraBars.PopupMenu(components);
            barButtonItemDuzenle = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSil = new DevExpress.XtraBars.BarButtonItem();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEditPaketBarkod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditPosetBarkod.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)posetPaketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenuGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(simpleButton2);
            panelControl1.Controls.Add(simpleButton1);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(textEditPaketBarkod);
            panelControl1.Controls.Add(textEditPosetBarkod);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(783, 89);
            panelControl1.TabIndex = 1;
            // 
            // simpleButton2
            // 
            simpleButton2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton2.ImageOptions.SvgImage");
            simpleButton2.Location = new System.Drawing.Point(186, 50);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(176, 33);
            simpleButton2.TabIndex = 5;
            simpleButton2.Text = "Son Barkodu Tekrar Yazdır";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new System.Drawing.Point(368, 50);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(86, 33);
            simpleButton1.TabIndex = 4;
            simpleButton1.Text = "Kaydet";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(244, 2);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(69, 13);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Paket Barkodu";
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(13, 2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(69, 13);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Poşet Barkodu";
            // 
            // textEditPaketBarkod
            // 
            textEditPaketBarkod.Location = new System.Drawing.Point(244, 21);
            textEditPaketBarkod.Name = "textEditPaketBarkod";
            textEditPaketBarkod.Size = new System.Drawing.Size(210, 22);
            textEditPaketBarkod.TabIndex = 1;
            textEditPaketBarkod.KeyDown += textEditPaketBarkod_KeyDown;
            // 
            // textEditPosetBarkod
            // 
            textEditPosetBarkod.Location = new System.Drawing.Point(12, 21);
            textEditPosetBarkod.Name = "textEditPosetBarkod";
            textEditPosetBarkod.Size = new System.Drawing.Size(210, 22);
            textEditPosetBarkod.TabIndex = 0;
            textEditPosetBarkod.EditValueChanged += textEditPosetBarkod_EditValueChanged;
            textEditPosetBarkod.KeyDown += textEditPosetBarkod_KeyDown;
            // 
            // gridControl1
            // 
            gridControl1.DataSource = posetPaketBindingSource;
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(0, 89);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(783, 431);
            gridControl1.TabIndex = 2;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.MouseDown += gridControl1_MouseDown;
            // 
            // posetPaketBindingSource
            // 
            posetPaketBindingSource.DataSource = typeof(EntityLayer.Concrete.PosetPaket);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colPosetBarkod, colPaketBarkod, colCreatedDate, colUserID });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView1.CellValueChanged += gridView1_CellValueChanged;
            gridView1.RowUpdated += gridView1_RowUpdated;
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
            colPosetBarkod.Width = 170;
            // 
            // colPaketBarkod
            // 
            colPaketBarkod.FieldName = "PaketBarkod";
            colPaketBarkod.Name = "colPaketBarkod";
            colPaketBarkod.Visible = true;
            colPaketBarkod.VisibleIndex = 2;
            colPaketBarkod.Width = 170;
            // 
            // colCreatedDate
            // 
            colCreatedDate.Caption = "Oluşturma Tarihi";
            colCreatedDate.FieldName = "CreatedDate";
            colCreatedDate.Name = "colCreatedDate";
            colCreatedDate.Visible = true;
            colCreatedDate.VisibleIndex = 3;
            colCreatedDate.Width = 176;
            // 
            // colUserID
            // 
            colUserID.Caption = "Oluşturan";
            colUserID.FieldName = "UserID";
            colUserID.Name = "colUserID";
            // 
            // popupMenuGrid
            // 
            popupMenuGrid.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemDuzenle), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemSil) });
            popupMenuGrid.Manager = barManager1;
            popupMenuGrid.Name = "popupMenuGrid";
            // 
            // barButtonItemDuzenle
            // 
            barButtonItemDuzenle.Caption = "Düzenle";
            barButtonItemDuzenle.Id = 0;
            barButtonItemDuzenle.ImageOptions.SvgImage = Properties.Resources.editnames;
            barButtonItemDuzenle.Name = "barButtonItemDuzenle";
            barButtonItemDuzenle.ItemClick += barButtonItemDuzenle_ItemClick;
            // 
            // barButtonItemSil
            // 
            barButtonItemSil.Caption = "Çıkar";
            barButtonItemSil.Id = 1;
            barButtonItemSil.ImageOptions.SvgImage = Properties.Resources.delete;
            barButtonItemSil.Name = "barButtonItemSil";
            // 
            // barManager1
            // 
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemDuzenle, barButtonItemSil });
            barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(783, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 520);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(783, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 520);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(783, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 520);
            // 
            // FrmQrCodeOkut
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(783, 520);
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FrmQrCodeOkut";
            Text = "QR Code Okut";
            Load += QrCodeOkut_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEditPaketBarkod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditPosetBarkod.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)posetPaketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenuGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit textEditPosetBarkod;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditPaketBarkod;
        private DevExpress.Utils.Html.HtmlTemplateCollection listBoxControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.PopupMenu popupMenuGrid;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDuzenle;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSil;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource posetPaketBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPosetBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colPaketBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}