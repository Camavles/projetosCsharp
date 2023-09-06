using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<FilmeCategoria> Filmes { get; set; }
    }
}
