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
using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccesLayer.Entity;

namespace QR_CodeScanner
{
    public partial class FrmRaporlama : DevExpress.XtraEditors.XtraForm
    {
        IPosetPaketManager _paketManager;
        public FrmRaporlama()
        {
            InitializeComponent();
            _paketManager = new(new EfPosetPaketDal());
        }

        private void FrmRaporlama_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = _paketManager.TGetList();
        }
    }
}