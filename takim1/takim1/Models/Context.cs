using Microsoft.EntityFrameworkCore;

namespace takim1.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=DbCoreFutbol;integrated security=true; TrustServerCertificate=True");
        }
        public DbSet<Takim> Takimlar { get; set; }
        public DbSet<Futbolcu> Futbolcular { get; set; }
        public DbSet<TeknikDirektor> TeknikDirektorler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }


    }
}
