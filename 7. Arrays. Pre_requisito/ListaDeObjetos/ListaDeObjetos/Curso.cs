using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeObjetos
{
    public class Curso
    {
        private IList<Aula> aulas;

        
        public IList<Aula> Aulas
        {
            // retornar apenas uma lista de leitura
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        private string nome;
        private string nomeInstrutor;

        public Curso(string nome, string nomeInstrutor)
        {
            this.nome = nome;
            this.nomeInstrutor = nomeInstrutor;
            this.aulas = new List<Aula>();
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string NomeInstrutor
        {
            get { return nomeInstrutor; }
            set { nomeInstrutor = value; }
        }

        public void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }
    }
}
