using ExercicioDois.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois.SistemaInterno
{
    public class SistemaInterno
    {
        // passando o Funcionario como parametro;
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if(usuarioAutenticado == true)
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
        // retirei a sobrecarga antes de passar como parametro o funcionario
        //public bool Logar(GerenteDeContas funcionario, string senha)
        //{
        //    bool usuarioAutenticado = funcionario.Autenticar(senha);
        //    if (usuarioAutenticado == true)
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
