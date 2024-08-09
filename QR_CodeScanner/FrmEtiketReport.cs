using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class FrmEtiketReport : DevExpress.XtraEditors.XtraForm
    {
        XtraReport report = new XtraReport();
        public FrmEtiketReport()
        {
            InitializeComponent();
        }

        private void FrmEtiketReport_Load(object sender, EventArgs e)
        {

            report.DataSource = appSettings.defaultDataSource;

            reportDesigner1.SqlWizardSettings.AlwaysSaveCredentials = true;

            reportDesigner1.SqlWizardSettings.EnableCustomSql = true;
            reportDesigner1.OpenReport(report);
        }
    }
}