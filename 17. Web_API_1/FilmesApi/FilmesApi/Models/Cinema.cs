using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace FilmesApi.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        public int EnderecoId { get; set; }

        // possui um e apenas um Endereco
        public virtual Endereco Endereco { get; set; }

        public virtual ICollection <Sessao> Sessoes { get; set; }
    }
}
