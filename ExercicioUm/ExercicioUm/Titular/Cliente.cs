using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUm.Titular
{
    public class Cliente
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length == 0)
                {
                    return;
                }
                else
                {
                    nome = value;
                }
            }
        }


        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set
            {
                if (value.Length <= 1 || value.Length > 14)
                {
                    return;
                }
                else
                {
                    cpf = value;
                }
            }
        }

        private string profissao;

        public string Profissao
        {
            get { return profissao; }
            set
            {
                if (value.Length <= 1)
                {
                    return;
                }
                else
                {
                    profissao = value;
                }
            }
        }


    }
}
