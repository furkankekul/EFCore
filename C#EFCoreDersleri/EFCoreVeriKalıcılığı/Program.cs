using EFCoreVeriKalıcılığı.DataAccessLayer;
using EFCoreVeriKalıcılığı.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        EticaretDbContext context = new();
        Customer customer = new()
        {
            Name = "Ahmet",
            LastName = "Kekül"

        };
        Customer customer1 = new()
        {
            Name = "Alperen",
            LastName = "Kekül"

        };
        Customer customer2 = new()
        {
            Name = "Furkan",
            LastName = "Kekül"

        };


        context.Add(customer);
        Console.WriteLine(context.Entry(customer1).State);
        context.Customers.AddRange(customer1,customer2);
       Console.WriteLine(context.Entry(customer1).State);
        context.SaveChanges();
        Console.WriteLine(context.Entry(customer1).State);

       




    }
}