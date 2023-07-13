using Microsoft.AspNetCore.Identity;

namespace UsuariosApi.Models
{
    public class Usuario : IdentityUser
    {
        // O Identity vai responsável por fazer toda a criação do controle de usuáerio, então em um primeiro momento fica vazio.

        //Identityuser --> diz para o meu DbContext que o Usuario tem informações para serem preenchidas pelo Identity; ou seja, é tratável 

        public DateTime DataNascimento { get; set; }

        // quando eu faço isso, eu digo que assim que um Usuário novo for criado, ele 
        public Usuario() : base() { }
       

    }
}
