using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTres
{
    public class DepositoException : Exception
    {
        public DepositoException(string mensagem) : base(mensagem)
        {
        }

    }
}
