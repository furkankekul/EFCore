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
//Default Convetion yönteminde bire çok ilişkiyi kurarken ForeignKey kolonuna karşılık gelen
//bir property tanımlamak mecburiyetinde değiliz.Eğer tanımlamazsak EFCore bunu kendisi
//tamamlayacak,eğer tanımlasak tanımladığımız baz alarak işlem yapacaktır.
//public class Calisan
//{

//    public int id { get; set; }
//    public string Adi { get; set; }
//    public Departman Departman { get; set; }

//}

//public class Departman
//{

//    public int id { get; set; }
//    public string DepartmanAdi { get; set; }
//    public ICollection<Calisan> Calisanlar { get; set; }
//}



#endregion

#region Data Annotations
//Default convention yönteminde foreignKey kolonuna karşılık gelen property'i
//tanımladığımızda bu property temel entity tanımlama kurallarına uymuyora,
//Data Annotations'lar ile müdahale de bulunabiliriz.
//Aşağıdaki örnekte yukarıdaki açıklamaya uygun bir hamle yapmadık entityframework'un
//sağladığı nimetlerden yararlandık ama sen data annotations'ın ne olduğunu yava yavaş                                          
//analamya başladın

//public class Calisan
//{
//    public int Calisanid { get; set; }
//    public string CalisanAdi{ get; set; }
//    public Departman Departman { get; set; }
//}
                                                                                
//public class Departman
//{
//    public int DepartmanId { get; set; }
//    public string DepartmanAdi { get; set; }
//    public ICollection<Calisan> Calisanlar { get; set; }
//}



#endregion



public class ESirketDbContext : DbContext
{ 
    public DbSet<Calisan> Calisanlar { get; set; }
    public DbSet<Departman> Departmanlar { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=localhost;Database=ESirketDb;Uid=root;Pwd=2909;", ServerVersion.AutoDetect("Server=localhost;Database=ESirketDb;Uid=root;Pwd=2909;"), p => p.CommandTimeout(600));
    }
}


