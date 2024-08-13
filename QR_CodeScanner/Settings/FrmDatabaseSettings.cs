using DataAccesLayer.Concrete;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using CoreLayer.Configurations;
using CoreLayer.Concrete;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace OnMuhasebe.Settings
{
    public partial class FrmDatabaseSettings : DevExpress.XtraEditors.XtraForm
    {
        public FrmDatabaseSettings()
        {
            InitializeComponent();
        }

        private void FrmDatabaseSettings_Load(object sender, EventArgs e)
        {
            RegistrySettings registrySettings = RegistryHelper.RegisterKayitOku();
            List<string> list = new List<string>();
            list.Add("Windows Authentication");
            list?.Add("SQL Server Authentication");
            lookUpEditAuth.Properties.DataSource = list;

            textEditPass.Text = registrySettings?.Pass;
            textEditServerName.Text = registrySettings?.ServerName;
            textEditUserName.Text = registrySettings?.UserName;
            lookUpEditDatabase.Text = registrySettings?.Database;
            lookUpEditAuth.Text = registrySettings?.Authentication;

        }
        private void BaglantiTestEt()
        {
            // SQL Server bağlantı bilgileri
            string serverName = textEditServerName.Text;
            string userName = textEditUserName.Text;
            string password = textEditPass.Text;
            string connectionString;

            if (lookUpEditAuth.Text == "Windows Authentication")
            {
                connectionString = $"Server={serverName};Integrated Security=True;";
            }
            else
            {
                connectionString = $"Server={serverName};User ID={userName};Password={password};";

            }


            // Bağlantıyı test etme
            try
            {
                using SqlConnection connection = new(connectionString);
                connection.Open();
                XtraMessageBox.Show("Bağlantı başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show("Bağlantı başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            RegistrySettings registrySettings = new()
            {
                ServerName = textEditServerName.Text,
                Database = lookUpEditDatabase.Text,
                UserName = textEditUserName.Text,
                Pass = textEditPass.Text,
                Authentication = lookUpEditAuth.Text
            };

            RegistryHelper.RegisterKayitYaz(registrySettings);
            try
            {
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Veritabanı Güncelleniyor");
                splashScreenManager1.SetWaitFormDescription("Lütfen bekleyin...");

                using var c = new Context();
                c.Database.Migrate();

                splashScreenManager1.CloseWaitForm();
                Application.Restart();
            }
            catch (Exception hata)
            {
                splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show(hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void simpleButtonTestEt_Click(object sender, EventArgs e)
        {
            BaglantiTestEt();
        }
        private void VeritabaniListele()
        {
            // SQL Server bağlantı bilgileri
            string serverName = textEditServerName.Text;
            string userName = textEditUserName.Text;
            string password = textEditPass.Text;
            string connectionString;

            if (lookUpEditAuth.Text == "Windows Authentication")
            {
                connectionString = $"Server={serverName};Integrated Security=True;";
            }
            else
            {
                connectionString = $"Server={serverName};User ID={userName};Password={password};";
            }

            // SQL Server bağlantı dizesi

            List<string> databases = new List<string>();
            // SQL sorgusu
            string query = "SELECT name FROM sys.databases";

            try
            {
                // SQL Server'a bağlanma
                using SqlConnection connection = new(connectionString);
                connection.Open();


                // SQL komutunu çalıştırma
                using SqlCommand? command = new(query, connection);
                using SqlDataReader? reader = command.ExecuteReader();


                // Veritabanı isimlerini okuma ve ekrana yazdırma
                while (reader.Read())
                {
                    databases?.Add(reader["name"]?.ToString());
                }

                lookUpEditDatabase.Properties.DataSource = databases;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
        }

        private void textEditPass_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEditPass_Leave(object sender, EventArgs e)
        {
            VeritabaniListele();
        }

        private void lookUpEditAuth_EditValueChanged(object sender, EventArgs e)
        {
            if(lookUpEditAuth.Text == "Windows Authentication")
            {
                textEditPass.Enabled = false;
                textEditUserName.Enabled = false;
            }
            else
            {
                textEditPass.Enabled = true;
                textEditUserName.Enabled = true;
            }
        }
    }
}