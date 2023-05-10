using SistemaInterno.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInterno.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        public double TotalBonificacao { get; private set; }


        public void Registrar(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.AumentarSalario();
        }
       
    }
}
