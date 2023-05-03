using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois.Funcionarios
{
    public class Diretor : Funcionario
    {
        // 1. quando eu estou na classe base e crio um construtor; na classe derivada eu preciso fazer a implementação desse construtor;
       // 2. para que o código entende a implementação do cpf e do salario, eu preciso passar a refrencia do construtor da classe base.

        public Diretor(string cpf, double salario) : base(cpf, salario)
        {
        }


        // 3. com o base.GetBonificacao eu digo que eu to chamando o método base

        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            // ou this.Salario *= 1.15;
            this.Salario += this.Salario * 0.15;
        }

    }
}
