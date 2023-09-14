using Microsoft.EntityFrameworkCore;

namespace Ex3.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
        public DbSet<Cientifico> Cientificos { get; set; } = null;
        public DbSet<Proyecto> Proyectos { get; set; } = null;
        public DbSet<CientificoProyecto> CientificoProyectos { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CientificoProyecto>()
                .HasKey(cp => new { cp.CientificoDni, cp.ProyectoId });
            modelBuilder.Entity<CientificoProyecto>()
                .HasOne(cp => cp.Cientifico)
                .WithMany(c => c.CientificoProyectos)
                .HasForeignKey(cp => cp.CientificoDni);
            modelBuilder.Entity<CientificoProyecto>()
                .HasOne(cp => cp.Proyecto)
                .WithMany(c => c.CientificoProyectos)
                .HasForeignKey(cp => cp.ProyectoId);
        }
    }
}
