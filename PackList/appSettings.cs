using System;
using BusinessLayer.Concrete;
using DataAccesLayer.Entity;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace QR_CodeScanner
{
    public class appSettings
    {
        public static IFilesManager _filesManager;

     
        public static string ShowInputBox(string uyariMetni, string  baslik, string defaultValue)
        { return Microsoft.VisualBasic.Interaction.InputBox(uyariMetni, baslik, defaultValue); }

        static DevExpress.DataAccess.Sql.SqlDataSource _defaultDataSource;
        public static DevExpress.DataAccess.Sql.SqlDataSource defaultDataSource;

        public appSettings()
        {
            _filesManager = new(new EfFilesDal());
        }

        //{
        //    get
        //    {
        //        if (_defaultDataSource == null)
        //        {
        //            RegistrySettings registrySettings = RegistryHelper.RegisterKayitOku();

        //            DevExpress.DataAccess.Sql.SqlDataSource dsource = new DevExpress.DataAccess.Sql.SqlDataSource();
        //            dsource.ConnectionName = "QRCodeScanner.ConnectionString";
        //            dsource.ConnectionOptions = new DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType();
        //            dsource.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(registrySettings.ServerName, registrySettings.Database, registrySettings.UserName, registrySettings.Pass, (registrySettings.UserName + "" == "") ? DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows : DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);

        //            _defaultDataSource = dsource;
        //        }
        //        return _defaultDataSource;
        //    }
        // }

        public static int UserID
        {
            get;
            set;
        }
        public void PrintDocument(string moduleName = "", string fileName = "", string parameters = "")
        {
            try
            {
                // LogWriter.LogYaz(KayitID + " nolu barkod yazdırılıyor.. Report ID=" + ReportID, LogWriter.renk.sari);

                 

                var fileBytes = _filesManager.GetFileFromNameAndModule(fileName, moduleName);
                if (fileBytes != null)
                {
                    using var stream = new System.IO.MemoryStream(fileBytes, true);
                    XtraReport report = XtraReport.FromStream(stream);

                    if(report != null)
                    {
                        if (!string.IsNullOrEmpty(parameters) && report.Parameters.Count > 0)
                        {
                            report.Parameters[0].Value = parameters;
                        }

                        report.Print();
                    }
                    else
                    {
                        XtraMessageBox.Show("Rapor formatı oluşturulmamış veya yanlış oluşturulmuş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
          


        }
        public static void GridViewGorunumuKaydet(GridView grid, string formAdi)
        {
            try
            {
                string patch = "Bt.glb.Grid_XML_Patha" + formAdi + ".xml";
                grid.SaveLayoutToXml(patch);
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void EkranGridAyarla(GridView gridView, string formAdi)
        {
            try
            {
                string fileName = "Bt.glb.Grid_XML_Patha" + formAdi + ".xml";
                if (File.Exists(fileName))
                {
                    gridView.RestoreLayoutFromXml(fileName);
                }
            }
            catch (System.IO.FileNotFoundException hata)
            {
                XtraMessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
