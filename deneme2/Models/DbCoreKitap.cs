using Microsoft.EntityFrameworkCore;

namespace deneme2.Models
{
    public class DbCoreKitap : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=DbCoreKitap1; integrated security=true; TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kitap_Yazar>().HasKey(ky => new
            {
                ky.KitapId,
                ky.YazarId
            });
            modelBuilder.Entity<Kitap_Yazar>().HasOne(k=> k.Kitap).WithMany(ky=>ky.Kitap_Yazarlar).HasForeignKey(k=>k.KitapId);
            modelBuilder.Entity<Kitap_Yazar>().HasOne(k=> k.Yazar).WithMany(ky=>ky.Kitap_Yazarlar).HasForeignKey(k=>k.YazarId);

            modelBuilder.Entity<Kitap_Tercuman>().HasKey(kt => new
            {
                kt.KitapId,
                kt.TercumanId
            });
            modelBuilder.Entity<Kitap_Tercuman>().HasOne(k => k.Kitap).WithMany(ky => ky.Kitap_Tercumanlar).HasForeignKey(k => k.KitapId);
            modelBuilder.Entity<Kitap_Tercuman>().HasOne(k => k.Tercuman).WithMany(ky => ky.Kitap_Tercumanlar).HasForeignKey(k => k.TercumanId);

        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<Tercuman> Tercumanlar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Kitap_Tercuman> Kitap_Tercumanlar { get; set; }
        public DbSet<Kitap_Yazar> Kitap_Yazarlar { get; set; }
    }
}
