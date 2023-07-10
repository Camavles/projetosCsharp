using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data;

// essa classe é um contexto de banco de dados;
public class FilmeContext : DbContext
{
    // opções de acesso ao nosso banco
    public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
    {
        
    }
    //construindo a relação n:n do filme, sessao, cinema.

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // a entidade sessao vai ter como chave a sessao.FilmeId e sessao.CinemaId 
        builder.Entity<Sessao>().HasKey(sessao => new { sessao.FilmeId, sessao.CinemaId });

        // uma sessao vai ter um cinema, esse cinema tem uma ou mais sessoes
        // e para cada sessao eu tenho um CinemaId.
        builder.Entity<Sessao>().HasOne(sessao => sessao.Cinema).WithMany(cinema => cinema.Sessoes).HasForeignKey(sessao => sessao.CinemaId);

        builder.Entity<Sessao>().HasOne(sessao => sessao.Filme).WithMany(filme => filme.Sessoes).HasForeignKey(sessao => sessao.FilmeId);

    }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Sessao> Sessoes { get; set; }


}
