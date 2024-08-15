namespace QR_CodeScanner.Settings
{
    partial class FrmUsers
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
            appUserBindingSource = new System.Windows.Forms.BindingSource(components);
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemTextEditPass = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
            barButtonItemEkle = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemDuzenle = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemSil = new DevExpress.XtraBars.BarButtonItem();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            simpleButtonVazgec = new DevExpress.XtraEditors.SimpleButton();
            simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)appUserBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEditPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // appUserBindingSource
            // 
            appUserBindingSource.DataSource = typeof(EntityLayer.Concrete.AppUser);
            // 
            // gridControl1
            // 
            gridControl1.DataSource = typeof(EntityLayer.Concrete.AppUser);
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(0, 86);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemTextEditPass });
            gridControl1.Size = new System.Drawing.Size(770, 471);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colFirstName, colLastName, colUserName, colPassword });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.CellValueChanged += gridView1_CellValueChanged;
            gridView1.RowUpdated += gridView1_RowUpdated;
            gridView1.MouseDown += gridView1_MouseDown;
            // 
            // colID
            // 
            colID.FieldName = "ID";
            colID.Name = "colID";
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 48;
            // 
            // colFirstName
            // 
            colFirstName.Caption = "Adı";
            colFirstName.FieldName = "FirstName";
            colFirstName.Name = "colFirstName";
            colFirstName.Visible = true;
            colFirstName.VisibleIndex = 1;
            colFirstName.Width = 189;
            // 
            // colLastName
            // 
            colLastName.Caption = "Soyadı";
            colLastName.FieldName = "LastName";
            colLastName.Name = "colLastName";
            colLastName.Visible = true;
            colLastName.VisibleIndex = 2;
            colLastName.Width = 189;
            // 
            // colUserName
            // 
            colUserName.Caption = "Kullanıcı Adı";
            colUserName.FieldName = "UserName";
            colUserName.Name = "colUserName";
            colUserName.Visible = true;
            colUserName.VisibleIndex = 3;
            colUserName.Width = 189;
            // 
            // colPassword
            // 
            colPassword.Caption = "Şifre";
            colPassword.ColumnEdit = repositoryItemTextEditPass;
            colPassword.FieldName = "Password";
            colPassword.Name = "colPassword";
            colPassword.Visible = true;
            colPassword.VisibleIndex = 4;
            colPassword.Width = 197;
            // 
            // repositoryItemTextEditPass
            // 
            repositoryItemTextEditPass.AutoHeight = false;
            repositoryItemTextEditPass.Name = "repositoryItemTextEditPass";
            repositoryItemTextEditPass.PasswordChar = '*';
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(770, 86);
            panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(12, 22);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(198, 42);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Kullanıcılar";
            // 
            // popupMenu1
            // 
            popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemEkle), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemDuzenle), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemSil) });
            popupMenu1.Manager = barManager1;
            popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItemEkle
            // 
            barButtonItemEkle.Caption = "Yeni Ekle";
            barButtonItemEkle.Id = 0;
            barButtonItemEkle.ImageOptions.SvgImage = Properties.Resources.snapinsertheader;
            barButtonItemEkle.Name = "barButtonItemEkle";
            barButtonItemEkle.ItemClick += barButtonItemEkle_ItemClick;
            // 
            // barButtonItemDuzenle
            // 
            barButtonItemDuzenle.Caption = "Düzenle";
            barButtonItemDuzenle.Id = 1;
            barButtonItemDuzenle.ImageOptions.SvgImage = Properties.Resources.editnames3;
            barButtonItemDuzenle.Name = "barButtonItemDuzenle";
            barButtonItemDuzenle.ItemClick += barButtonItemDuzenle_ItemClick;
            // 
            // barButtonItemSil
            // 
            barButtonItemSil.Caption = "Sil";
            barButtonItemSil.Id = 2;
            barButtonItemSil.ImageOptions.SvgImage = Properties.Resources.delete1;
            barButtonItemSil.Name = "barButtonItemSil";
            barButtonItemSil.ItemClick += barButtonItemSil_ItemClick;
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
            barDockControlTop.Size = new System.Drawing.Size(770, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 593);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(770, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 593);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(770, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 593);
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(simpleButtonVazgec);
            panelControl2.Controls.Add(simpleButtonKaydet);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl2.Location = new System.Drawing.Point(0, 557);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(770, 36);
            panelControl2.TabIndex = 6;
            // 
            // simpleButtonVazgec
            // 
            simpleButtonVazgec.Dock = System.Windows.Forms.DockStyle.Right;
            simpleButtonVazgec.Location = new System.Drawing.Point(618, 2);
            simpleButtonVazgec.Name = "simpleButtonVazgec";
            simpleButtonVazgec.Size = new System.Drawing.Size(75, 32);
            simpleButtonVazgec.TabIndex = 1;
            simpleButtonVazgec.Text = "Vazgeç";
            simpleButtonVazgec.Click += simpleButtonVazgec_Click;
            // 
            // simpleButtonKaydet
            // 
            simpleButtonKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            simpleButtonKaydet.Location = new System.Drawing.Point(693, 2);
            simpleButtonKaydet.Name = "simpleButtonKaydet";
            simpleButtonKaydet.Size = new System.Drawing.Size(75, 32);
            simpleButtonKaydet.TabIndex = 0;
            simpleButtonKaydet.Text = "Kaydet";
            simpleButtonKaydet.Click += simpleButtonKaydet_Click;
            // 
            // FrmUsers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(770, 593);
            Controls.Add(gridControl1);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "FrmUsers";
            Text = "FrmUsers";
            ((System.ComponentModel.ISupportInitialize)appUserBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEditPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditPass;
        private System.Windows.Forms.BindingSource appUserBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEkle;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDuzenle;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSil;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonVazgec;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
    }
}