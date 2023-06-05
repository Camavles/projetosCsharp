using System;
using System.Collections.Generic;

using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoArquivos.Contas
{
    public class ContaCorrente
    {
        private string numero_conta;

        private int agencia;

        private double saldo;

        public Cliente titular;

        public string Numero_conta
        {
            get { return numero_conta; }
            set { numero_conta = value; }
        }


        public int Agencia
        {
            get { return agencia; }
            set
            {

                if (agencia <= 0)
                {
                    Console.WriteLine("Número Inválido!");
                }
                else
                {

                    agencia = value;
                }
            }

        }

        public double Saldo
        {
            get { return saldo; }
            set
            {

                if (value < 0)
                {
                    Console.WriteLine("Saldo não pode ser negativo");
                }
                else
                {
                    saldo = value;
                }
            }
        }


        public bool Sacar(double valor)
        {
            if (valor <= 0 || valor > this.saldo)
            {
                Console.WriteLine("Valor inválido ou saldo insuficiente!");
            }
            else
            {
                this.saldo -= valor;
                Console.WriteLine("Operação efetuada com sucesso!");
            }

            return true;
        }


        public double Depositar(double valor)
        {
            return this.saldo += valor;
        }


        public bool Transfere(ContaCorrente conta, double valor)
        {
            if (valor <= 0 || valor > this.saldo)
            {
                Console.WriteLine("Operação inválida!");
            }
            else
            {
                this.Sacar(valor);
                conta.Depositar(valor);
                Console.WriteLine("Operação realizada com sucesso!");
            }

            return true;
        }

        public ContaCorrente(int agencia, string numero_conta)
        {
            this.numero_conta = numero_conta;
            this.agencia = agencia;
        }

        public ContaCorrente()
        {
            
        }


        public override string ToString()
        {
            return $"Conta: {numero_conta}, Agência: {agencia}, Saldo R$ {saldo}";
        }

    }
}
