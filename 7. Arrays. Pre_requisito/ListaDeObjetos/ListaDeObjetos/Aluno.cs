using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeObjetos
{
    public class Aluno 
    {
        // é bom guardar a matricula e o nome do aluno em um set, pois fica mais fácil de procurar;
		private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		

		public int NumeroMatricula
		{
			get { return numeroMatricula; }
			set { numeroMatricula = value; }
		}


        public override string ToString()
        {
            return $"Nome: {nome}, Matricula {numeroMatricula}";
        }

        public override bool Equals(object? obj)
        {
            // conversão cast;
            Aluno outro = obj as Aluno;
            if (outro == null) return false;
            return this.nome.Equals(outro.nome);
        }

        public override int GetHashCode()
        {
            // eu implemento e sobreescrevo o GetHashCode() para ele retornar o mesmo código de dispersão para objetos considerados iguais;
            //
            return this.nome.GetHashCode();
        }
    }
}
