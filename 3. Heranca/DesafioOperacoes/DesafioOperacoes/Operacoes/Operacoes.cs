using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioOperacoes.Operacoes
{
    public class Operacoes
    {
        public int CalcularSoma(int num1, int num2)
        {
            if (num1 <= 0)
            {
                return 0;
            }
            else
            {
                return num1 + num2;
            }
            
        }

        public int CalcularSubtracao(int num1, int num2)
        {
            return num1 - num2;
        }

        public int CalcularMultiplicacao(int num1, int num2)
        {
            return num1 * num2;
        }

        public double CalcularDivisao(int num1, int num2)
        {
            if(num1 <= 0)
            {
                return 0;
            }
            else
            {
                return num1 / num2;
            }
            
        }
    }
}
