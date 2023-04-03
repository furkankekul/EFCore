using EFCoreVeriKalıcılığı3.DataAccessLayer;
using EFCoreVeriKalıcılığı3.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        ETicaretDbContext4 context = new();
        #region Veri Ekleme Hatırlatma
        //Customer customer1 = new()
        //{
        //    FirstName = "Ahmet",
        //    LastName = "Kekül"
        //};
        //Customer customer2 = new()
        //{
        //    FirstName = "Reyhan",
        //    LastName = "Kekül"
        //};
        //Customer customer3 = new()
        //{
        //    FirstName = "Alperen",
        //    LastName = "Kekül"
        //};
        //Customer customer4 = new()
        //{
        //    FirstName = "Furkan",
        //    LastName = "Kekül"
        //};

        //context.Customers.AddRange(customer1, customer2, customer3, customer4);
        //context.SaveChanges();
        #endregion
        #region Veri Silme 
        //Customer customer = context.Customers.FirstOrDefault(c => c.CustomerId==4);  //bir veriyi silebilmek için önce veritabanından çekmek lazım 
        //context.Customers.Remove(customer);
        //context.SaveChanges();
        #endregion
        #region TakipEdilmeyen veriyi silme
        //Customer customer = new()
        //{
        //    CustomerId = 1,

        //};
        //context.Customers.Remove(customer);
        //context.SaveChanges();


        #endregion
        #region RemoveRange Fonksiyonu
        Customer customer = new()
        {
            CustomerId = 2
        };
        Customer customer1= new()
        {
            CustomerId =3
        };
        context.Customers.RemoveRange(customer,customer1);
        context.SaveChanges(); 
        #endregion
    }
}