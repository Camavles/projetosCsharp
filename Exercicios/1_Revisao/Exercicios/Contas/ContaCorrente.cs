using Exercicios.Cliente;
using Exercicios.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercicios.Contas
{
    [XmlInclude(typeof(ContaCorrente))]
    public class ContaCorrente
    {

        public Titular titular;

        public int Numero_agencia { get; private set; }

        public string Conta { get;  set; }

        public double Saldo { get; set; }

        public static int TotalDeContas { get; private set; }

        public static double TaxaOperacao { get; private set; }

        //Construtor com 
        public ContaCorrente(int numero_agencia, string conta)
        {

            if (numero_agencia > 0)
            {
                this.Numero_agencia = numero_agencia;
            }
            else
            {
                throw new ArgumentException("Erro! Não é possível ter o número de conta menor que zero!", nameof(numero_agencia));
            }
            
            this.Conta = conta;

            TotalDeContas++;
            TaxaOperacao = 30;
            TaxaOperacao = TaxaOperacao / TotalDeContas;
            
        }


        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
            else
            {
                throw new OperacoesException("Erro! Não é possível depositar valor negativo ou igual a zero!");
            }


        }

        public void Sacar(double valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
                Console.WriteLine("Operação realizada com sucesso!");
               
            }
            else
            {
                // também poderia utilizar o argument execption
                throw new OperacoesException("Erro! Não é possível realizar essa operação!");
            }

        }

        public void Transferir(ContaCorrente destino, double valor)
        {
            if (this.Saldo > valor && this.Saldo > 0)
            {
                this.Saldo -= valor;
                destino.Saldo += valor;
                Console.WriteLine("Operação realizada com sucesso!");
                

            }
            else
            {
                throw new OperacoesException("Erro! Não é possível transferir valores negativos!");
            }

        }

        
 
    }
}
