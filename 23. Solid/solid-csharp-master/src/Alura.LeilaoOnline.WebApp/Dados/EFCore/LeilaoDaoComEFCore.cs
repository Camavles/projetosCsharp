using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados.EFCore
{
    public class LeilaoDaoComEFCore : ILeilaoDao
    {
        // representar a parte de acesso aos dados;
        // tenho uma classe específica para fazer esse acesso;
        AppDbContext _context;

        public LeilaoDaoComEFCore()
        {
            _context = new AppDbContext();
        }

        public IEnumerable<Categoria> ListCategories()
        {
            return _context.Categorias.ToList();
        }

        public Leilao GetLeilaoById(int id)
        {
            return _context.Leiloes.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Leilao> ListLeilao()
        {
            return _context.Leiloes.Include(i => i.Categoria).ToList();
        }


        public void Include(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        public void Update(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }

        public void Exclude(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }

    }
}
