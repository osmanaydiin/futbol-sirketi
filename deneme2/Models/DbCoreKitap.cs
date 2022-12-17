using Microsoft.EntityFrameworkCore;

namespace Deneme2.Models
{
    public class DbCoreKitap : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=DbCoreKitap; integrated security=true; TrustServerCertificate=True");
            
        }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<Tercuman> Tercumanlar { get; set; }
        public DbSet<Yazar> Yzarlar { get; set; }
    }
}
