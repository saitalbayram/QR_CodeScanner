namespace QR_CodeScanner
{
    partial class FrmRaporlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlama));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            posetPaketBindingSource = new System.Windows.Forms.BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colPosetBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            colPaketBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)posetPaketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.DataSource = posetPaketBindingSource;
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(0, 97);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(796, 447);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // posetPaketBindingSource
            // 
            posetPaketBindingSource.DataSource = typeof(EntityLayer.Concrete.PosetPaket);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colPosetBarkod, colPaketBarkod, colUserID, colCreatedDate });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsMenu.ShowAutoFilterRowItem = false;
            gridView1.OptionsView.ShowAutoFilterRow = true;
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
            colPosetBarkod.Width = 146;
            // 
            // colPaketBarkod
            // 
            colPaketBarkod.FieldName = "PaketBarkod";
            colPaketBarkod.Name = "colPaketBarkod";
            colPaketBarkod.Visible = true;
            colPaketBarkod.VisibleIndex = 2;
            colPaketBarkod.Width = 146;
            // 
            // colUserID
            // 
            colUserID.Caption = "Oluşturma Tarihi";
            colUserID.FieldName = "UserID";
            colUserID.Name = "colUserID";
            colUserID.Visible = true;
            colUserID.VisibleIndex = 3;
            colUserID.Width = 146;
            // 
            // colCreatedDate
            // 
            colCreatedDate.Caption = "Oluşturma Tarihi";
            colCreatedDate.FieldName = "CreatedDate";
            colCreatedDate.Name = "colCreatedDate";
            colCreatedDate.Visible = true;
            colCreatedDate.VisibleIndex = 4;
            colCreatedDate.Width = 149;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(pictureEdit1);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(796, 97);
            panelControl1.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new System.Drawing.Point(5, 12);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit1.Size = new System.Drawing.Size(80, 79);
            pictureEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.LightGray;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(101, 38);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(148, 33);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Raporlama";
            // 
            // FrmRaporlama
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(796, 544);
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Name = "FrmRaporlama";
            Text = "FrmRaporlama";
            Load += FrmRaporlama_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)posetPaketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource posetPaketBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPosetBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colPaketBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
    }
}