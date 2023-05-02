using byteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        
        public void Registrar(Funcionario funcionario) 
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();

        }

        // sobrecarga de método;
        // deixei comentado após utilizar a herança
        //public void Registrar(Diretor diretor)
        //{
        //    this.TootalDeBonificacao += diretor.GetBonificacao();

        //}

    }
}
