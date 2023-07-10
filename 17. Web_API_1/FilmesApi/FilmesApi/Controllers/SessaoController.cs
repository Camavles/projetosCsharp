using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Data;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public SessaoController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        [HttpPost]

        public IActionResult AdicionarSessao([FromBody] CreateSessaoDto sessaoDto)
        {
            // transforma o que eu passei no parametro() no type que está em <T>
            Sessao sessao = _mapper.Map<Sessao>(sessaoDto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RecuperaSessaoPorId), new { filmeId = sessao.FilmeId, cinemaId = sessao.CinemaId }, sessao);
        }


        [HttpGet]

        public IEnumerable<ReadSessaoDto> RecuperaSessoes()
        {
            return _mapper.Map<List<ReadSessaoDto>>(_context.Sessoes.ToList());
        }


        [HttpGet("{filmeId}/{cinemaId}")]

        public IActionResult RecuperaSessaoPorId(int filmeId, int cinemaId)
        {
            var sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.FilmeId == filmeId && sessao.CinemaId == cinemaId);
            if (sessao == null) return NotFound();

            ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);

            return Ok(sessaoDto);
        }


        //[HttpPut("{id}")]

        //public IActionResult AtualizarFilmePorid([FromBody] UpdateCinemaDto sessaoDto, int id)
        //{
        //    var cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
        //    if (cinema == null) return NotFound();

        //    _mapper.Map(cinemaDto, cinema);
        //    _context.SaveChanges();

        //    return NoContent();

        //}

        //[HttpDelete("{id}")]

        //public IActionResult DeletarSessaoPorId(int id)
        //{
        //    var sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);
        //    if (sessao == null) return NotFound();

        //    _context.Sessoes.Remove(sessao);
        //    _context.SaveChanges();

        //    return NoContent();

        //}
    }
}
