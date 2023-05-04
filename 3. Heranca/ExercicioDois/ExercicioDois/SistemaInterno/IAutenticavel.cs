using ExercicioDois.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois.SistemaInterno
{
    public interface IAutenticavel
    {
        // a interface é um contrato;
        public string Senha { get; set; }

        public abstract bool Autenticar(string senha);

    }
}
