using byteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    // quando eu coloco dois pontos eu passo a herança
    public class Diretor :  FuncionarioAutenticavel // : Autenticavel esse autenticável eu aplico apenas a Diretor e a Gerente de Contas
    { 

        // utilizando o overrride para sobrescrita;
        public override double GetBonificacao()
        {
            // utilização do Get de Funcionario;
            //return this.Salario + base.GetBonificacao();
            return this.Salario * 0.5;
        }

        // passando para o construtor a obrigatoriedade do cpf e do salario, a partir da classe base;
        public Diretor(string cpf):base(cpf, 5000) 
        {
            //this.Cpf = cpf;
            //Console.WriteLine("Criando um Diretor");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

    }
}
