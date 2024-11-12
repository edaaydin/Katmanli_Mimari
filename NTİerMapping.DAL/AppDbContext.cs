using Microsoft.EntityFrameworkCore;
using NTierMapping.DATA;
using NTİerMapping.DAL.Mappings;

namespace NTİerMapping.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<FilmKategori> FilmKategorileri { get; set; }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<FilmDetay> FilmDetaylari { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database =NTierDb; Trusted_Connection = True; MultipleActiveResultSets = true; TrustServerCertificate = True;");
        }

        // FluentAPI
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new FilmKategoriMapping().Configure(modelBuilder.Entity<FilmKategori>());

            new FilmMapping().Configure(modelBuilder.Entity<Film>());

            new FilmDetayMapping().Configure(modelBuilder.Entity<FilmDetay>());

            new OyuncuMapping().Configure(modelBuilder.Entity<Oyuncu>());
        }
    }
}
