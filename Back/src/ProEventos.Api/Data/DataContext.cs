using Microsoft.EntityFrameworkCore;
using ProEventos.Api.Data.Seeds;
using ProEventos.Api.Models;

namespace ProEventos.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Evento> Eventos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EventoSeeds.Eventos(modelBuilder);
        }
    }
}