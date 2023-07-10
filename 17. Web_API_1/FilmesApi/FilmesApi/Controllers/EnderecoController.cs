using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public EnderecoController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        [HttpPost]

        public IActionResult AdicionarEndereco([FromBody] CreateEnderecoDto enderecoDto)
        {
            // transforma o que eu passei no parametro() no type que está em <T>
            Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RecuperaEnderecoPorId), new { id = endereco.Id }, endereco);
        }


        [HttpGet]

        public IEnumerable<ReadEnderecoDto> RecuperaEnderecos()
        {
            return _mapper.Map<List<ReadEnderecoDto>>(_context.Enderecos.ToList());
        }


        [HttpGet("{id}")]

        public IActionResult RecuperaEnderecoPorId(int id)
        {
            var endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null) return NotFound();

            ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);

            return Ok(enderecoDto);
        }


        [HttpPut("{id}")]

        public IActionResult AtualizarFilmePorid([FromBody] UpdateEnderecoDto enderecoDto, int id)
        {
            var endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null) return NotFound();

            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();

            return NoContent();

        }


        //[HttpPatch("{id}")]

        //public IActionResult AtualizarPorIdPatch([FromBody] JsonDocument cinemaDto, int id)



        [HttpDelete("{id}")]

        public IActionResult DeletarCinemaPorId(int id)
        {
            var endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null) return NotFound();

            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();

            return NoContent();

        }
    }
}
