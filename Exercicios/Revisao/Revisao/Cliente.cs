using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class Cliente
    {

		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		private string cpf;

		public string Cpf
		{
			get { return cpf; }
			set { cpf = value; }
		}

        public override string ToString()
        {
			return $"Cliente: {Nome}";
        }


    }
}
