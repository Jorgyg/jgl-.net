using Microsoft.EntityFrameworkCore;

namespace Ex4.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }

        public DbSet<Sala> Salas { get; set; }

        public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sala>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("Sala");

                entity.Property(e => e.Codigo)
                    .IsRequired();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PeliculaCodigo)
                   .IsRequired();

                entity.HasOne(e => e.Pelicula)
                    .WithMany(e => e.Sala)
                    .HasForeignKey(e => e.PeliculaCodigo);
            });

            modelBuilder.Entity<Pelicula>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("Pelicula");

                entity.Property(e => e.Codigo)
                    .IsRequired();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(e => e.Edad);

            });

        }
    }
}
