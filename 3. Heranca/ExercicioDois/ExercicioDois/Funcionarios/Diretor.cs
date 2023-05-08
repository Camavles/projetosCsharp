using ExercicioDois.SistemaInterno;
using ExercicioDois.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel, IBonificacao
    {

        // 1. quando eu estou na classe base e crio um construtor; na classe derivada eu preciso fazer a implementação desse construtor;
        // 2. para que o código entende a implementação do cpf e do salario, eu preciso passar a refrencia do construtor da classe base.
        /* 3. EU TINHA ESSA CONSTRUÇÃO NO MEU CONSTRUTOR: public Diretor(string cpf, double salario) : base(cpf, salario) 
         eu retirei a parte da variável double salario, porque não é mais algo que eu recebo na hr que eu crio o meu objeto e sim, algo que já estou passando no construtor;
         */
        public Diretor(string cpf) : base(cpf, 5000)
        {
        }

        // 3. com o base.GetBonificacao eu digo que eu to chamando o método base

        public double GetBonificacao()
        {
            return this.Salario * 0.5; /*+ base.GetBonificacao()*/;
        }

        public override void AumentarSalario()
        {
            // ou this.Salario *= 1.15;
            this.Salario += this.Salario * 0.15;
        }

        

    }
}
