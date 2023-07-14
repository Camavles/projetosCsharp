using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class CadastroService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public CadastroService(IMapper mapper, UserManager<Usuario> userManager)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task Cadastra(CreateUsuarioDto dto)
        {
            var usuario = _mapper.Map<Usuario>(dto);


            // esperamos o resultado dessa operação e isso é diferente de esperar o retorno de uma operação assíncrona
            // o await aguarda pela execução do CreateAsync
            IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);

            if (!resultado.Succeeded)
            {
                throw new ApplicationException("Falha ao cadastrar usuário!");
            }

           
        }
    }
}
