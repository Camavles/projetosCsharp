using ExercicioUm.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUm.Contas
{
    public class ContaCorrente
    {

        public static int TotalContasCriadas { get; private set; }
        private Cliente titular;
        // exemplo de propriedade auto implementada -> não precisei fazer uma validação aqui.
        public Cliente Titular { get; set; }


        private string conta;
        public string Conta
        {
            get { return conta; }
            private set
            {
                if (value.Length == 0)
                {
                    return;
                }
                else
                {
                    this.conta = value;
                }
            }


        }


        private int numero_agencia;

        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    this.numero_agencia = value;
                }
            }
        }

        private double saldo;
        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        // métodos  -> comportamento da minha classe;
        public double DepositarSaldo(double valor)
        {
            return saldo += valor;
        }

        public bool SacarSaldo(double valor)
        {
            if (valor > saldo)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }

        }

        public bool Transfere(double valor, ContaCorrente destino)
        {
            if (valor > saldo)
            {
                return false;
            }
            else
            {
                SacarSaldo(valor);
                destino.DepositarSaldo(valor);

                return true;

            }
        }

        // Uma forma de fazer GET SET
        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                saldo += valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        // método construtor; vai obrigar que eu passe na hora da contrsução do obj um número de agencia e um número de conta
        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalContasCriadas++;
        }

    }
}
