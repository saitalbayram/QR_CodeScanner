using DevExpress.XtraCharts.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Concrete;
using CoreLayer.Configurations;
using DevExpress.Utils.Registrator;
using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.Entity;
using System.Drawing.Printing;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Wizards;
using static iText.IO.Image.Jpeg2000ImageData;
using System.Data;
using System.Threading;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace QR_CodeScanner
{
    public class appSettings
    {
        public static string ShowInputBox(string uyariMetni, string  baslik, string defaultValue)
        { return Microsoft.VisualBasic.Interaction.InputBox(uyariMetni, baslik, defaultValue); }

        static DevExpress.DataAccess.Sql.SqlDataSource _defaultDataSource;
        public static DevExpress.DataAccess.Sql.SqlDataSource defaultDataSource;

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


        public static void PrintDocument(string moduleName = "", string fileName = "", string parameters = "")
        {
            try
            {
                // LogWriter.LogYaz(KayitID + " nolu barkod yazdırılıyor.. Report ID=" + ReportID, LogWriter.renk.sari);

                IFilesManager filesManager = new(new EfFilesDal());

                var fileBytes = filesManager.GetFileFromNameAndModule(fileName, moduleName);
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
