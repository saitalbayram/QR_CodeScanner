namespace QR_CodeScanner
{
    partial class QrCodeOkut
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
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPaketBarkod = new DevExpress.XtraEditors.TextEdit();
            this.textEditPosetBarkod = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPaketBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPosetBarkod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl1.Location = new System.Drawing.Point(0, 83);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(579, 318);
            this.listBoxControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButtonKaydet);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textEditPaketBarkod);
            this.panelControl1.Controls.Add(this.textEditPosetBarkod);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(579, 83);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButtonKaydet
            // 
            this.simpleButtonKaydet.Location = new System.Drawing.Point(238, 51);
            this.simpleButtonKaydet.Name = "simpleButtonKaydet";
            this.simpleButtonKaydet.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonKaydet.TabIndex = 4;
            this.simpleButtonKaydet.Text = "Kaydet";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(168, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Paket Barkodu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Poşet Barkodu";
            // 
            // textEditPaketBarkod
            // 
            this.textEditPaketBarkod.Location = new System.Drawing.Point(168, 25);
            this.textEditPaketBarkod.Name = "textEditPaketBarkod";
            this.textEditPaketBarkod.Size = new System.Drawing.Size(145, 20);
            this.textEditPaketBarkod.TabIndex = 1;
            // 
            // textEditPosetBarkod
            // 
            this.textEditPosetBarkod.Location = new System.Drawing.Point(12, 25);
            this.textEditPosetBarkod.Name = "textEditPosetBarkod";
            this.textEditPosetBarkod.Size = new System.Drawing.Size(145, 20);
            this.textEditPosetBarkod.TabIndex = 0;
            this.textEditPosetBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // QrCodeOkut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 401);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "QrCodeOkut";
            this.Text = "QR Code Okut";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPaketBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPosetBarkod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit textEditPosetBarkod;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditPaketBarkod;
    }
}