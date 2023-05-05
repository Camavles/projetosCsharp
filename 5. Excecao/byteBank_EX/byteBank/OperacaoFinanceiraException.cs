using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank
{
    public class OperacaoFinanceiraException : Exception
    {
        // dois construtores que serão usados de formas diferentes;

        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {

        }

        // soobrecarga de construtor
        // mensagem interna
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna) : base (mensagem, excecaoInterna)
        {

        }
    }
}
