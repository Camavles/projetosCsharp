using ExercicioDois.Funcionarios;
using ExercicioDois.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois.GerenciadorDeBonificacao
{
    // objetivo desssa classe: organizar a bonificação;
    



    public class GerenciadorDeBonificacao
    {
        public double TotalBonificacao { get; private set; }

        // recebe um objeto do tipo funcionário e diretor
        public void Registrar(Bonificacao bonificacao)
        {
            this.TotalBonificacao += bonificacao.GetBonificacao();
        }



    }
}