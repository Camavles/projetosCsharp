using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    public class Pedido
    {
        public string item;
        public int qtdItens;
        public double valorUnitario;

        
        public double CalcularValorTotal(int qtdItens,  double valorUnitario)
        {
            double calcule = this.qtdItens * this.valorUnitario;
            return calcule;
        }
    }
}
