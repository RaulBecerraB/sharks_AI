using Microsoft.EntityFrameworkCore;
using sharks.Models;

namespace sharks.Data
{
    public class SharksDbContext : DbContext
    {
        public SharksDbContext(DbContextOptions<SharksDbContext> options) : base(options)
        {
        }

        public DbSet<SharkSpecies> SharkSpecies { get; set; }
        public DbSet<Shark> Sharks { get; set; }
        public DbSet<SharkTracking> SharkTrackings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de las entidades
            modelBuilder.Entity<SharkSpecies>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.ScientificName).HasMaxLength(200);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.Habitat).HasMaxLength(300);
                entity.Property(e => e.DangerLevel).HasMaxLength(20);
                entity.Property(e => e.ConservationStatus).HasMaxLength(50);
            });

            modelBuilder.Entity<Shark>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.TagId).HasMaxLength(20);
                entity.Property(e => e.Gender).HasMaxLength(20);
                entity.Property(e => e.TaggedLocation).HasMaxLength(200);
                entity.Property(e => e.Notes).HasMaxLength(500);

                // Relación con SharkSpecies
                entity.HasOne(e => e.Species)
                      .WithMany(s => s.Sharks)
                      .HasForeignKey(e => e.SharkSpeciesId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SharkTracking>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Latitude).HasColumnType("decimal(10,8)");
                entity.Property(e => e.Longitude).HasColumnType("decimal(11,8)");
                entity.Property(e => e.Notes).HasMaxLength(200);
                entity.Property(e => e.SignalStrength).HasMaxLength(10);

                // Relación con Shark
                entity.HasOne(e => e.Shark)
                      .WithMany(s => s.TrackingData)
                      .HasForeignKey(e => e.SharkId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Datos semilla para especies de tiburones
            modelBuilder.Entity<SharkSpecies>().HasData(
                new SharkSpecies
                {
                    Id = 1,
                    Name = "Gran Tiburón Blanco",
                    ScientificName = "Carcharodon carcharias",
                    Description = "El gran tiburón blanco es una especie de elasmobranquio lamniforme de la familia Lamnidae que se encuentra en las aguas costeras de todos los océanos.",
                    AverageLength = 4.5,
                    AverageWeight = 1200,
                    Habitat = "Aguas costeras templadas y subtropicales",
                    DangerLevel = "High",
                    ConservationStatus = "Vulnerable"
                },
                new SharkSpecies
                {
                    Id = 2,
                    Name = "Tiburón Tigre",
                    ScientificName = "Galeocerdo cuvier",
                    Description = "El tiburón tigre es una especie de elasmobranquio carcarriniforme conocido por sus distintivas rayas oscuras.",
                    AverageLength = 3.5,
                    AverageWeight = 400,
                    Habitat = "Aguas tropicales y subtropicales",
                    DangerLevel = "High",
                    ConservationStatus = "Near Threatened"
                },
                new SharkSpecies
                {
                    Id = 3,
                    Name = "Tiburón Limón",
                    ScientificName = "Negaprion brevirostris",
                    Description = "El tiburón limón es una especie de tiburón requiem de color amarillento que habita en aguas poco profundas.",
                    AverageLength = 2.5,
                    AverageWeight = 90,
                    Habitat = "Aguas costeras poco profundas tropicales",
                    DangerLevel = "Medium",
                    ConservationStatus = "Vulnerable"
                },
                new SharkSpecies
                {
                    Id = 4,
                    Name = "Tiburón Martillo",
                    ScientificName = "Sphyrna mokarran",
                    Description = "El tiburón martillo gigante es la especie más grande de tiburón martillo, conocido por su cabeza distintiva en forma de martillo.",
                    AverageLength = 4.0,
                    AverageWeight = 230,
                    Habitat = "Aguas costeras tropicales y subtropicales",
                    DangerLevel = "Medium",
                    ConservationStatus = "Critically Endangered"
                },
                new SharkSpecies
                {
                    Id = 5,
                    Name = "Tiburón Toro",
                    ScientificName = "Carcharhinus leucas",
                    Description = "El tiburón toro es conocido por su capacidad de nadar en agua dulce y su naturaleza agresiva.",
                    AverageLength = 2.5,
                    AverageWeight = 130,
                    Habitat = "Aguas costeras, ríos y lagos",
                    DangerLevel = "High",
                    ConservationStatus = "Vulnerable"
                }
            );

            // Datos semilla para tiburones
            modelBuilder.Entity<Shark>().HasData(SharkSeedData.GetSharks().ToArray());

            // Datos semilla para tracking de tiburones
            modelBuilder.Entity<SharkTracking>().HasData(SharkSeedData.GetSharkTrackingData().ToArray());
        }
    }
}
