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

        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

        private ISet<Aluno> alunos = new HashSet<Aluno>();

        public IList<Aluno> Alunos 
        {
            get
            {

                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

   

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

        public int TempoTotal
        {
            get
            {
                // uma fora de fazer
                //int total = 0;

                //foreach(var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}

                //return total;
                // LINQ = Language Integrated Query 
                // Consulta Integrada à Linguagem -> faz consulta em cima de coleções;
                // retorne para a minha coleção de aula a soma dos tempos de cada aula;
                return aulas.Sum(aula => aula.Tempo);
            }
        }


        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

        public void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            // Busca HashSet;
            //foreach(var aluno in alunos)
            //{
            //    if(aluno.NumeroMatricula == numeroMatricula)
            //    {
            //        return aluno;
            //    }
            //}
            //throw new Exception("Matricula não encotrada!" + numeroMatricula);
            // busca através do dicionário

            //return this.dicionarioAlunos[numeroMatricula];

            //TryGetValue é um método seguro para casos de erro

            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            return aluno;

        }

        internal void SubstituiAluno(Aluno aluno)
        {

            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }
    }
}
