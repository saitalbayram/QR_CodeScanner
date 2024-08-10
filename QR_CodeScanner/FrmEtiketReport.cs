using BusinessLayer.Concrete;
using DataAccesLayer.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_CodeScanner
{
    public partial class FrmEtiketReport : DevExpress.XtraEditors.XtraForm
    {
        XtraReport report = new XtraReport();
        IFilesManager _filesManager;
        public FrmEtiketReport()
        {
            InitializeComponent();
            _filesManager = new IFilesManager(new EfFilesDal());
        }

        private void FrmEtiketReport_Load(object sender, EventArgs e)
        {

            //report.DataSource = appSettings.defaultDataSource;

            reportDesigner1.SqlWizardSettings.AlwaysSaveCredentials = true;

            reportDesigner1.SqlWizardSettings.EnableCustomSql = true;
            reportDesigner1.OpenReport(report);
        }

        private void bbiSaveFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            var files = new Files();
            files.ReportFile = ms.ToArray();
            files.
            report.SaveLayout(ms);

        }
    }
}