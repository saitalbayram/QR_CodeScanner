using CoreLayer.Concrete;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Configurations
{
    public class RegistryHelper
    {
        public RegistryHelper() 
        {

        }

        public static RegistrySettings RegisterKayitOku()
        {
            string subKey = @"SOFTWARE\QRCodeScanner";
            using RegistryKey? key = Registry.CurrentUser?.OpenSubKey(subKey);
            var settings = new RegistrySettings();
            if (key != null)
            {
                settings.ServerName = key.GetValue("Server")?.ToString();
                settings.Database = key.GetValue("Database")?.ToString();
                settings.UserName = key.GetValue("ServerUserName")?.ToString();
                settings.Pass = key.GetValue("ServerPassword")?.ToString();
                settings.Authentication = key.GetValue("ServerAuthentication")?.ToString();
                return settings;
            }
            else
                return null;
           
        }

        public static void RegisterKayitYaz(RegistrySettings settings)
        {
            // Anahtar ve değer bilgileri
            string subKey = @"SOFTWARE\QRCodeScanner";
            var keyValues = new (string keyName, string? keyValue)[]
            {
                ("Server", settings.ServerName),
                ("Database", settings.Database),
                ("ServerUserName", settings.UserName),
                ("ServerPassword", settings.Pass),
                ("ServerAuthentication", settings.Authentication),
            };

            // RegistryKey nesnesi açma
            using RegistryKey? key = Registry.CurrentUser.CreateSubKey(subKey);
            if (key != null)
            {
                foreach (var (keyName, keyValue) in keyValues)
                {
                    // Mevcut değeri kontrol et
                    object? existingValue = key.GetValue(keyName);

                    if (keyValue != null && (existingValue == null || existingValue.ToString() != keyValue))
                    {
                        // Değer yoksa veya mevcut değer farklıysa ekle/güncelle
                        key.SetValue(keyName, keyValue);
                    }
                }
            }
        }

    }
}

