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

namespace QR_CodeScanner
{
    public partial class QrCodeOkut : DevExpress.XtraEditors.XtraForm
    {
        public QrCodeOkut()
        {
            InitializeComponent();
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int posetBarkod = Convert.ToInt32(textEditPosetBarkod.Text);
                if(listBoxControl1.Items.Count == 0 )
                {
                    listBoxControl1.Items.Add(textEditPosetBarkod.Text);
                }
                else
                {
                    // İlk öğeyi metin olarak alın
                    string firstItemText = listBoxControl1.Items[0].ToString();
                    string posetBarkod = textEditPosetBarkod.Text;
                    // Sayısal karşılıklarını kullanarak döngüyü çalıştırın
                    int firstItemNumber = Convert.ToInt32(firstItemText);
                    int posetBarkodNumber = Convert.ToInt32(posetBarkodText);

                    for (int i = firstItemNumber; i <= posetBarkodNumber; i++)
                    {
                        // Sıfırları koruyarak metin formatında ekleyin
                        string itemText = i.ToString("D" + textEditPosetBarkod.Length);
                        listBoxControl1.Items.Add(itemText);
                    }
                }
               
            }
        }

        private void KodEkle()
        {
            string QrCode = textEditPosetBarkod.Text;


        }
    }
}