using EFCoreVeriKalıcılığı2.DataAccessLayer;
using EFCoreVeriKalıcılığı2.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        ETicaretDbContext3 context = new();
        #region VeriEklemeHatırlatması
        //Customer customer1 = new()
        //{
        //    Name="Ahmet",
        //    LastName="Kekül"
        //};
        //Customer customer2 = new()
        //{
        //    Name = "Reyhan",
        //    LastName = "Kekül"
        //};
        //Customer customer3 = new()
        //{
        //    Name = "Alperen",
        //    LastName = "Kekül"
        //};
        //Customer customer4 = new()
        //{
        //    Name = "Furkan",
        //    LastName = "Kekül"
        //};

        //context.Customers.AddRange(customer1,customer2,customer3,customer4);
        //context.SaveChanges();
        #endregion
        #region ChangeTracker Mekanizması ile Tabloda ki veriyi güncelleme(Takibi olan verilerin güncellenmesi)
        //Customer customer =  context.Customers.FirstOrDefault(c => c.CustomerId==2);
        //customer.Name = "Araf";
        //customer.LastName = "Kekül";
        //context.SaveChanges();
        #endregion
        #region Takibi olmayan verilerin güncellenmesi (Update fonksyionu)

        Customer customer1 = new()
        {
            CustomerId= 3,
            Name="gego",
            LastName="Kekül"
        };

        context.Customers.Update(customer1);
        context.SaveChanges();  

        #endregion











    }
}