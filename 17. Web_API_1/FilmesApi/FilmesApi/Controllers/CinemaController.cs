using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public CinemaController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        [HttpPost]

        public IActionResult AdicionarCinema([FromBody] CreateCinemaDto cinemaDto)
        {
            // transforma o que eu passei no parametro() no type que está em <T>
            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RecuperaCinemaPorId), new { id = cinema.Id }, cinema);
        }


        [HttpGet]

        public IEnumerable<ReadCinemaDto> RecuperaCinemas([FromQuery] int? enderecoId = null)
        {
            if(enderecoId == null) 
            {
                return _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.ToList());
            }

            // recuperando um filme através de um endereco específico;
            return _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.FromSqlRaw($"SELECT Id, Nome, EnderecoId FROM cinemas where cinemas.EnderecoId = {enderecoId}").ToList());
        }


        [HttpGet("{id}")]

        public IActionResult RecuperaCinemaPorId(int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null) return NotFound();

            ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);

            return Ok(cinemaDto);
        }


        [HttpPut("{id}")]

        public IActionResult AtualizarFilmePorid([FromBody] UpdateCinemaDto cinemaDto, int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null) return NotFound();

            _mapper.Map(cinemaDto, cinema);
            _context.SaveChanges();

            return NoContent();

        }


        //[HttpPatch("{id}")]

        //public IActionResult AtualizarPorIdPatch([FromBody] JsonDocument cinemaDto, int id)



        [HttpDelete("{id}")]

        public IActionResult DeletarCinemaPorId(int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            if (cinema == null) return NotFound();

            _context.Cinemas.Remove(cinema);
            _context.SaveChanges();

            return NoContent();

        }

    }
}
