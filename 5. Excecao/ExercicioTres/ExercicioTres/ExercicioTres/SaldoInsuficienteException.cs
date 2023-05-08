using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTres
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        //criando uma exceção;
        //construtor
        // no parametro o que importa é formato/tipo de mensagem, que no caso é string
        public SaldoInsuficienteException(string mensagem) : base(mensagem) 
        { 
        }

    }
}
