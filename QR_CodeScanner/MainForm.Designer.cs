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
            BtnQrSil = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            Btnraporlar = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            BtnEtiketler = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1, accordionControlElement2 });
            accordionControl1.Location = new System.Drawing.Point(0, 0);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.Size = new System.Drawing.Size(250, 488);
            accordionControl1.TabIndex = 0;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { BtnQrOkut, BtnQrSil });
            accordionControlElement1.Expanded = true;
            accordionControlElement1.Height = 40;
            accordionControlElement1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement1.ImageOptions.Image");
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
            // BtnQrSil
            // 
            BtnQrSil.Name = "BtnQrSil";
            BtnQrSil.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            BtnQrSil.Text = "QR Sil";
            // 
            // accordionControlElement2
            // 
            accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { Btnraporlar, BtnEtiketler });
            accordionControlElement2.Expanded = true;
            accordionControlElement2.Height = 40;
            accordionControlElement2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("accordionControlElement2.ImageOptions.Image");
            accordionControlElement2.Name = "accordionControlElement2";
            accordionControlElement2.Text = "Raporlama";
            accordionControlElement2.Click += accordionControlElement2_Click;
            // 
            // Btnraporlar
            // 
            Btnraporlar.Name = "Btnraporlar";
            Btnraporlar.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            Btnraporlar.Text = "Raporlar";
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // BtnEtiketler
            // 
            BtnEtiketler.Name = "BtnEtiketler";
            BtnEtiketler.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            BtnEtiketler.Text = "Etiketler";
            BtnEtiketler.Click += BtnEtiketler_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(819, 488);
            Controls.Add(accordionControl1);
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnQrOkut;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnQrSil;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Btnraporlar;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnEtiketler;
    }
}