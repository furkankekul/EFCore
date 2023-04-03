using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}
#region Default Convention
//İki entity arasındaki ilişkiyi navigation propertyler üzerinden çoğul olarak kullanmalıyız(ICollection,List gibi)
//Default Convention da cross table'ı manuel oluşturmak zorunda değiliz
//EFCore tasarıma uygun bir şekilde cross tabel'ı kendisi otomatik basacak ve generate edecektir.
//Ve oluşturulan cross table'ın içerisinde composite primary key'i de otomatik oluşturmuş olacaktır

//public class Kitap
//{
//    public int Kitapid { get; set; }
//    public string KitapAdi { get; set; }
//    public ICollection<Yazar> Yazarlar { get; set; }

//}

//public class Yazar
//{
//    public int Yazarid { get; set; }
//    public string YazarAdi { get; set; }
//    public string YazarSoyadi { get; set; }
//    public ICollection<Kitap> Kitaplar { get; set; }


//}
#endregion

#region Data Annotations
//Cross tabel manuel olarak oluşturulmak zorundadır.
//Entityler de oluşturduğumuz cross table entity'si ile bire çok ilişkisi kurulmalıdır.


#endregion

#region Fluent API
public class Kitap
{
    public int Kitapid { get; set; }
    public string KitapAdi { get; set; }


}

public class Yazar
{
    public int Yazarid { get; set; }
    public string YazarAdi { get; set; }
    public string YazarSoyadi { get; set; }

}
#endregion





public class ESirketDbContext : DbContext
{
    public DbSet<Kitap> Kitaplar { get; set; }
    public DbSet<Yazar> Yazarlar    { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=localhost;Database=EKitapDb;Uid=root;Pwd=2909;", ServerVersion.AutoDetect("Server=localhost;Database=EKitapDb;Uid=root;Pwd=2909;"), p => p.CommandTimeout(600));
    }
}
