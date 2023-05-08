using ExercicioTres.Titular;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTres.Contas
{

    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        public static float TaxaOperacao { get; private set; }

        private int numero_agencia;
        public int Numero_agencia
        {
            get { return numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    numero_agencia = value;
                }
            }
        }


        public string Conta { get; set; }

        private double saldo = 100;

        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            if(valor > 0)
            {
               this.saldo += valor;
            }
            else
            {
                throw new DepositoException("O valor do deposito precisa ser maior que zero!");
            }
           
        }



        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                // acredito que o que permite lançar essa exceção sem impotar é o throw eo new que cria uma nova instancia de classe;
                throw new SaldoInsuficienteException("Não foi possível realizar esta operação! Saldo insuficiente!");
                //throw new OperacaoFinanceiraException("Erroonnn", passo o tipo de exceção);
            }
        }




        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;


            if(numero_agencia <= 0)
            {
                //nameof() --> consegue trazer esse parametro como uma string
                throw new ArgumentException("Número de agência menor ou igual a zero!", nameof(numero_agencia));
            }


            //poderia só colocar a variavel TaxaDeContasCriadas antes da TaxaOperacao, pois já estaria preenchida;

            //try
            //{
            //    TaxaOperacao = 30 / TotalDeContasCriadas;
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("Ocorreu um erro. Não é possível dividir por zero!");
            //}

            

            TotalDeContasCriadas++;
        }
    }
}
