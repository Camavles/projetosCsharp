using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    public class Cliente
    {
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set {
                if (value.Length == 0) 
                {
                    return;
                }
                else
                {
                    this.nome = value;
                }
            }
                    
        }

        private string cpf;
        public string Cpf 
        {
            get { return this.cpf; }
            set
            {
                if(value.Length == 0)
                {
                    return;
                }
                else
                {
                    this.cpf = value;
                }
            }
        }


        private string telefone;

        public string Telefone
        {
            get { return this.telefone; }
            set
            {
                if (value.Length == 0)
                {
                    return;
                }
                else
                {
                    this.telefone = value;
                }
            }
        }

        private string email;

        public string Email 
        {
            get { return this.email; }
            set
            {
                if(value.Contains("@"))
                {
                    this.email = value;
                }
                else
                {
                    return;
                }
            }
        }


        public Endereco endereco;
        public Pedido pedido;

        
    }
}
