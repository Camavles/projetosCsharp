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


        public IList<ContaCorrente> ListaDeContasCorrentes
        {
            get
            {
                return new ReadOnlyCollection<ContaCorrente>(listaDeContasCorrentes.ToList());
            }
        }

        public ContaCorrente BuscarConta(string contaNumero)
        {
            // Problema para resolver: Não é possível fazer esse tipo de busca em uma lista HashSet
            //foreach(var conta in ListaDeContasCorrentes)
            //{
            //    if(conta.NumeroConta == contaNumero)
            //    {
            //        return conta;
            //    }
                
            //}

            //throw new Exception("Conta não contrada" + contaNumero);
        }


        internal void Registrar(ContaCorrente conta)
        {
            this.listaDeContasCorrentes.Add(conta);
        }



    }
}
