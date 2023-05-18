using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
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





    }
}
