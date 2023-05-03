using byteBank_ADM.Funcionarios;
using byteBank_ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.SistemaInterno
{
    public class SistemaInterno
    {

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }

        }


        // sobrecarga
        //public bool Logar(ParceiroComercial parceiro, string senha)
        //{
        //    bool usuarioAutenticado = parceiro.Autenticar(senha);

        //    if (usuarioAutenticado)
        //    {
        //        Console.WriteLine("Boas vindas ao nosso sistema!");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Senha incorreta!");
        //        return false;
        //    }

        //}

    }
}

