using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Data.Dtos
{
    public class CreateUsuarioDto
    {
        [Required]
        public string UserName{ get; set; }

        [Required]
        public DateTime DataNasciento { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        // momento de validação, momento de cadastro de usuário;

        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
