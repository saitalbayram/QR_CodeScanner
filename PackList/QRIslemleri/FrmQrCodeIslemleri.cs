using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer.Concrete;
using DataAccesLayer.Entity;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using QR_CodeScanner.Main;

namespace QR_CodeScanner.QRIslemleri
{
    public partial class FrmQrCodeIslemleri : DevExpress.XtraEditors.XtraForm
    {
        IPosetPaketManager paketManager;
        PosetPaket _posetPaket;
        public FrmQrCodeIslemleri()
        {
            InitializeComponent();
            paketManager = new(new EfPosetPaketDal());
            _posetPaket = new PosetPaket();
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            var position = MousePosition;
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(position);
            }
        }

        private void FrmQrCodeIslemleri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = paketManager.TGetList();
            appSettings.EkranGridAyarla(gridView1, this.Name);
        }

        private void barButtonItemDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsBehavior.Editable = true;
        }


        FrmQrCodeOkut codeOkut;
        private void barButtonItemYeniKodOkut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.MdiParent is FrmMain anaSayfa)
            {

                FrmQrCodeOkut satisSiparisi;

                if (anaSayfa.MdiChildren.Any(f => f is FrmQrCodeOkut))
                {
                    satisSiparisi = (FrmQrCodeOkut)anaSayfa.MdiChildren.First(f => f is FrmQrCodeOkut);
                }
                else
                {
                    satisSiparisi = new FrmQrCodeOkut() { MdiParent = anaSayfa };
                    satisSiparisi.Show(); // Formu göster
                }

                satisSiparisi.Activate();
            }
        }

        private void barButtonItemTekrarYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string paketBarcode = gridView1.GetFocusedRowCellValue("PaketBarkod").ToString();
            appSettings.PrintDocument("Etiket", "QR Code", paketBarcode);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                gridView1.SetFocusedRowCellValue("IsCalculated", false);
                if (e.Row is PosetPaket updatedRow)
                    AddRowIfNotExists(updatedRow);
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private HashSet<PosetPaket> newRows = new HashSet<PosetPaket>();

        private void AddRowIfNotExists(PosetPaket row)
        {
            if (row != null && !newRows.Contains(row))
            {
                newRows.Add(row);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (gridView1.GetRow(e.RowHandle) is PosetPaket row)
                    AddRowIfNotExists(row);
            }
            catch (Exception hata)
            {
                XtraMessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
   

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (PosetPaket newRow in newRows)
                {
                    if (newRow != null)
                    {

                        if (newRow.ID <= 0) //veritabanında listedeki satır yoksa yeni ürün olarak kaydediyoruz
                        {
                            paketManager.TInsert(newRow);
                        }
                        else if (newRow.SilinecekSatir == true && newRow.ID > 0)
                        {
                            paketManager.TDelete(newRow);
                        }
                        else //veritabanına listedeki satır varsa ürünü güncelliyoruz
                        {
                            _posetPaket = paketManager.TGetById(newRow.ID);
                            if (_posetPaket != null)
                            {
                                _posetPaket = newRow;
                                paketManager.TUpdate(_posetPaket);
                            }
                        }

                    }
                }
                XtraMessageBox.Show("İşlem Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barButtonItemSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            int[] selectedRows = gridView1.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                if (gridView1.GetRow(rowHandle) is PosetPaket selectedRow)
                {
                    // Sadece ID'si 0 olan satırı kaldır
                    if (selectedRow.ID > 0)
                    {
                        selectedRow.SilinecekSatir = true;
                        newRows.Add(selectedRow);
                        gridView1.DeleteSelectedRows();
                    }
                    else
                    {
                        gridView1.DeleteSelectedRows();
                    }
                }
            }

        }

        private void barButtonItemGorunumuKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            appSettings.GridViewGorunumuKaydet(gridView1, this.Name);
        }
    }
}