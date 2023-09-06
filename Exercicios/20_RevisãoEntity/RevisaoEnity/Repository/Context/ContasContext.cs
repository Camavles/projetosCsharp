using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RevisaoEnity.Entities;

namespace Repository.Context
{
    public class ContasContext : DbContext
    {


        public ContasContext(DbContextOptions<ContasContext> opts) : base(opts) 
        {
            
        }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<ContasClientes>()
                .HasKey(p => new { p.ClienteId, p.ContaId });

            base.OnModelCreating(modelBuilder);
        }

    }
}