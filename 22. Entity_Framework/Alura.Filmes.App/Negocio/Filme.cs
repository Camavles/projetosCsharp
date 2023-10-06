using Alura.Filmes.App.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AnoDeLancamento { get; set; }
        public short Duracao { get; set; }
        public string TextoClassificacao { get; private set; }
        public ClassificacaoIndicativa Classificacao 
        {
            get { return TextoClassificacao.ParaValor(); }
            set { TextoClassificacao = value.ParaString(); }
        }

        //nav
        public virtual Idioma IdiomaFalado { get; set; }
        public virtual Idioma IdiomaOriginal { get; set; }
        public virtual ICollection<FilmeAtor> Atores { get; set; }
        public virtual ICollection<FilmeCategoria> Categorias { get; set; }

        public override string ToString()
        {
            return $"Titulo: {Titulo}, Duração: {Duracao}, Descrição: {Descricao}";
        }
    }
}
