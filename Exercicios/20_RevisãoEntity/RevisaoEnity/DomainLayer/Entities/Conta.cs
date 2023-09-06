using DomainLayer.Entities;

namespace RevisaoEnity.Entities
{
    public class Conta
    {
        public int Id { get; set; }

        public string NumeroConta { get; set; }

        public string Agencia { get; set; }

        public virtual ICollection<ContasClientes> Titular { get; set; }



    }
}
