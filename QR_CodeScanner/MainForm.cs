using DevExpress.XtraEditors;
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

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        QrCodeOkut qrCodeOkut;
        private void BtnQrOkut_Click(object sender, EventArgs e)
        {
            if(qrCodeOkut == null || qrCodeOkut.IsDisposed)
            {
                qrCodeOkut = new QrCodeOkut();
                qrCodeOkut.MdiParent = this;
                qrCodeOkut.Show();
            }
        }
    }
}