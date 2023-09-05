using Microsoft.EntityFrameworkCore;

namespace Ex1.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }

        public DbSet<Fabricante> Fabricantes { get; set; }

        public DbSet<Articulo> Articulos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fabricante>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("Fabricante");

                entity.Property(e => e.Codigo)
                    .IsRequired();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("Articulo");

                entity.Property(e => e.Codigo)
                    .IsRequired();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(e => e.Precio).HasColumnType("decimal(8, 2)");


                entity.HasOne(e => e.Fabricante)
                    .WithMany(e => e.Articulos)
                    .HasForeignKey(e => e.FabricanteCodigo);
            });

        }
    }
}
