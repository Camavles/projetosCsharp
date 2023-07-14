using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using UsuariosApi.Data;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public UsuarioController(IMapper mapper, UserManager<Usuario> userManager = null)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]

        // representa uma operação assíncrona que pode retornar uma valor 
        // o tipo de retorno de um método assíncro prevcisa ser: nulo, Task Task<T>, IAsyncEnumerable<T>, IAsyncEnumerator<T>
        public async Task<IActionResult> CadastraUsuario(CreateUsuarioDto dto)
        {
            var usuario = _mapper.Map<Usuario>(dto);

            
            // esperamos o resultado dessa operação e isso é diferente de esperar o retorno de uma operação assíncrona
            // o await aguarda pela execução do CreateAsync
           IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);

            if (resultado.Succeeded) return Ok("Usuário cadastrado");

            throw new ApplicationException("Falha ao cadastrar usuário!");
            
        }
    }
}
