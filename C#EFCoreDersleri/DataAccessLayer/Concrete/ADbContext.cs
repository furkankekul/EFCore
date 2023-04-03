using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class ADbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=adb;Uid=root;Pwd=2909;", ServerVersion.AutoDetect("Server=localhost;Database=adb;Uid=root;Pwd=2909;"), p => p.CommandTimeout(600));
        }
    }
}
