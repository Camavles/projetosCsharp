using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Key] // informa para o banco que é uma chave;
    [Required]
    public int Id { get; set; } // não precisa q o user envie o id;

    [Required(ErrorMessage = "O título do filme é obrigatório")] // DataAnnotations;
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatória")]
    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }

    // essa colection diz que me relaciono com mais de uma sessao;
    public virtual ICollection<Sessao> Sessoes { get; set; }

}
