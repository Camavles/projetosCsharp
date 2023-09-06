using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
   
    public class Ator
    {
       
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }

        public virtual  ICollection<FilmeAtor> Filmes { get; set; }

        public override string ToString()
        {
            return $"Nome: {PrimeiroNome} {UltimoNome}";
        }

        // estou quebrando a regra do entity, passando anotações sobre como está o nome
        // da tabela e da coluna no meu banco, para que o entity consiga mapear os dados que estão no banco para a minha aplicação;
    }
}


