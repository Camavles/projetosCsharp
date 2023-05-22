using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Gerencidores
{
    internal class GerenciadorConta
    {
        // aqui eu já passei direto a referencia de instancia
        private ISet<ContaCorrente> listaDeContasCorrentes = new HashSet<ContaCorrente>();

        // para retornar uma lista somente leitura, eu preciso implementar um IList
        public IList<ContaCorrente> ListaDeContasCorrentes
        {
            get
            {
                return new ReadOnlyCollection<ContaCorrente>(listaDeContasCorrentes.ToList());
            }
        }


        public bool BuscarConta(ContaCorrente conta)
        {
            return listaDeContasCorrentes.Contains(conta);
        }


        internal void Registrar(ContaCorrente conta)
        {
            this.listaDeContasCorrentes.Add(conta);
        }

        internal ContaCorrente EncontrarConta(string numeroConta)
        {
            foreach(var conta  in listaDeContasCorrentes)
            {
                if(conta.NumeroConta == numeroConta)
                {
                    return conta;
                }
            }

            throw new Exception("Conta não encontrada " + numeroConta);
        }


    }
}
