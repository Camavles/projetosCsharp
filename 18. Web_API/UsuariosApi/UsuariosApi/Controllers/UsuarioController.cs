using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using UsuariosApi.Data;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {


        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService cadastroService)
        {
            _usuarioService = cadastroService;
        }

        [HttpPost("cadastro")]

        // representa uma operação assíncrona que pode retornar uma valor 
        // o tipo de retorno de um método assíncro prevcisa ser: nulo, Task Task<T>, IAsyncEnumerable<T>, IAsyncEnumerator<T>
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
        {

            await _usuarioService.Cadastra(dto);

            return Ok("Usuário cadastrado");
        }


        [HttpPost("login")]

        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {

           var token = await _usuarioService.Login(dto);

            return Ok(token);
        }
    }
}
