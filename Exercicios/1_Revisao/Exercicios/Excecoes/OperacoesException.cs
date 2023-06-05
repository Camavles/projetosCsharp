using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Excecoes
{
    public class OperacoesException : Exception
    {
        //criei essa classe genérica para poder lidar com as exceções, mas poderia ter criado classes específicas para lidar com cada exceção
        public OperacoesException(string mensagem) : base (mensagem) 
        { 
        }
    }
}
