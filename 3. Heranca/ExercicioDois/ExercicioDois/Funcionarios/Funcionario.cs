using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionarios++;
        }

        // coloquei virtual para poder reescrever um diretor;
        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }

        public virtual void AumentarSalario()
        {
            this.Salario += this.Salario * 0.1;
        }


        

 
    }
}
