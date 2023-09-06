using DomainLayer.Entities;

namespace RevisaoEnity.Entities
{
    public class Cliente
    {
        public int Id { get; set; } 

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public virtual ICollection<ContasClientes> Contas { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
