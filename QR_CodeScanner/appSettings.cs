using DevExpress.XtraCharts.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Concrete;
using CoreLayer.Configurations;
using DevExpress.Utils.Registrator;

namespace QR_CodeScanner
{
    public class appSettings
    {
        public static string ShowInputBox(string uyariMetni, string  baslik, string defaultValue)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(uyariMetni, baslik, defaultValue);
        }

        static DevExpress.DataAccess.Sql.SqlDataSource _defaultDataSource;
        public static DevExpress.DataAccess.Sql.SqlDataSource defaultDataSource
        {
            get
            {
                if (_defaultDataSource == null)
                {
                    RegistrySettings registrySettings = RegistryHelper.RegisterKayitOku();

                    DevExpress.DataAccess.Sql.SqlDataSource dsource = new DevExpress.DataAccess.Sql.SqlDataSource();
                    dsource.ConnectionName = "QRCodeScanner.ConnectionString";
                    dsource.ConnectionParameters = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(registrySettings.ServerName, registrySettings.Database, registrySettings.UserName, registrySettings.Pass, (registrySettings.UserName + "" == "") ? DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows : DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
                    
                    _defaultDataSource = dsource;
                }
                return _defaultDataSource;
            }
        }
    }
}
