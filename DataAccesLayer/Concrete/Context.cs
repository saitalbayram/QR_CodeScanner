using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using CoreLayer.Concrete;
using CoreLayer.Configurations;


namespace DataAccesLayer.Concrete
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            RegistrySettings settings = RegistryHelper.RegisterKayitOku();



            if (settings.Authentication == "Windows Authentication")
            {
                optionsBuilder.UseSqlServer(
                    $"Data Source={settings.ServerName};Initial Catalog={settings.Database};Integrated Security=True;;", options =>
                    options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(10),
                    errorNumbersToAdd: null));
            }
            else
            {
                optionsBuilder.UseSqlServer(
                    $"Data Source={settings.ServerName};Initial Catalog={settings.Database};User Id={settings.UserName};Password={settings.Pass};Encrypt=False;", options =>
                    options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(10),
                    errorNumbersToAdd: null));
            }
        }

        public DbSet<PosetPaket>? PosetPakets {  get; set; }
        public DbSet<AppUser>? Users { get; set; }
        public DbSet<Files>? Files { get; set; }
    }
}
