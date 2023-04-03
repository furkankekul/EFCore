using DataAccessLayer;

internal class Program
{
    private static void Main(string[] args)
    {
        ETicaretDbContext context = new();
        #region Veri Ekleme
        //Customer customer = new()
        //{
        //    FirstName= "Furkan",
        //    LastName="Kekül"
        //};
        //Customer customer1= new()
        //{
        //    FirstName = "Alperen",
        //    LastName = "Kekül"
        //};
        //Customer customer2 = new()
        //{
        //    FirstName = "Ahmet",
        //    LastName = "Kekül"
        //};
        //Customer customer3 = new()
        //{
        //    FirstName = "Metin",
        //    LastName = "Kekül"
        //};
        //context.Customers.AddRange(customer,customer1,customer2,customer3);
        //context.SaveChanges();
        #endregion


        #region TemelVeriSorgulama
        #region MyRegion 1.VeriSorgulamaAçıklama
        //Aşağıda yazdığım sorgu temel veri sorgulama sorgusudur.
        //context.Customers'a kadar olan kısmı EFCORE select*from Customers olarak çevirir.
        //ToList() fonksiyonu sayesinde sorgu veritabanına execute edilir.
        //Yani ToList() fonksiyonunun çalışma prensibi aynı SaveChanges metodu gibidir.
        #endregion
        //var customer = context.Customers.ToList();
        #endregion


        #region IQueryable
        //Sorgunun oluşturulduğu ama execute edilmediği halini ifade eden durum, oluşturduğumuz sorgunun IQueryable durumda olduğunu ifade eder
        #endregion


        #region IEnumerable
        //IQueryable durumdaki sorgunun execute edilmesiyle/çalışmasıyla beraber verilerin in-memory'e yüklenmiş halini ifade eder.
        #endregion


        #region Çoğul Veri Getiren Sorgulama Fonksiyonları (Devam et)
        #region ToList()
        //Oluşturulmuş sorgunun execute edilmesini sağlayan fonksiyondur.
        #endregion

        #region Where komutu
        #region Where komutu açıklaması
        //where şart komutudur oluşturduğumuz sorguya şart eklememizi sağlayan fonksiyondur.
        //Aşağıda yazdığım where komutlu bir sorgu komutunun Türkçesi şöyledir;
        //context nesnesi üzerinden Customers tablosuna git ve c öyleki c.customerId<4 olan verileri getir.
        #endregion
        //var customer1 = context.Customers.Where(c => c.CustomerId <= 8).ToList();
        #endregion

        #region OrderBy
        #region Açıklama
        //Sorgu üzerinde sıralam yapmamızı sağlayan bir fonksiyondur.
        //default olarak ascending(az dan çoğa doğru) sıralama yaparak karşımıza getirir
        #endregion
        //var customer = context.Customers.OrderBy(c => c.CustomerId < 8).ToList();
        #endregion

        #region ThenBy
        #region Tanım
        //OrderBy üzerinde yapılan sıralama işlemini farklı kolonlara da uygulamamızı sağlayan bir fonksiyondur.
        #endregion
        var customer2 = context.Customers.OrderBy(c => c.CustomerId < 8).ThenBy(c => c.FirstName == "h").ToList();
        Console.WriteLine();
        #endregion

        #endregion



        #region Tekil Veri Getiren Fonksiyonlar

        #region First()

        #endregion
        #region FirstOrDefault()

        #endregion
        #region First ve FirstOrDefault Arasındaki Fark Nedir ?

        #endregion

        #region Single()

        #endregion
        #region SingleOrDefault

        #endregion
        #region Single ve SingelOrDefault Arasındaki Fark Nedir?

        #endregion

        #region Last()

        #endregion
        #region LastOrDefault

        #endregion

        #region Find()

        #endregion

        #endregion








    }
}
