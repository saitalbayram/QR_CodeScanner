namespace QR_CodeScanner
{
    partial class FmEtiketler
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
            barButtonItemEkle = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemDuzenle = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSil = new DevExpress.XtraBars.BarButtonItem();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            posetPaketBindingSource = new System.Windows.Forms.BindingSource(components);
            filesBindingSource = new System.Windows.Forms.BindingSource(components);
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            colModuleNama = new DevExpress.XtraGrid.Columns.GridColumn();
            colReportFile = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)posetPaketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.DataSource = filesBindingSource;
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(658, 492);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colFileName, colModuleNama, colReportFile });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.MouseDown += gridView1_MouseDown;
            // 
            // popupMenu1
            // 
            popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemEkle), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemDuzenle), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemSil) });
            popupMenu1.Manager = barManager1;
            popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItemEkle
            // 
            barButtonItemEkle.Caption = "Ekle";
            barButtonItemEkle.Id = 0;
            barButtonItemEkle.Name = "barButtonItemEkle";
            barButtonItemEkle.ItemClick += barButtonItemEkle_ItemClick;
            // 
            // barButtonItemDuzenle
            // 
            barButtonItemDuzenle.Caption = "Düzenle";
            barButtonItemDuzenle.Id = 1;
            barButtonItemDuzenle.Name = "barButtonItemDuzenle";
            // 
            // barButtonItemSil
            // 
            barButtonItemSil.Caption = "Sil";
            barButtonItemSil.Id = 2;
            barButtonItemSil.Name = "barButtonItemSil";
            // 
            // barManager1
            // 
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemEkle, barButtonItemDuzenle, barButtonItemSil });
            barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(658, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 492);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(658, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 492);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(658, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 492);
            // 
            // posetPaketBindingSource
            // 
            posetPaketBindingSource.DataSource = typeof(EntityLayer.Concrete.PosetPaket);
            // 
            // filesBindingSource
            // 
            filesBindingSource.DataSource = typeof(EntityLayer.Concrete.Files);
            // 
            // colID
            // 
            colID.FieldName = "ID";
            colID.Name = "colID";
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 35;
            // 
            // colFileName
            // 
            colFileName.Caption = "Etiket Adı";
            colFileName.FieldName = "FileName";
            colFileName.Name = "colFileName";
            colFileName.Visible = true;
            colFileName.VisibleIndex = 1;
            colFileName.Width = 297;
            // 
            // colModuleNama
            // 
            colModuleNama.Caption = "Modül Adı";
            colModuleNama.FieldName = "ModuleNama";
            colModuleNama.Name = "colModuleNama";
            colModuleNama.Visible = true;
            colModuleNama.VisibleIndex = 2;
            colModuleNama.Width = 298;
            // 
            // colReportFile
            // 
            colReportFile.FieldName = "ReportFile";
            colReportFile.Name = "colReportFile";
            // 
            // FmEtiketler
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(658, 492);
            Controls.Add(gridControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FmEtiketler";
            Text = "FmEtiketler";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)posetPaketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)filesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEkle;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDuzenle;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSil;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource filesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colModuleNama;
        private DevExpress.XtraGrid.Columns.GridColumn colReportFile;
        private System.Windows.Forms.BindingSource posetPaketBindingSource;
    }
}