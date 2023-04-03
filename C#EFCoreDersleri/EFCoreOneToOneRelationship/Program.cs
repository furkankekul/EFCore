using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        
    }
 
}
#region DefaultConventions
public class Calisan
{
    public int id { get; set; }
    public string Adi { get; set; }
    public CalisanAdresi CalisanAdresi { get; set; }
}


public class CalisanAdresi
{
    public int id { get; set; }
    public int Calisanid { get; set; }
    public string Adres { get; set; }

    public Calisan Calisan { get; set; }

}


#endregion

#region DataAnnotations
//DataAnnotations'lar da ilişkiler her iki sınıfda da navigation propertylerini tanımladıktan sonra  vereceğimiz ilişkiler attribute üzerinden olacaktır.
//ForeignKey kolonunun ismi DefaultConvension'ın dışında bir isimlendirme yapılacaksa Aşağıdaki gibi ForeignKey Attribute ile bunu bildirebiliriz.
//Böyle bir yöntem külfettir bağımlı(Dependent) entity de +1 tan kolon anlamına gelir 
//Daha pratik bir çözüm için DataAnnotations2 region'una bak ...
//public class Calisan
//{
//    public int Calisanid { get; set; }

//    public string Adi { get; set; }

//    public CalisanAdresi CalisanAdresi { get; set; }

//}

//public class CalisanAdresi
//{
//    public int id { get; set; }
//    [ForeignKey(nameof(Calisan))]
//    public int xyz { get; set; } //Bu property nin bir foreign key olduğunu  hemen üzerindeki attribute ile tanımlamış oluyoruz
//    public string Adres { get; set; }
//    public Calisan Calisan { get; set; }


//}





#endregion


#region DataAnnotations2
//1-1 ilişki olduğuna karar verdiğimiz ve bağımlı(dependetn) entity,asıl(principal)entity'leri kararlaştırdıktan sonra
//tabloların navigation property'lerini verdikten sonra,bağımlı olan sınıfa Default Convension'a göre bir foreign key kolonu eklemektense,
//Data Annotations'ın sunduğu nimetlerden faydalanarak bağımlı entityde ki id alanına (aşağıda yaptığımız şekilde) hem primary key,hem de foreign key olarak işaretleyerek
//bağımlı entity de bir külfetten kaçınmış oluruz.
//Burada ki kritik nokta şudur.Veritabanına hedef veritabanının workbenchinden manuel olarak kayıt eklerken zaten ilk olarak bağımsız tablodan veri eklemeden
//bağımlı tabloya veri eklemeye çalışırsan zaten hata fırlatacaktır.
//Bu yüzden bağımlı olmayan tabloya veri ekledikten sonra bağımlı olan tabloya veri girişi yaparken ilişkiyi verdiğin ForeignKey anahtarı 
//primaryKey anahtarı ile aynı kolon içerisinde DataAnnotation'ın getirdiği nimetlerden faydalanarak işaretlendiği için veri girdisinde bağımlı tablodaki id alanına,
//bağımlı olmayan tablodaki id değerini girme işlemi yapılamlıdır.(İlgili değerler için).
//Aşağıdaki Çalışma da yukarıda ki açıklamanın kod karşılığını inceleyebilirsin.


//public class Calisan
//{
//    public int Calisanid { get; set; }
//    public string Adi { get; set; }
//    public CalisanAdresi CalisanAdres { get; set; }

//}

//public class CalisanAdresi
//{
//    [Key,ForeignKey(nameof(Calisan))]   
//    public int id  { get; set; }
//    public string Adres { get; set; }
//    public Calisan Calisan { get; set; }
//}
#endregion










// Yukarıdaki Örnekler için DbContext sınıfı global olarak burada oluşturulmuştur.
public class ESirketDbContext : DbContext
{
    public DbSet<Calisan> Calisanlar { get; set; }
    public DbSet<CalisanAdresi> CalisanAdresler { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=localhost;Database=ESirketDb;Uid=root;Pwd=2909;", ServerVersion.AutoDetect("Server=localhost;Database=ESirketDb;Uid=root;Pwd=2909;"), p => p.CommandTimeout(600));
    }
}