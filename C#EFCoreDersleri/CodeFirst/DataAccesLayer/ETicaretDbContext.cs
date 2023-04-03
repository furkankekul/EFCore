using CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DataAccesLayer
{
    public class ETicaretDbContext:DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=EticaretDb;Uid=root;Pwd=2909", ServerVersion.AutoDetect("Server=localhost;Database=EticaretDb;Uid=root;Pwd=2909"), p => p.CommandTimeout(600));
        }






    }
    //Tüm açıklamalar program.s de 
}
