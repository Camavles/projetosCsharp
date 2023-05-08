using ExercicioDois.Funcionarios;

namespace ExercicioDois.Utilitarios
{
    // objetivo desssa classe: organizar a bonificação;


    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonficacao { get; private set; }

        public void Registrar(IBonificacao bonificacao)
        {
            this.TotalDeBonficacao += bonificacao.GetBonificacao();
        }
    }
}