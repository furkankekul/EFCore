internal class Program
{
    private static void Main(string[] args)
    {
       
    }
}

#region ETicaretDbContext sınıfını oluştururken neler yaptık
//ETicaretDbContext sınıfını oluşturduk ve bu oluşan sınıfın DbContext sınıfından türemesini sağladık 
//Daha sonra context sınıfından override olan OnConfiguring() metotunun oluşturduk
//ETicaretDbContext sınıfı veritabanına karşılık gelen sınıftır
//ETicaretDbContext sınıfı içerisindeki Dbset propertyleri ise veritabanında oluşturulan tablolara karşılık gelir

#endregion
#region OnConfiguring() Ne işe yarar
//Bu metot EF Core tool'unu yapılandırdığımız bir metottur
//Context nesnesinden override edilerek kullanılır.
//Bu metot provider yapılandırmasına yardımcı olur.(kullandığınız veritabanının providerını yükleyerek bu işlemi yapabilirsiniz.)
//Bu metot connection string yapılandırmasına yardımcı olur.
//bu metot içerisinde kullandığımız optionBuilders.Use..(conn string(syntax)) metotu ile kullanacağın veritabanına göre uygun bir şekilde çalışacağını bu metotla yapılandırmış oluyoruz.
//**İstediğimiz hedef veritabanına bağlanmak için yapılandırma yapan bir metotur
//***Yani bu fonksiyonu gördüğün yerlerde bir yapılandırmanın peşindeti
#endregion
#region Customer,Product sınıfını oluştururken neler yaptık 
//Musteri sınıfı veritabanında tabloya denk gelen entity olarak isimlendirdiğimiz tablo sınıfıdır
//içerisindeki propertyler ise tablodaki sütünlara karşılık gelmektedir.
#endregion
#region Veri Nasıl Eklenir
//Verisel bütün işlemleri yapabilmemiz için Oluşturduğumuz DbContext sınıfından bir tane nesneye ihtiyacımız var.
#endregion
#region context.Database.Migrate()
//Bu metot oluşturulan migration'ı ilgili veritabanına gönderen işlemdir.
#endregion














