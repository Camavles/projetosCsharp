using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercicios
{
    public class Aluno
    {
		private string nome;
		private int matricula;

        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}



		public int Matricula
		{
			get { return matricula; }
			set { matricula = value; }
		}

        public override bool Equals(object? obj)
        {
            Aluno outro = obj as Aluno;
            if(outro == null) return false;
            return this.nome.Equals(outro.nome);
        }


        public override string ToString()
        {
            return $"Nome: {nome}, Matrícula: {matricula}";
        }
    }
}
