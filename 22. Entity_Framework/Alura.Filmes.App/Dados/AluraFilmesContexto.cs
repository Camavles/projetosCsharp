using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;


namespace Alura.Filmes.App.Dados
{
    public class AluraFilmesContexto : DbContext
    {

        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=AluraFilmes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");

            //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=AluraFilmesTST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;");
        }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtorConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeCategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new IdiomaConfiguration());

            
        }


        public static void Comentarios()
        {
            // Jeito antigo de fazer
            // isolando a configuração 


            //protected override void OnModelCreating(ModelBuilder modelBuilder)
            // {
            //modelBuilder.Entity<Ator>()
            //    .ToTable("actor");

            //modelBuilder.Entity<Ator>()
            //    .Property(a => a.Id)
            //    .HasColumnName("actor_Id");

            //modelBuilder.Entity<Ator>()
            //    .Property(a => a.PrimeiroNome)
            //    .HasColumnName("first_name")
            //    .HasColumnType("varchar(45)")
            //    .IsRequired();

            //modelBuilder.Entity<Ator>()
            //    .Property(a => a.UltimoNome)
            //    .HasColumnName("last_name")
            //    .HasColumnType("varchar(45)")
            //    .IsRequired();

            //// como essa prop não existe na camada de negócio, aliás, na minha classe, eu preciso passar o tipo dessa propriedade que é DateTime;
            //modelBuilder.Entity<Ator>()
            //    .Property<DateTime>("last_update")
            //    .HasColumnType("datetime")
            //    .HasDefaultValueSql("getdate()"); // com esse código, o SQL consegue pegar o datetime no momento da inclusão;


            //modelBuilder.Entity<Filme>()
            //    .ToTable("film");

            //modelBuilder.Entity<Filme>()
            //    .Property(b => b.Id)
            //    .HasColumnName("film_id");

            //modelBuilder.Entity<Filme>()
            //    .Property(b => b.Titulo)
            //    .HasColumnName("title")
            //    .HasColumnType("varchar(255)")
            //    .IsRequired();

            //modelBuilder.Entity<Filme>()
            //    .Property(b => b.Descricao)
            //    .HasColumnName("description")
            //    .HasColumnType("text");

            //modelBuilder.Entity<Filme>()
            //    .Property(b => b.AnoDeLancamento)
            //    .HasColumnName("release_year")
            //    .HasColumnType("varchar(4)");

            //modelBuilder.Entity<Filme>()
            //    .Property(b => b.Duracao)
            //    .HasColumnName("length");
            ////.HasColumnType("smallint");

            //modelBuilder.Entity<Filme>()
            //    .Property(b => b.Avaliacao)
            //    .HasColumnName("rating")
            //    .HasColumnType("varchar(10)");

            //modelBuilder.Entity<Filme>()
            //    .Property<DateTime>("last_update")
            //    .HasColumnType("datetime")
            //    .HasDefaultValueSql("getdate()");

            //}
        }
    }
    



}
