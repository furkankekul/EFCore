using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ETicaretDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=ETicaretdb4;Uid=root;Pwd=2909;", ServerVersion.AutoDetect("Server=localhost;Database=ETicaret2;Uid=root;Pwd=2909;"), p => p.CommandTimeout(600));
        }

    }
}
