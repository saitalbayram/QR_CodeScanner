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

namespace QR_CodeScanner.QRIslemleri
{
    public partial class FrmQrCodeIslemleri : DevExpress.XtraEditors.XtraForm
    {
        public FrmQrCodeIslemleri()
        {
            InitializeComponent();
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            var position = MousePosition;
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(position);
            }
        }
    }
}