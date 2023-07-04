using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Dtos
{
    public class ReadFilmeDto
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }

        // valor padrão da hr da consulta;
        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;

    }
}
