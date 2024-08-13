using QR_CodeScanner;
using System.Drawing;
using System.Windows.Forms;

namespace OnMuhasebe.Settings
{
    partial class FrmDatabaseSettings
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition9 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition10 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition11 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition12 = new DevExpress.XtraLayout.RowDefinition();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            simpleButtonTestEt = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            lookUpEditAuth = new DevExpress.XtraEditors.LookUpEdit();
            lookUpEditDatabase = new DevExpress.XtraEditors.LookUpEdit();
            textEditPass = new DevExpress.XtraEditors.TextEdit();
            textEditUserName = new DevExpress.XtraEditors.TextEdit();
            textEditServerName = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEditAuth.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditDatabase.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditPass.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditUserName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditServerName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(simpleButtonTestEt);
            panelControl1.Controls.Add(simpleButton1);
            panelControl1.Dock = DockStyle.Bottom;
            panelControl1.Location = new Point(0, 282);
            panelControl1.Margin = new Padding(3, 2, 3, 2);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(473, 34);
            panelControl1.TabIndex = 0;
            // 
            // simpleButtonTestEt
            // 
            simpleButtonTestEt.Dock = DockStyle.Left;
            simpleButtonTestEt.Location = new Point(2, 2);
            simpleButtonTestEt.Margin = new Padding(3, 2, 3, 2);
            simpleButtonTestEt.Name = "simpleButtonTestEt";
            simpleButtonTestEt.Size = new Size(101, 30);
            simpleButtonTestEt.TabIndex = 1;
            simpleButtonTestEt.Text = "Bağlantıyı Test Et";
            simpleButtonTestEt.Click += simpleButtonTestEt_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.Dock = DockStyle.Right;
            simpleButton1.Location = new Point(370, 2);
            simpleButton1.Margin = new Padding(3, 2, 3, 2);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(101, 30);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "Kaydet";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(lookUpEditAuth);
            layoutControl1.Controls.Add(lookUpEditDatabase);
            layoutControl1.Controls.Add(textEditPass);
            layoutControl1.Controls.Add(textEditUserName);
            layoutControl1.Controls.Add(textEditServerName);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Margin = new Padding(3, 2, 3, 2);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(473, 282);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // lookUpEditAuth
            // 
            lookUpEditAuth.Location = new Point(12, 76);
            lookUpEditAuth.Name = "lookUpEditAuth";
            lookUpEditAuth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEditAuth.Properties.NullText = "Seçim Yapınız...";
            lookUpEditAuth.Size = new Size(449, 22);
            lookUpEditAuth.StyleController = layoutControl1;
            lookUpEditAuth.TabIndex = 9;
            lookUpEditAuth.EditValueChanged += lookUpEditAuth_EditValueChanged;
            lookUpEditAuth.Leave += textEditPass_Leave;
            // 
            // lookUpEditDatabase
            // 
            lookUpEditDatabase.Location = new Point(14, 221);
            lookUpEditDatabase.Margin = new Padding(3, 2, 3, 2);
            lookUpEditDatabase.Name = "lookUpEditDatabase";
            lookUpEditDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEditDatabase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            lookUpEditDatabase.Size = new Size(445, 22);
            lookUpEditDatabase.StyleController = layoutControl1;
            lookUpEditDatabase.TabIndex = 7;
            // 
            // textEditPass
            // 
            textEditPass.Location = new Point(14, 173);
            textEditPass.Margin = new Padding(3, 2, 3, 2);
            textEditPass.Name = "textEditPass";
            textEditPass.Size = new Size(445, 22);
            textEditPass.StyleController = layoutControl1;
            textEditPass.TabIndex = 6;
            textEditPass.EditValueChanged += textEditPass_EditValueChanged;
            textEditPass.Leave += textEditPass_Leave;
            // 
            // textEditUserName
            // 
            textEditUserName.Location = new Point(14, 125);
            textEditUserName.Margin = new Padding(3, 2, 3, 2);
            textEditUserName.Name = "textEditUserName";
            textEditUserName.Size = new Size(445, 22);
            textEditUserName.StyleController = layoutControl1;
            textEditUserName.TabIndex = 5;
            textEditUserName.Leave += textEditPass_Leave;
            // 
            // textEditServerName
            // 
            textEditServerName.Location = new Point(14, 31);
            textEditServerName.Margin = new Padding(3, 2, 3, 2);
            textEditServerName.Name = "textEditServerName";
            textEditServerName.RightToLeft = RightToLeft.No;
            textEditServerName.Size = new Size(445, 22);
            textEditServerName.StyleController = layoutControl1;
            textEditServerName.TabIndex = 4;
            textEditServerName.Leave += textEditPass_Leave;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem6 });
            Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            Root.Name = "Root";
            columnDefinition2.SizeType = SizeType.Percent;
            columnDefinition2.Width = 100D;
            Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] { columnDefinition2 });
            rowDefinition7.Height = 10D;
            rowDefinition7.SizeType = SizeType.Percent;
            rowDefinition8.Height = 10D;
            rowDefinition8.SizeType = SizeType.Percent;
            rowDefinition9.Height = 10D;
            rowDefinition9.SizeType = SizeType.Percent;
            rowDefinition10.Height = 10D;
            rowDefinition10.SizeType = SizeType.Percent;
            rowDefinition11.Height = 10D;
            rowDefinition11.SizeType = SizeType.Percent;
            rowDefinition12.Height = 5D;
            rowDefinition12.SizeType = SizeType.Percent;
            Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] { rowDefinition7, rowDefinition8, rowDefinition9, rowDefinition10, rowDefinition11, rowDefinition12 });
            Root.ShowInCustomizationForm = false;
            Root.Size = new Size(473, 282);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEditServerName;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            layoutControlItem1.Size = new Size(453, 47);
            layoutControlItem1.Text = "Sunucu Adı/IP Adresi";
            layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            layoutControlItem1.TextSize = new Size(100, 13);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = textEditUserName;
            layoutControlItem2.Location = new Point(0, 94);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.OptionsTableLayoutItem.RowIndex = 2;
            layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            layoutControlItem2.Size = new Size(453, 48);
            layoutControlItem2.Text = "Kullanıcı Adı";
            layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            layoutControlItem2.TextSize = new Size(100, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = textEditPass;
            layoutControlItem3.Location = new Point(0, 142);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.OptionsTableLayoutItem.RowIndex = 3;
            layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            layoutControlItem3.Size = new Size(453, 48);
            layoutControlItem3.Text = "Şifre";
            layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            layoutControlItem3.TextSize = new Size(100, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = lookUpEditDatabase;
            layoutControlItem4.Location = new Point(0, 190);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.OptionsTableLayoutItem.RowIndex = 4;
            layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            layoutControlItem4.Size = new Size(453, 48);
            layoutControlItem4.Text = "Veritabanı";
            layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            layoutControlItem4.TextSize = new Size(100, 13);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = lookUpEditAuth;
            layoutControlItem6.Location = new Point(0, 47);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.OptionsTableLayoutItem.RowIndex = 1;
            layoutControlItem6.Size = new Size(453, 47);
            layoutControlItem6.Text = "Doğrulama Şekli";
            layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            layoutControlItem6.TextSize = new Size(100, 13);
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // FrmDatabaseSettings
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 316);
            Controls.Add(layoutControl1);
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDatabaseSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veritabanı Ayarları";
            Load += FrmDatabaseSettings_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lookUpEditAuth.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEditDatabase.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditPass.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditServerName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDatabase;
        private DevExpress.XtraEditors.TextEdit textEditPass;
        private DevExpress.XtraEditors.TextEdit textEditUserName;
        private DevExpress.XtraEditors.TextEdit textEditServerName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTestEt;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditAuth;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}