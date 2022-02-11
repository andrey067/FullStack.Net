using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;
using ProEventos.Persistence.Seeds;

namespace ProEventos.Persistence.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<Palestrante_Evento> PalestranteEvento { get; set; }
        public DbSet<RedeSocial> RedeSociais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Palestrante_Evento>().HasKey(PE => new { PE.EventoId, PE.PalestranteId });
            modelBuilder.Entity<Evento>().HasMany(e => e.RedeSociais).WithOne(rs => rs.Evento).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Palestrante>().HasMany(e => e.RedeSociais).WithOne(rs => rs.Palestrante).OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);


            EventoSeeds.Eventos(modelBuilder);
        }
    }
}