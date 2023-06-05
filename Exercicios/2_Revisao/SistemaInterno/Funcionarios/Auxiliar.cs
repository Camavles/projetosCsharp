using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInterno.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        // eu herdo o construtor e os métodos que eu marquei como abstrato, para serem implementados;
        // como eu já sei o salario inicial de cada funcionario, eu posso passa direro no construtor;
        public Auxiliar(string nome, string cpf) : base(nome, cpf, 2000)
        {
        }

        public override double AumentarSalario()
        {
            return this.Salario *= 0.2; 
        }

    }
}
