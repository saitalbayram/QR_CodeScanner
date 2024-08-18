using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using DataAccesLayer.Entity;

namespace QR_CodeScanner
{
    public partial class FrmQrCodeOkut : DevExpress.XtraEditors.XtraForm
    {
        IPosetPaketManager _posetPaketManager;
        public FrmQrCodeOkut()
        {
            InitializeComponent();
            _posetPaketManager = new(new EfPosetPaketDal());

        }


        private void textEditPosetBarkod_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void textEditPosetBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (gridControl1.DataSource is System.Data.DataTable dataTable && !string.IsNullOrEmpty(textEditPosetBarkod.Text))
                {
                    DataRow newRow = dataTable.NewRow();
                    int newId = dataTable.Rows.Count + 1;
                    newRow["ID"] = newId;
                    newRow["PosetBarkod"] = textEditPosetBarkod.Text; // PosetBarkod sütunu için TextEdit'teki değer
                    newRow["CreatedDate"] = DateTime.Now; // CreatedDate sütunu için mevcut tarih

                    // Satırı DataTable'a ekleyin
                    dataTable.Rows.Add(newRow);
                }

                textEditPosetBarkod.Text = string.Empty;

            }
        }
        System.Data.DataTable table = new System.Data.DataTable();
        private void QrCodeOkut_Load(object sender, EventArgs e)
        {

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("PosetBarkod", typeof(string));
            table.Columns.Add("PaketBarkod", typeof(string));
            table.Columns.Add("CreatedDate", typeof(DateTime));
            table.Columns.Add("UserID", typeof(int));
            gridControl1.DataSource = table;
        }

        private void gridControl1_MouseDown(object sender, MouseEventArgs e)
        {
            var position = MousePosition;
            if (e.Button == MouseButtons.Right)
            {
                popupMenuGrid.ShowPopup(position);
            }
        }

        private void barButtonItemDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsBehavior.Editable = true;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
        }

        private void Kaydet()
        {
            try
            {
                string paketBarkod = textEditPaketBarkod.Text;

                if (!string.IsNullOrEmpty(paketBarkod))
                {
                    splashScreenManager1.ShowWaitForm();
                    if (gridControl1.DataSource is System.Data.DataTable dataTable)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            if (string.IsNullOrEmpty(row["PaketBarkod"].ToString()))
                            {
                                row["PaketBarkod"] = paketBarkod;
                            }
                        }
                    }
                    SaveToDatabase();
                    ClearGridView();
                    splashScreenManager1.CloseWaitForm();
                    textEditPosetBarkod.Focus();                  

                }
                else
                {
                    XtraMessageBox.Show("Lütfen Paket Barkodu Yazınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Kaydet();

        }
        PosetPaket posetPaket;
        List<PosetPaket> posetPakets = [];
        private void SaveToDatabase()
        {
            try
            {               
                if (gridControl1.DataSource is System.Data.DataTable dataTable)
                {
                    
                    foreach (DataRow row in dataTable.Rows)
                    {
                        posetPaket = new()
                        {
                            PosetBarkod = row["PosetBarkod"].ToString(),
                            PaketBarkod = row["PaketBarkod"].ToString(),
                            CreatedDate = Convert.ToDateTime(row["CreatedDate"]),
                            UserID = Convert.ToInt32(appSettings.UserID)
                        };

                        posetPakets.Add(posetPaket);
                    }

                    if (posetPakets.Count > 0)
                    {
                        foreach (var item in posetPakets)
                        {
                            _posetPaketManager.TInsert(item);
                        }
                        appSettings.PrintDocument("Etiket", "QR Code", posetPaket.PaketBarkod.ToString());
                    }
                    else
                    {
                        XtraMessageBox.Show("Lütfen önce poşet barkodlarını okutun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Hata: "+ ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void ClearGridView()
        {
            if (gridControl1.DataSource is System.Data.DataTable dataTable)
            {
                dataTable.Clear();
                gridControl1.DataSource = dataTable;
                textEditPaketBarkod.Text = string.Empty;
            }
        }

        private void textEditPaketBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Kaydet();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var pack = _posetPaketManager.GetPackFromMaxId();
            if(pack != null)
            {
                appSettings.PrintDocument("Etiket", "QR Code", pack.PaketBarkod);
            }
            else
            {
                XtraMessageBox.Show("Kayıtlı barkod bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}