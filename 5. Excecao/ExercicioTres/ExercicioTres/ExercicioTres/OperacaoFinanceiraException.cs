using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTres
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {
           
        }

        // eu crio um outro construtor para na hora de implentar eu escolher qual deles eu usarei para mostrar para o usuário e qual deles eu mostro para o dev
        //essa é uma manesagem interna
        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna) : base(mensagem, excecaoInterna)
        { 

        }
    }
}
