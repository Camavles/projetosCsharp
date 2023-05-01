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
        private Cliente titular;
        public Cliente Titular
        {
            get { return titular; }
            set { titular = value; }
        }


        private string conta;
        public string Conta
        {
            get { return conta; }
            set 
            { 
                if(value.Length == 0) 
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
            set
            {
                if(value < 0)
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
        //public void SetSaldo(double valor)
        //{
        //    if(valor < 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        saldo += valor;
        //    }
        //}

        //public double GetSaldo()
        //{
        //    return this.saldo;
        //}

    }
}
