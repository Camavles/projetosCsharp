using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    // quando eu coloco dois ponto eu passo a herança
    public class Diretor:Funcionario
    {
        // utilizando o overrride para sobescrita;
        public override double GetBonificacao()
        {
                                 // utilização do Get de Funcionario;
            return this.Salario + base.GetBonificacao();
        }

        // passando para o construtor a obrigatoriedade do cpf e do salario, a partir da classe base;
        public Diretor(string cpf, double salario):base(cpf, salario) 
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
