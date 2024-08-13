namespace QR_CodeScanner
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            textEditUserName = new DevExpress.XtraEditors.TextEdit();
            textEditPass = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            BtnGiris = new DevExpress.XtraEditors.SimpleButton();
            Btnİptal = new DevExpress.XtraEditors.SimpleButton();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl = new DevExpress.XtraEditors.LabelControl();
            splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)textEditUserName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditPass.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // textEditUserName
            // 
            textEditUserName.Location = new System.Drawing.Point(303, 214);
            textEditUserName.Name = "textEditUserName";
            textEditUserName.Size = new System.Drawing.Size(221, 22);
            textEditUserName.TabIndex = 0;
            textEditUserName.KeyDown += textEditPass_KeyDown;
            // 
            // textEditPass
            // 
            textEditPass.Location = new System.Drawing.Point(303, 263);
            textEditPass.Name = "textEditPass";
            textEditPass.Properties.PasswordChar = '*';
            textEditPass.Size = new System.Drawing.Size(221, 22);
            textEditPass.TabIndex = 1;
            textEditPass.KeyDown += textEditPass_KeyDown;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(303, 195);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(55, 13);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Kullanıcı Adı";
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(303, 244);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(22, 13);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Şifre";
            // 
            // BtnGiris
            // 
            BtnGiris.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BtnGiris.ImageOptions.Image");
            BtnGiris.Location = new System.Drawing.Point(432, 296);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new System.Drawing.Size(92, 34);
            BtnGiris.TabIndex = 4;
            BtnGiris.Text = "Giriş Yap";
            BtnGiris.Click += BtnGiris_Click;
            // 
            // Btnİptal
            // 
            Btnİptal.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Btnİptal.ImageOptions.SvgImage");
            Btnİptal.Location = new System.Drawing.Point(334, 296);
            Btnİptal.Name = "Btnİptal";
            Btnİptal.Size = new System.Drawing.Size(92, 34);
            Btnİptal.TabIndex = 5;
            Btnİptal.Text = "İptal";
            Btnİptal.Click += Btnİptal_Click;
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new System.Drawing.Point(21, 119);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit1.Size = new System.Drawing.Size(254, 229);
            pictureEdit1.TabIndex = 6;
            pictureEdit1.Paint += pictureEdit1_Paint;
            pictureEdit1.Resize += pictureEdit1_Resize;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl3.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.LineVisible = true;
            labelControl3.Location = new System.Drawing.Point(361, 93);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(85, 45);
            labelControl3.TabIndex = 7;
            labelControl3.Text = "Giriş";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl4.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseForeColor = true;
            labelControl4.LineVisible = true;
            labelControl4.Location = new System.Drawing.Point(106, 42);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(358, 45);
            labelControl4.TabIndex = 8;
            labelControl4.Text = "QR Code Generator";
            // 
            // labelControl
            // 
            labelControl.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 162);
            labelControl.Appearance.ForeColor = System.Drawing.Color.Red;
            labelControl.Appearance.Options.UseFont = true;
            labelControl.Appearance.Options.UseForeColor = true;
            labelControl.Location = new System.Drawing.Point(324, 162);
            labelControl.Name = "labelControl";
            labelControl.Size = new System.Drawing.Size(168, 15);
            labelControl.TabIndex = 9;
            labelControl.Text = "Kullanıcı Adı veya Şifre Yanlış!";
            labelControl.Visible = false;
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(555, 391);
            Controls.Add(labelControl);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(pictureEdit1);
            Controls.Add(Btnİptal);
            Controls.Add(BtnGiris);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(textEditPass);
            Controls.Add(textEditUserName);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            LookAndFeel.SkinName = "WXI";
            LookAndFeel.UseDefaultLookAndFeel = false;
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Paint += LoginForm_Paint;
            Resize += LoginForm_Resize;
            ((System.ComponentModel.ISupportInitialize)textEditUserName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditPass.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditUserName;
        private DevExpress.XtraEditors.TextEdit textEditPass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnGiris;
        private DevExpress.XtraEditors.SimpleButton Btnİptal;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}