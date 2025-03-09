using CodeFirstBasic.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base (options)
        {            
        }
        //DbSetleri buraya yazıyoruz. Bu DbSetler sayesinde veritabanımızda tablolar oluşuyor.
        public DbSet<GameEntity> Games => Set<GameEntity>();
        public DbSet<MovieEntity> Movies => Set<MovieEntity>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // GameEntity için Rating özelliğinin hassasiyetini ve ölçeğini belirle
            modelBuilder.Entity<GameEntity>()
                .Property(g => g.Rating)
                .HasPrecision(18, 2); // Örneğin, 18 basamak ve 2 ondalık basamak

            // MovieEntity için herhangi bir özel konfigürasyon yapılabilir
            modelBuilder.Entity<MovieEntity>()
                .Property(m => m.Title)
                .HasMaxLength(100); // Örneğin, Title için maksimum uzunluk belirleme
        }
    }
}
