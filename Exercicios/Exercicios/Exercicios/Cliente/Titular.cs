using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercicios.Cliente
{
    [XmlInclude(typeof(Titular))]
    public class Titular
    {
        public string Nome { get; set; } 

        public string Cpf { get; set; }

        public string Telefone { get; set; }
    }
}
