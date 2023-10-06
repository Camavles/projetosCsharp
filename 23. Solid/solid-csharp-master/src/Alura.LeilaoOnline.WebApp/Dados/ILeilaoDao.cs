using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;


namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
         IEnumerable<Categoria> ListCategories();
         Leilao GetLeilaoById(int id);
         IEnumerable<Leilao> ListLeilao();
         void Include(Leilao leilao);
         void Update(Leilao leilao);
         void Exclude(Leilao leilao);

    }
}
