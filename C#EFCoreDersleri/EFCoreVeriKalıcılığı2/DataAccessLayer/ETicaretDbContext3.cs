using EFCoreVeriKalıcılığı2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreVeriKalıcılığı2.DataAccessLayer
{
    internal class ETicaretDbContext3:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=ETicaretdb3;Uid=root;Pwd=2909;", ServerVersion.AutoDetect("Server=localhost;Database=ETicaret2;Uid=root;Pwd=2909;"), p => p.CommandTimeout(600));
        }






    }
}
