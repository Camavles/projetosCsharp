using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class PromocaoProduto
    {
        //public int Id 
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int PromocaoId { get; set; }
        public Promocao Promocao { get; set; }

    }
}
