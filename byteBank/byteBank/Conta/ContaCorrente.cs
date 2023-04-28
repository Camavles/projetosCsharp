using byteBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Conta
{
    // utilizar PascalCase quando for nomear classe


    // usar camelCase quando for nomear variáveis q definem campos e parametrso de métodos
    public class ContaCorrente
    {
        private int numero_agencia;
        public int Numero_agencia
        {
            // propriedade que manipula o numero_agencia;
            get { return this.numero_agencia; }
            set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }

        }
        private string conta;
        private double saldo = 100;

        private Cliente titular;



        public void Depositar(double valor)
        {
            saldo += valor;
        }


        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;

            }
            else
            {
                return false;
            }

        }


        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo >= valor)
            {
                //this.saldo -= valor;
                Sacar(valor);

                //destino.saldo += valor;
                destino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }

        // para utilizar esse método; eu preciso inicializar cada campo com vaor padrão;
        //public override string ToString()
        //{
        //    return "Titular: " + this.titular + " Agencia: " + this.numero_agencia + " Conta: " + this.conta + " Saldo: " + this.saldo;
        //}

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo += valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

    }
}



