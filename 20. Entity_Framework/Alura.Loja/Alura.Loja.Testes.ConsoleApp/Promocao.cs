

using System;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataTermino { get; internal set; }

        // nas versões mais recentes eu preciso usar o virtual
        public virtual IList<PromocaoProduto> Produtos { get; set; }


        public Promocao()
        {
            this.Produtos = new List<PromocaoProduto>();
        }

        public void IncluirProdutos(Produto produto)
        {
            this.Produtos.Add(new PromocaoProduto() { Produto = produto});
        }

    }
}
