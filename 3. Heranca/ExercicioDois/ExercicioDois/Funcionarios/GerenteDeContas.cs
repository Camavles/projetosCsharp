using ExercicioDois.SistemaInterno;
using ExercicioDois.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel, IBonificacao
    {
        

        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
        }



        public double GetBonificacao()
        {
            return this.Salario * 0.25;
        }


        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }


    }
}
