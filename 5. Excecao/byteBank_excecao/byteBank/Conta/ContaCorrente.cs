using byteBank_excecao.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_excecao.Conta
{

    // utilizar PascalCase quando for nomear classe
    // usar camelCase quando for nomear variáveis q definem campos e parametrso de métodos
    public class ContaCorrente
    {
        // static propriedade da classe
        public static int TotalContasCriadas { get; private set; }

        public static float TaxaOperacao { get; private set; }

        private int numero_agencia;
        public int Numero_agencia
        {
            // GET / SET propriedade que manipula o numero_agencia;
            get { return numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    numero_agencia = value;
                }
            }

        }

        //private string conta;
        // propriedade auto implementada quando não não é interessante fazer validações:
        public string Conta { get; set; }

        // -----
        private double saldo = 100;
        public Cliente Titular { get; set; }



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
                // acredito que seja possível lançar essa exceção sem importar o namespace e fazer herança da classe por causa do new e do throw;
                throw new SaldoInsuficienteException("Saldo Insuficiente para a operação!");
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

        // para utilizar esse método; eu preciso inicializar cada campo com valor padrão;
        //public override string ToString()
        //{
        //    return "Titular: " + this.titular + " Agencia: " + this.numero_agencia + " Conta: " + this.conta + " Saldo: " + this.saldo;
        //}


        // GET E SET de outra forma;
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
            return saldo;
        }


        // método construtor para campos
        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            Numero_agencia = numero_agencia;
            Conta = numero_conta;

            if (numero_agencia <= 0)
            {
                // tratando uma exceção
                throw new ArgumentException("Número de agência menor ou igual a zero!", nameof(numero_agencia));
                // nameof(parametro) a gente traz esse parametro como uma string

            }


            //try
            //{
            //    TaxaOperacao = 30 / TotalContasCriadas;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Ocorreu um erro! Não é possível fazer uma divisão por zero!");
            //}

            TotalContasCriadas++;

        }



    }
}



