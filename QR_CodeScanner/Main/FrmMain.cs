using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using OnMuhasebe.Settings;
using QR_CodeScanner.QRIslemleri;
using QR_CodeScanner.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_CodeScanner.Main
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        FrmQrCodeOkut frmQrCodeOkut;
        private void BtnQrCodeOkut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmQrCodeOkut == null || frmQrCodeOkut.IsDisposed)
            {
                frmQrCodeOkut = new FrmQrCodeOkut();
                frmQrCodeOkut.MdiParent = this;
                frmQrCodeOkut.Show();
            }
            else
            {
                frmQrCodeOkut.Activate();
            }
        }

        FrmQrCodeIslemleri frmQrCodeIslemleri;
        private void BtnQrIslemleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmQrCodeIslemleri == null || frmQrCodeIslemleri.IsDisposed)
            {
                frmQrCodeIslemleri = new FrmQrCodeIslemleri();
                frmQrCodeIslemleri.MdiParent = this;
                frmQrCodeIslemleri.Show();
            }
            else
            {
                frmQrCodeIslemleri?.Activate();
            }
        }

        FrmRaporlama frmRaporlama;
        private void BtnRaporlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (frmRaporlama == null || frmRaporlama.IsDisposed)
            {
                frmRaporlama = new FrmRaporlama();
                frmRaporlama.MdiParent = this;
                frmRaporlama.Show();
            }
            else
            {
                frmRaporlama?.Activate();
            }
        }

        FmEtiketler fmEtiketler;
        private void BtnEtiketler_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fmEtiketler == null || fmEtiketler.IsDisposed)
            {
                fmEtiketler = new FmEtiketler();
                fmEtiketler.MdiParent = this;
                fmEtiketler.Show();
            }
            else
            {
                fmEtiketler?.Activate();
            }
        }

        FrmUsers frmUsers;
        private void BtnKullanicilar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(frmUsers == null || frmUsers.IsDisposed)
            {
                frmUsers = new FrmUsers();
                frmUsers.MdiParent = this;
                frmUsers.Show();
            }
            else
            {
                frmUsers?.Activate();
            }
        }

        private void BtnVeritabaniAyarlari_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        
        private void BtnBaglantiAyarlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDatabaseSettings databaseSettings = new();
            databaseSettings.ShowDialog();
        }
    }
}