using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class ProdutoDAOEntity : IProdutoDAO, IDisposable
    {
        private readonly LojaContext _context;

        public ProdutoDAOEntity()
        {
            this._context = new LojaContext();
        }

        public void Adicionar(Produto p)
        {
            _context.Produtos.Add(p);
            _context.SaveChanges();
        }

        public void Atualizar(Produto p)
        {
            _context.Produtos.Update(p);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            // posso usar no using 
            _context.Dispose();
        }

        public IList<Produto> Produtos()
        {
            return _context.Produtos.ToList();
        }

        public void Remover(Produto p)
        {
            _context.Produtos.Remove(p);
            _context.SaveChanges();
        }
    }
}
