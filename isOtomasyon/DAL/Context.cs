using EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Context : DbContext
    {
        public DbSet<Kullanici> kullanicilar { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
        public DbSet<Meslek> Meslekler { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=DbIsTakip;Trusted_Connection=True;");
        }


    }
}
