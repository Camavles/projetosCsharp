using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    internal class GerenciadorClientes
    {
        public List<Cliente> clientes = new List<Cliente>();

        internal void Adiciona(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        internal void Remove(Cliente cliente)
        {
            clientes.Remove(cliente);
        }

        internal Cliente Encontra(string nome)
        {
            foreach (var cliente in clientes)
            {
                if (cliente.Nome == nome)
                {
                    return cliente;
                }
            }

            throw new Exception("Cliente não encontrado" + nome);


        }
    }
}
