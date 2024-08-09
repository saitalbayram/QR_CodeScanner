using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CoreLayer.Configurations
{
    public class InvoiceUBL
    {
        public InvoiceUBL() 
        {
        }

        public static void UblOlustur()
        {
            // OpenFileDialog oluştur
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen dosya yolunu al
                    var filePatch = openFileDialog.FileName;

                    // XML dosyasına veri ekle
                    AddDataToXmlFile(filePatch);
                }
            }
        }

        public static void AddDataToXmlFile(string filePath)
        {
            try
            {
                // Var olan XML dosyasını yükle
                XDocument xmlDoc = XDocument.Load(filePath);

                // Yeni bir fatura satırı oluştur
                XElement newInvoiceLine = new XElement("InvoiceLine",
                    new XElement("ID", "2"),
                    new XElement("InvoicedQuantity", new XAttribute("unitCode", "EA"), "5"),
                    new XElement("LineExtensionAmount", new XAttribute("currencyID", "TRY"), "100.00")
                );

                // Var olan XML dosyasına yeni satırı ekle
                xmlDoc.Root.Element("InvoiceLines").Add(newInvoiceLine);

                // Güncellenmiş XML dosyasını kaydet
                xmlDoc.Save(filePath);

                MessageBox.Show("Yeni fatura satırı XML dosyasına eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"XML dosyasına veri eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
