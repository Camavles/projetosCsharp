using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Cliente
    {
		private string nome;

		private string cpf;

		private string profissao;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public string CPF
		{
			get { return cpf; }
			set { cpf = value; }
		}

		public string Profissao
		{
			get { return profissao; }
			set { profissao = value; }
		}


        public override bool Equals(object? obj)
        {
			//Cliente outro = (Cliente)obj; // Conversão explícita 1 jeito de fazer 
			// Quando dá erro ele lança erro de conversão

			Cliente outro = obj as Cliente; // nesse tipo de conversão caso eu receba um objeto diferente para fazer a comparação o Equals não vai ter as propriedades necessárias para fazer  a comparação e é como se ele recebesse um objeto nulo;

			if (outro == null) { return false; }

			return this.Equals(outro.CPF);
        }
    }
}
