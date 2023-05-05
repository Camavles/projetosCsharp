using System;
using ExercicioDois.GerenciadorDeBonificacao;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioDois.Utilitarios;

namespace ExercicioDois.Funcionarios
{
    public class Auxiliar : Funcionario, Bonificacao
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }

        public double GetBonificacao()
        {
            return this.Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }




    }
}
