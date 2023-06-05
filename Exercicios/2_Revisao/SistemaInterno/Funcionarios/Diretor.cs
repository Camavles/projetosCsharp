using SistemaInterno.Autenticacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInterno.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string nome, string cpf) : base(nome, cpf, 5000)
        {
        }

        public override double AumentarSalario()
        {
            return this.Salario *= 1.5;
        }

    }
}
