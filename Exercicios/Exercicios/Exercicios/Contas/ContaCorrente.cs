using Exercicios.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Contas
{
    public class ContaCorrente
    {

        public Titular titular;

        public int Numero_agencia { get; private set; }

        public string Conta { get; private set; }

        public double Saldo { get; private set; }


        //Construtor com 
        public ContaCorrente(int numero_agencia, string conta) 
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = conta;
        }


        public void Depositar(double valor)
        {
           this.Saldo += valor;

        }

        public bool Sacar(double valor)
        {
            if(valor <= this.Saldo)
            {
                this.Saldo -= valor;
                Console.WriteLine("Operação realizada com sucesso!");
                return true;
            }
            else
            {

                return false;
            }
            
        }

        public bool Transferir(ContaCorrente destino, double valor)
        {
            if(this.Saldo >= valor )
            {
                this.Saldo -= valor;
                destino.Saldo += valor;
                Console.WriteLine("Operação realizada com sucesso!");
                return true;
                
            }
            else
            {
                return false;
            }

        }


    }
}
