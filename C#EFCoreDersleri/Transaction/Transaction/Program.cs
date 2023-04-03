using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
Console.WriteLine();

#region TransactionNedir
//Transaction,veritabanındaki kümülatif işlemleri atomik bir şekilde gerçekleştirmemizi sağlayan bir özelliktir.
//Bir transaction içerisindeki tüm işlemler veri tabanına commit edildiği taktirde veritabanına fiziksel olarak yansıtılacaktır
//Bir transaction rollback edilirse tüm işlemler geri alınack ve fiziksel olarak veri tabanında herhangi bir verisel değişiklik olamyacktır 
//Transaction'ın genel amacı veri tabanındaki tutarlılık durumunu korumaktır.
#endregion
#region Default Transaction Daranışı
//ef core'da varsayılan olarak yapılan işlemler SaveChanges fonksiyonuyla veri tabanına fiziksel olarak uygulanır.
//SaveChanges Metotu default bir transaction'a sahiptir.
//Bu süreçte  bir problem söz konuusu olursa tğm işlemler geri alınır.Veri tabanına fiziksel olarak herangi bir uygulama olmaz.
#endregion
#region Transaction Kontrolünü Manuel Olarak Sağlama   
ADbContext context= new ADbContext();  
IDbContextTransaction transaction = context.Database.BeginTransaction();
//EfCore transaction kotrolu manuel olarak BeginTransaction fonksiyonu çağırılmalıdır.Bu işlemi yaptıktan sonra SaveChages metodu içerisindeki default trasatio metotu ezilecektir
//ve mauel olarak transaction mekanizmasını biz commit metotu ile işlem yapmadığımız sürece veri tabanın da fiziksel olara bir değişiklik olmayacaktır.
Person p = new Person()
{
    name = "lsdfjkkodl"
};
context.Persons.Add(p);
context.SaveChanges();
transaction.Commit();



#endregion







public class Person
{
    public int personId{ get; set; }
    public string name { get; set; }

    public ICollection<Order> Orders { get; set; }
}

public class Order
{
    public int orderId { get; set; }
    public string Name { get; set; }
    public Person Person { get; set; }
}


public class ADbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=localhost;Database=ADb;Uid=root;Pwd=2909;", ServerVersion.AutoDetect("Server=localhost;Database=ADb;Uid=root;Pwd=2909;"), p => p.CommandTimeout(600));
    }
}