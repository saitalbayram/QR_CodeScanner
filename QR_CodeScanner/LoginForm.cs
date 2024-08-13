using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccesLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccesLayer.Entity;
using QR_CodeScanner.Main;
using System.Reflection;
using System.Threading;

namespace QR_CodeScanner
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        IAppUserManager _appUserManager;
        public LoginForm()
        {
            InitializeComponent();
            UpdateRegion();
            UpdatePictureEditRegion();
            _appUserManager = new(new EfAppUserDal());
        }

        private int radius = 30;



        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = GetRoundedRectPath(ClientRectangle, radius))
            {
                e.Graphics.FillPath(Brushes.Transparent, path); // Formun içini doldur
            }
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            UpdateRegion();
        }
        private void UpdateRegion()
        {
            using (GraphicsPath path = GetRoundedRectPath(ClientRectangle, radius))
            {
                this.Region = new Region(path);
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            // Sol üst köşe
            path.AddArc(arc, 180, 90);

            // Sağ üst köşe
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Sağ alt köşe
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Sol alt köşe
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void pictureEdit1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = GetRoundedRectPath(pictureEdit1.ClientRectangle, 20))
            {
                e.Graphics.SetClip(path);
                e.Graphics.DrawImage(pictureEdit1.Image, pictureEdit1.ClientRectangle);
            }
        }

        private void pictureEdit1_Resize(object sender, EventArgs e)
        {
            UpdatePictureEditRegion();
        }

        private void UpdatePictureEditRegion()
        {
            using (GraphicsPath path = GetRoundedRectPath(pictureEdit1.ClientRectangle, 20))
            {
                pictureEdit1.Region = new Region(path);
            }
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            Giris();
        }
        private void Giris()
        {
            splashScreenManager1.ShowWaitForm();
            if (_appUserManager.CheckUser(textEditUserName.Text, textEditPass.Text))
            {
                Task.Run(() => PreloadAssemblies());
                FrmMain frmMain = new();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                labelControl.Visible = true;
            }
            splashScreenManager1.CloseWaitForm();

        }

        private Dictionary<Type, Form> formCache = new Dictionary<Type, Form>();

        public void PreloadAssemblies()
        {
            // Task ile farklı bir thread'de çalıştırıyoruz
            Task.Run(() =>
            {
                var formTypes = Assembly.GetExecutingAssembly()
                                        .GetTypes()
                                        .Where(t => t.IsSubclassOf(typeof(Form)) && !t.IsAbstract);

                foreach (var formType in formTypes)
                {
                    try
                    {
                        // Formu sadece bir kez oluştur ve sakla
                        if (!formCache.ContainsKey(formType))
                        {
                            var formInstance = (Form)Activator.CreateInstance(formType);

                            formCache[formType] = formInstance;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Ana thread'de çalıştırma
                        this.Invoke(new Action(() =>
                        {
                            XtraMessageBox.Show($"Form Oluşturulamadı {formType.Name}: {ex.Message}");
                        }));
                    }
                }
            });
        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textEditPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Giris();
            }
        }
    }
}