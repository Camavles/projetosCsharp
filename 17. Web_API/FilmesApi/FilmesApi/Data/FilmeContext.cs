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


    public DbSet<Filme> Filmes { get; set; }
}
