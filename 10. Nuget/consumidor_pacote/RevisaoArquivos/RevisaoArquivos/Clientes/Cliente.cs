using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoArquivos.Clientes
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


		public string Cpf
		{
			get { return cpf; }
			set { cpf = value; }
		}



		public string Profissao
		{
			get { return profissao; }
			set { profissao = value; }
		}

        public override string ToString()
        {
			return $"Nome: {nome}, CPF: {cpf}";
        }

    }
}
