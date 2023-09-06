using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double PrecoUnitario { get; set; }
        public string Unidade { get; set; }
        public IList<PromocaoProduto> Promocoes { get; internal set; }
        public IList<Compra> Compras { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome}, Categoria: {this.Categoria}, Preço: {this.PrecoUnitario}";
        }

    }
}