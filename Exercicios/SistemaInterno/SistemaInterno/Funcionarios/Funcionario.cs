using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInterno.Funcionarios
{
    public abstract class Funcionario
    {

        public string Nome { get; set; }   

        public string Cpf { get; private set; }

        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        // uma classe abstrata ode possuir métodos concretos!!

        public abstract double AumentarSalario();


        //public abstract double GetSalario();


        public Funcionario(string nome,  string cpf, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;

            TotalDeFuncionarios++;
        }



    }
}
