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
using PdfiumViewer;
using System.Windows.Forms;

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


        public static void PrintFile(string fileName, string ModuleName)
        {
            IFilesManager filesManager = new(new EfFilesDal());
            string xmlData = filesManager.GetFileFromNameAndModule(fileName, ModuleName);

            if (!string.IsNullOrEmpty(xmlData))
            {
                // XML'yi PDF'e dönüştür
                byte[] pdfData = ConvertXmlToPdf(xmlData);

                if (pdfData != null)
                {
                    using (MemoryStream ms = new MemoryStream(pdfData))
                    {
                        using (var pdfDocument = PdfiumViewer.PdfDocument.Load(ms))
                        {
                            PrintDocument printDocument = new PrintDocument();
                            printDocument.PrintPage += (sender, e) =>
                            {
                                using (var pdfViewer = new PdfiumViewer.PdfViewer())
                                {
                                    // PDF dosyasını yazdır
                                    //pdfViewer.pr(pdfDocument, e);
                                }
                            };

                            PrintDialog printDialog = new PrintDialog();
                            printDialog.Document = printDocument;

                            if (printDialog.ShowDialog() == DialogResult.OK)
                            {
                                printDocument.Print();
                            }
                        }
                    }
                }
            }
        }


        private static byte[] ConvertXmlToPdf(string xmlData)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // PDF oluştur
                using (PdfWriter writer = new PdfWriter(ms))
                {
                    using (iText.Kernel.Pdf.PdfDocument pdfDoc = new iText.Kernel.Pdf.PdfDocument(writer))
                    {
                        Document document = new Document(pdfDoc);

                        // XML verisini PDF formatına dönüştür
                        document.Add(new Paragraph("XML Data:"));
                        document.Add(new Paragraph(xmlData)); // Basit bir şekilde metin ekliyoruz

                        document.Close();
                    }
                }

                return ms.ToArray();
            }
        }
    }
}
