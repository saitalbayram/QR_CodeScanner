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
using Microsoft.EntityFrameworkCore;
using EntityLayer.Concrete;
using DataAccesLayer.Concrete;
using CoreLayer.Configurations;
using CoreLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccesLayer.Entity;

namespace QR_CodeScanner
{
    public partial class FmEtiketler : DevExpress.XtraEditors.XtraForm
    {
        IFilesManager _filesManager;
        public FmEtiketler()
        {
            InitializeComponent();
            _filesManager = new(new EfFilesDal());
            Listele();
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            var position = MousePosition;
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(position);
        }

        public void Listele()
        {
            DataAccesLayer.Concrete.Context dbContext = new Context();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Files.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.Files.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void barButtonItemEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string reportName = appSettings.ShowInputBox("Rapor Adı", "Rapor Adı", "Modul");
            Files files = new()
            {
                FileName = reportName,
                ModuleName = "Etiket",
            };

            if (files.ModuleName != null)
                _filesManager.TInsert(files);
            FrmEtiketReport etiketReport = new()
            {
                etiketID = files.ID
            };
            etiketReport.Show();
        }

        private void barButtonItemDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEtiketReport etiketReport = new()
            {
                etiketID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"))
            };
            etiketReport.Show();

        }

        private void barButtonItemSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            var file = _filesManager.TGetById(id);
            _filesManager.TDelete(file);
            Listele();

        }
    }
}