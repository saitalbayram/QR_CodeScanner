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
using DataAccesLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccesLayer.Entity;

namespace QR_CodeScanner.QRIslemleri
{
    public partial class FrmQrCodeIslemleri : DevExpress.XtraEditors.XtraForm
    {
        IPosetPaketManager paketManager;
        public FrmQrCodeIslemleri()
        {
            InitializeComponent();
            paketManager = new(new EfPosetPaketDal());
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            var position = MousePosition;
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(position);
            }
        }

        private void FrmQrCodeIslemleri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = paketManager.TGetList();
        }

        private void barButtonItemDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsBehavior.Editable = true;
        }

        private void barButtonItemYeniKodOkut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}