using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Sessao
    {
        //[Key]
        //[Required]
        //public int Id { get; set; }

        // aqui o que eu estou dizendo é que para que uma sessao exista, um filme precisa existir no nosso banco de dados; 
  
        public int? FilmeId { get; set; }
        public virtual Filme  Filme { get; set; }
        
        // tipos por valor, com esse ? eu permito que sejam nulos;
        public int? CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
