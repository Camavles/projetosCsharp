using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class UsuarioService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;
        private SignInManager<Usuario> _signInManager;
        private TokenService _tokenService;

        public UsuarioService(IMapper mapper, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, TokenService tokenService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
            _tokenService = tokenService;
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

        // dentro do signInManager tem as opções de persistir os cookie depois de fechar o navegador, e tbm tem a opção de bloquear a conta do user, caso ele não consiga fazer o login, por isso coloquei false, false

        public async Task<string> Login(LoginUsuarioDto dto)
        {
           var resultado = await _signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, false);

            if(!resultado.Succeeded)
            {
                throw new ApplicationException("Usuário não autenticado!");
            }
            var usuario = _signInManager.UserManager.Users.FirstOrDefault(user => user.NormalizedUserName == dto.Username.ToUpper());


           var token = _tokenService.GenerateToken(usuario);

            return token;
        }
    }
}
