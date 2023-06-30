using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Dtos;
using FilmesApi.Models;
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




    [HttpPost]
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
    public IEnumerable<Filme> RecuperaFilme([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {

        return _context.Filmes.Skip(skip).Take(take);
    }




    [HttpGet("{id}")]
    // interrogação no final: filme pode ser ou não nulo;
    // Filme? --> pode ser nulo ou não;
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);

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



}
