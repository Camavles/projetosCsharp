using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    public interface IProdutoDAO 
    {
        // isso é apenas a interface, ou seja, assinatura dos métodos (casca)
        void Adicionar(Produto p);
        void Atualizar(Produto p);
        IList<Produto> Produtos();
        //void RecuperarProdutos(Produto p);
        void Remover(Produto p);
    }
}
