using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Excercicios
{
    public class Curso
    {
        //atributos / campos
        private string nome;
        private string nomeInstrutor;
        private List<Aula> aulas;

       

        // minha lista HashSet privada
        private ISet<Aluno> alunos = new HashSet<Aluno>();

        // método público que retorna a minha lista;
        public IList<Aluno> Alunos
        {
            get
            {

                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        public Curso(string nome, string nomeInstrutor)
        {
            this.nome = nome;
            this.nomeInstrutor = nomeInstrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome { get { return nome; } set { nome = value; } }
        
        public List<Aula> Aulas { get { return aulas; } }

        public string NomeInstrutor { get { return nomeInstrutor;  } set { nomeInstrutor = value; } }


        //public int TempoTotal
        //{
        //    get
        //    {
        //        return aulas.Sum(aula => aula.Tempo);

        //    }
        //}

        public void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }


        public override string ToString()
        {
            return $"Curso: {nome} Aulas: {string.Join(",", aulas)}";
        }

        public void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }
    }
}
