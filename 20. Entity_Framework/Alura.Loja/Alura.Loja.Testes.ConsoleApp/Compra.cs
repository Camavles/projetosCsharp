using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Compra
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; } // quando eu explicito o Id do produto, o tipo inteiro não pode ser null, então o entity garante que essa propriedade não fique nula
        public Produto Produto { get; set; }
        public double Preco { get; set; }

        //public virtual ICollection<Produto> Produtos 
    }
}
