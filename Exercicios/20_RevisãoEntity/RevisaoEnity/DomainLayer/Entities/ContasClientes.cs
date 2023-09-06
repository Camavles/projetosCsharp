using RevisaoEnity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class ContasClientes
    {
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set;} 

        public int ContaId { get; set; }
        public virtual Conta Conta { get; set; }
    }
}
