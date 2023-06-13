using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.Comparadores
{
    // IComparer é para comparar objetos;
    public class ComparadorContaCorrente : IComparer<ContaCorrente>
    {
        // outra forma de criar um comparador/ sort();
        public int Compare(ContaCorrente? x, ContaCorrente? y)
        {

            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

           return x.Numero_agencia.CompareTo(y.Numero_agencia);

            //if (x.Numero_agencia < y.Numero_agencia)
            //{
            //    return -1; // X fica na frente de Y;
            //}

            //if (x.Numero_agencia == y.Numero_agencia)
            //{
            //    return 0; // São equivalentes;
            //}

              //return 1; // Y fica na frente de X;
            
        }
    }
}
