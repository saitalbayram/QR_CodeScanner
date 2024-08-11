using DevExpress.XtraEditors;
using QR_CodeScanner.QRIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_CodeScanner
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }


        QrCodeOkut qrCodeOkut;
        private void BtnQrOkut_Click(object sender, EventArgs e)
        {
            if (qrCodeOkut == null || qrCodeOkut.IsDisposed)
            {
                qrCodeOkut = new QrCodeOkut();
                qrCodeOkut.MdiParent = this;
                qrCodeOkut.Show();
            }
            else
            {
                qrCodeOkut.Activate();
            }
        }

        FmEtiketler fmEtiketler;
        private void BtnEtiketler_Click(object sender, EventArgs e)
        {
            if (fmEtiketler == null || fmEtiketler.IsDisposed)
            {
                fmEtiketler = new FmEtiketler();
                fmEtiketler.MdiParent = this;
                fmEtiketler.Show();
            }
            else
            {
                fmEtiketler.Activate();
            }
        }

        FrmRaporlama fmRaporlama;
        private void Btnraporlar_Click(object sender, EventArgs e)
        {
            if (fmRaporlama == null || fmRaporlama.IsDisposed)
            {
                fmRaporlama = new FrmRaporlama();
                fmRaporlama.MdiParent = this;
                fmRaporlama.Show();
            }
            else
            {
                fmRaporlama.Activate();
            }
        }

        FrmQrCodeIslemleri qrIslemleri;
        private void BtnQrIslemleri_Click(object sender, EventArgs e)
        {
            if(qrIslemleri == null || qrIslemleri.IsDisposed)
            {
                qrIslemleri = new FrmQrCodeIslemleri();
                qrIslemleri.MdiParent= this;
                qrIslemleri.Show();
            }
            else
            {
                qrIslemleri.Activate();
            }
        }
    }
}