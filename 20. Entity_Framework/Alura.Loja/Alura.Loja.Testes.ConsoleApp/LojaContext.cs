using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        // aqui digo quais classes serão persistidas para o db
        // essa prop "Produtos" vai representar o conjunto de objetos da classe Produto
        // nome da prop é o nome da Table no db
        // esse contexto serve para definir o db(qual db e onde fica), mas isso será feito nas configurações



        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // esse override existe para que eu consiga redefinir a chave primária/ estrageira da minha entidade;
            // é uma forma de dizer que a Key da minha tabela é composta pela Key de Promocao e a Key de Produto
            modelBuilder
                .Entity<PromocaoProduto>()
                .HasKey(p => new { p.PromocaoId, p.ProdutoId });

            // com isso, eu crio uma coluna na tabela que não está mapeada na classe
            // shadow property
            // que tem uma key que é um ClienteId, mas do tipo inteiro
            modelBuilder.Entity<Endereco>()
                .ToTable("Enderecos");
            modelBuilder
                .Entity<Endereco>()
                .Property<int>("ClienteId");
            modelBuilder.Entity<Endereco>()
                .HasKey("ClienteId");
                


            base.OnModelCreating(modelBuilder);
        }


        // config
        // evento de configuração eu defino qual banco vou usar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LojaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        }

        // essa solução é usada para quando eu quero criar o meu contexto idenpendente do banco de dados;
        // quando eu o construtor e o OnConfig, este último sobreescreve as opções de contexto;

        //public LojaContext(DbContextOptions<LojaContext> options) : base(options) 
        //{

        //}


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder
        //            .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        //    }
        //}
    }
}