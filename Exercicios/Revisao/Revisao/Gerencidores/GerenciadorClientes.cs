using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Gerencidores
{
    internal class GerenciadorClientes 
    {
        private IList<Cliente> clientes;

        // Lista somente leitura
        public IList<Cliente> Clientes 
        { get 
            {
                // Estava dando erro, pois eu não tinha feito a referencia de instancia ao objeto;
                // criei isso no ctor;
                return new ReadOnlyCollection<Cliente>(clientes);
            }
        }



        internal void Adiciona(Cliente cliente)
        {
            this.clientes.Add(cliente);
        }


        // 
        internal void Remove(Cliente cliente)
        {
            this.clientes.Remove(cliente);
        }



        public Cliente Encontra(string nome)
        {
            //foreach (var cliente in clientes)
            //{
            //    //if (cliente.Nome == nome)
            //    //{
            //    //    Console.WriteLine("Cliente encontrado!");
            //    //    return cliente;
            //    //}
            //    
            //}

            var buscaCliente = Clientes.FirstOrDefault(cliente => cliente.Nome.Contains(nome));
            return buscaCliente;
            

        }

        
        public GerenciadorClientes()
        {
            this.clientes = new List<Cliente>();
        }


        public override string ToString()
        {
            return $"Clientes: {string.Join(",", clientes)}";
        }

     
    }
}
