using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Excercicios
{
    public class Curso
    {
        //atributos 
        private string nome;
        private string nomeInstrutor;
        private List<Aula> aulas;

        public Curso(string nome, string nomeInstrutor)
        {
            this.nome = nome;
            this.nomeInstrutor = nomeInstrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome { get { return nome; } set { nome = value; } }
        
        public List<Aula> Aulas { get { return aulas; } }

        public string NomeInstrutor { get { return nomeInstrutor;  } set { nomeInstrutor = value; } }

        public void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        //public override string ToString()
        //{
        //    return $"Curso: {nome} Aulas: {string.Join(",", aulas)}";
        //}
    }
}
