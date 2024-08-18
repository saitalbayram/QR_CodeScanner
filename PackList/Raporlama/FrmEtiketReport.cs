using BusinessLayer.Concrete;
using DataAccesLayer.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System;
using System.IO;
using System.Windows.Forms;

namespace QR_CodeScanner
{
    public partial class FrmEtiketReport : DevExpress.XtraEditors.XtraForm
    {
        XtraReport report = new XtraReport();
        IFilesManager _filesManager;
        public int etiketID = 0;
        public FrmEtiketReport()
        {
            InitializeComponent();
            _filesManager = new(new EfFilesDal());
        }

        private void FrmEtiketReport_Load(object sender, EventArgs e)
        {
            try
            {
                if (etiketID > 0)
                {
                    var files = _filesManager.TGetById(etiketID);
                    if (files.ReportFile != null)
                    {
                        MemoryStream ms = new(files.ReportFile);
                        report = XtraReport.FromStream(ms, true);
                    }
                }

                reportDesigner1.SqlWizardSettings.AlwaysSaveCredentials = true;

                reportDesigner1.SqlWizardSettings.EnableCustomSql = true;
                reportDesigner1.OpenReport(report);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void bbiSaveFile_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using MemoryStream ms = new();
                report.SaveLayoutToXml(ms);

                var files = _filesManager.TGetById(etiketID);
                files.ReportFile = ms.ToArray();
                files.ModuleName = "Etiket";
                _filesManager.TUpdate(files);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }


        private void reportDesigner1_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e)
        {
            XRDesignPanel panel = (XRDesignPanel)sender;
            panel.AddCommandHandler(new SaveCommandHandler(panel));
        }
    }


    public class SaveCommandHandler : DevExpress.XtraReports.UserDesigner.ICommandHandler
    {
        XRDesignPanel panel;
        public SaveCommandHandler(XRDesignPanel panel)
        {
            this.panel = panel;
        }

        public void HandleCommand(DevExpress.XtraReports.UserDesigner.ReportCommand command, object[] args)
        {
            panel.ReportState = ReportState.Saved;
        }

        public bool CanHandleCommand(DevExpress.XtraReports.UserDesigner.ReportCommand command, ref bool useNextHandler)
        {
            useNextHandler = !(command == ReportCommand.SaveFile || command == ReportCommand.SaveFileAs);
            return !useNextHandler;
        }
    }
}