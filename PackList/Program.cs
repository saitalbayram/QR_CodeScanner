﻿using CoreLayer.Concrete;
using CoreLayer.Configurations;
using OnMuhasebe.Settings;
using QR_CodeScanner.Main;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_CodeScanner
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("tr-TR");

            RegistrySettings registrySettings = RegistryHelper.RegisterKayitOku();
            if (registrySettings != null ) 
                Application.Run(new LoginForm());
            else
                Application.Run(new FrmDatabaseSettings());
        }
    }
}
