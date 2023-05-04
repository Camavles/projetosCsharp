using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioLivro.Autores;

namespace DesafioLivro.Livros
{
    public class Livro
    {
        public string Titulo { get; private set; }

        public Autor Autor; /*{ get; set; }*/
        public string ISBN { get; private set; }

        public string AnoDePublicacao { get; set; }

        public string GeneroLiterario { get; set; }

        public int NumeroDePaginas { get; set; }

        public string PaisDePublicacao { get; set; }

        public Livro(string isbn, string titulo)
        {
            this.ISBN = isbn;
            this.Titulo = titulo;
        }

    }


}
