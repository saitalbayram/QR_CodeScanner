namespace QR_CodeScanner
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            BtnQrOkut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            BtnQrIslemleri = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            Btnraporlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            BtnEtiketler = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // accordionControl1
            // 
            accordionControl1.Appearance.AccordionControl.BorderColor = System.Drawing.Color.Black;
            accordionControl1.Appearance.AccordionControl.Options.UseBorderColor = true;
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1, accordionControlSeparator2, accordionControlElement2, accordionControlSeparator1, accordionControlElement3, accordionControlSeparator3 });
            accordionControl1.Location = new System.Drawing.Point(0, 96);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.Size = new System.Drawing.Size(250, 526);
            accordionControl1.TabIndex = 0;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { BtnQrOkut, BtnQrIslemleri });
            accordionControlElement1.Expanded = true;
            accordionControlElement1.Height = 40;
            accordionControlElement1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElement1.ImageOptions.SvgImage");
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "QR İşlemleri";
            // 
            // BtnQrOkut
            // 
            BtnQrOkut.Name = "BtnQrOkut";
            BtnQrOkut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            BtnQrOkut.Text = "QR Okut";
            BtnQrOkut.Click += BtnQrOkut_Click;
            // 
            // BtnQrIslemleri
            // 
            BtnQrIslemleri.Name = "BtnQrIslemleri";
            BtnQrIslemleri.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            BtnQrIslemleri.Text = "QR İşlemleri";
            BtnQrIslemleri.Click += BtnQrIslemleri_Click;
            // 
            // accordionControlSeparator2
            // 
            accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // accordionControlElement2
            // 
            accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { Btnraporlar, BtnEtiketler });
            accordionControlElement2.Height = 40;
            accordionControlElement2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement2.ImageOptions.Image");
            accordionControlElement2.Name = "accordionControlElement2";
            accordionControlElement2.Text = "Raporlama";
            // 
            // Btnraporlar
            // 
            Btnraporlar.Name = "Btnraporlar";
            Btnraporlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            Btnraporlar.Text = "Raporlar";
            Btnraporlar.Click += Btnraporlar_Click;
            // 
            // BtnEtiketler
            // 
            BtnEtiketler.Name = "BtnEtiketler";
            BtnEtiketler.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            BtnEtiketler.Text = "Etiketler";
            BtnEtiketler.Click += BtnEtiketler_Click;
            // 
            // accordionControlSeparator1
            // 
            accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlElement3
            // 
            accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement4 });
            accordionControlElement3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("accordionControlElement3.ImageOptions.SvgImage");
            accordionControlElement3.Name = "accordionControlElement3";
            accordionControlElement3.Text = "Ayarlar";
            // 
            // accordionControlElement4
            // 
            accordionControlElement4.Name = "accordionControlElement4";
            accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement4.Text = "Kullanııcı Ayarları";
            // 
            // accordionControlSeparator3
            // 
            accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(pictureEdit1);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1093, 96);
            panelControl1.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new System.Drawing.Point(12, 5);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit1.Size = new System.Drawing.Size(92, 85);
            pictureEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new System.Drawing.Point(110, 34);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(251, 35);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "QR Code Scanner";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1093, 622);
            Controls.Add(accordionControl1);
            Controls.Add(panelControl1);
            IsMdiContainer = true;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnQrOkut;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnQrIslemleri;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btnraporlar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnEtiketler;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}