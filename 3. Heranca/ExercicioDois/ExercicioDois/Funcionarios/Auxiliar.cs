using ExercicioDois.Utilitarios;
using System.Runtime.CompilerServices;

namespace ExercicioDois.Funcionarios
{
    public class Auxiliar : Funcionario, IBonificacao
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        public double GetBonificacao()
        {
            return this.Salario * 0.2;
        }

    }
}
