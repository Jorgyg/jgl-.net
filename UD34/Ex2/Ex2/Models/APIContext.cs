﻿using Microsoft.EntityFrameworkCore;

namespace Ex2.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options) { }
        public DbSet<Proyecto> Proyectos { get; set; } = null;
        public DbSet<Cientifico> Cientificos { get; set; } = null;
        public DbSet<Asignado> Asignados { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cientifico>()
                .HasKey(e => new { e.Dni });

            modelBuilder.Entity<Proyecto>()
                .HasKey(e => new { e.Id });

            modelBuilder.Entity<Asignado>()
                .HasKey(e => new { e.CientificoDni, e.ProyectoId });
            modelBuilder.Entity<Asignado>()
                .HasOne(e => e.Proyecto)
                .WithMany(e => e.Asignados)
                .HasForeignKey(e => e.ProyectoId);
            modelBuilder.Entity<Asignado>()
                .HasOne(e => e.Cientifico)
                .WithMany(e => e.Asignados)
                .HasForeignKey(e => e.CientificoDni);
        }
    }
}
