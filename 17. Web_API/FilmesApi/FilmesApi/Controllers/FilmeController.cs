using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

// anotações para alterar esse arquivo para uma controller;
// para bater na minha rota, eu passo o nome controller dentro dos colchetes
[ApiController]
[Route("[controller]")]

public class FilmeController : ControllerBase
{
    // retirei essa parte para que seja o context que acesso o banco de dados e faça o retorno da requisição;
    //private static List<Filme> filmes = new List<Filme>();
    //private static int id = 0;

    private FilmeContext _context;
    private IMapper _mapper;


    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    /// <summary>
    /// Adiciona um filme ao banco de dados
    /// </summary>
    /// <param name="filmeDto">Objeto com os campos necessários para criação de um filme</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)] // dataAnnotation para mostrar que tipo de resposta trás
    public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
    {
        // validando parâmetros;

        //filme.Id = id++;
        //filmes.Add(filme);

        Filme filme = _mapper.Map<Filme>(filmeDto);
        _context.Filmes.Add(filme);
        _context.SaveChanges();

        return CreatedAtAction(nameof(RecuperaFilme), new { id = filme.Id }, filme);


    }




    [HttpGet]
    public IEnumerable<ReadFilmeDto> RecuperaFilme([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {

        //return _context.Filmes.Skip(skip).Take(take);
        //troquei o IEnumerable<filme> para <ReadFilmeDto>

        return _mapper.Map<List<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take));
    }




    [HttpGet("{id}")]
    // interrogação no final: filme pode ser ou não nulo;
    // Filme? --> pode ser nulo ou não;
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();

        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);  // linha nova 
        return Ok(filmeDto); // antes era : return  Ok(filme);

    }

    [HttpPut("{id}")]
    public IActionResult AtualizarFilme(int id, [FromBody]UpdateFilmeDto filmeDto) 
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();
        return NoContent();
    }


    [HttpPatch("{id}")]

    public IActionResult AtualizarFilmeParcial(int id, JsonPatchDocument<UpdateFilmeDto> patch)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();

        // conversão do UpdatefilmeDto para o filme recuperado
        var filmeParaAtualizar = _mapper.Map<UpdateFilmeDto>(filme);

        // se a mudança for válida e o modelo de estado for válido(model state)
        patch.ApplyTo(filmeParaAtualizar, ModelState);

        if (!TryValidateModel(filmeParaAtualizar))
        {
            return ValidationProblem(ModelState);
        }

        _mapper.Map(filmeParaAtualizar, filme);
        _context.SaveChanges();
        return NoContent();
    }


    [HttpDelete("{id}")]

    public IActionResult DeletarFilme(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();

        _context.Remove(filme); // vou no meu banco de dados e faço a remoção;
        _context.SaveChanges();

        return NoContent();
    }
}
