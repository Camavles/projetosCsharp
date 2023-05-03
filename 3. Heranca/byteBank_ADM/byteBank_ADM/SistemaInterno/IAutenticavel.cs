using byteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.SistemaInterno
{
    public interface IAutenticavel //: Funcionario
    {
        // autenticavel passou a ser uma interface preciso colocar o I de interface;
        // propriedades e comportamentos;

        public string Senha { get; set; }

        public bool Autenticar(string senha);

        // preciso implementar o método construtor porque estou herdando de funcionário;
        //public Autenticavel(string cpf, double salario) : base(cpf, salario)
        //{
        //}

        
    }
}
