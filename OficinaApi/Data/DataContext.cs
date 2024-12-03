using Microsoft.EntityFrameworkCore;
using OficinaAPI.Models;

namespace OficinaAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servico> Servicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração do relacionamento entre Cliente e Servico
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Servicos)
                .WithOne(s => s.Cliente)
                .HasForeignKey(s => s.ClienteId);
        }
    }
}
