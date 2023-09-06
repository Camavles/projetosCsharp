namespace RevisaoEnity.Entities
{
    public class Endereco
    {
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Complemento { get; set; }

        // meu endereço tem 1 e apenas um Cliente
        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
