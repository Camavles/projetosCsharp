using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        // Testando ChangeTracker
        //static void Main(string[] args)
        //{
        //using(var contexto = new LojaContext())
        //{
        //    var produtos = contexto.Produtos.ToList();

        //    
        //    foreach (var produto in produtos)
        //    {
        //        Console.WriteLine(produto);
        //    }

        //    foreach (var entidade in contexto.ChangeTracker.Entries())
        //    {
        //        Console.WriteLine(entidade.State);
        //    }


        //    Console.WriteLine("===============");
        //    var primeiro = produtos.First();
        //    primeiro.Nome = "Novo Filme";


        //    foreach (var produto in produtos)
        //    {

        //        Console.WriteLine(produto);
        //    }


        //    foreach (var entidade in contexto.ChangeTracker.Entries())
        //    {
        //        Console.WriteLine(entidade.State);
        //    }
        //}


        //}

        // ------------ -------RELACIONAMENTO N:N
        //static void Main(string[] args)
        //{

        //    //var produto = new Produto();
        //    //produto.Nome = "Pão Francês";
        //    //produto.Categoria = "Padraria";
        //    //produto.Unidade = "Unidade";
        //    //produto.PrecoUnitario = 0.40;

        //    //var compra = new Compra();
        //    //compra.Produto = produto;
        //    //compra.Quantidade = 6;
        //    //compra.Preco = produto.PrecoUnitario * compra.Quantidade;

        //    // -------RELACIONAMENTO N:N

        //    //var produto1 = new Produto() { Nome = "Suco de Laranja", Categoria = "Bebidas", PrecoUnitario = 5.50, Unidade = "Litros" };
        //    //var produto2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 10.50, Unidade = "Gramas" };

        //    //var promocaoPascoa = new Promocao();
        //    //promocaoPascoa.Descricao = "Páscoa 2023";
        //    //promocaoPascoa.DataInicio = DateTime.Now;
        //    //promocaoPascoa.DataTermino = DateTime.Now.AddMonths(3);


        //    //promocaoPascoa.IncluirProdutos(produto1);
        //    //promocaoPascoa.IncluirProdutos(produto2);




        //    using (var contexto = new LojaContext())
        //    {

        //        //contexto.Promocoes.Add(promocaoPascoa);
        //        //contexto.SaveChanges();

        //        //var promocao = contexto.Promocoes.Find(4);
        //        //contexto.Promocoes.Remove(promocao);
        //        //contexto.SaveChanges();

        //       // ExibeEntries(contexto.ChangeTracker.Entries());

        //    }

        //}

        static void Main(string[] args)
        {

            using (var contexto = new LojaContext())
            {
                //var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                //var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                //loggerFactory.AddProvider(SqlLoggerProvider.Create());

                // explorando o relacionamento 1:1

                //var cliente = contexto
                //    .Clientes
                //    .Include(c => c.EndercoDeEntrega)
                //    .FirstOrDefault();

                // eu preciso espeficificar q eu quero pegar o logradouro, pq o EnderecoDeEntrega é do tipo Endereco(ou seja, outro objeto), então eu navego dentro desse outro objeto e digo que propriedade quero exibir, a não ser q eu tenha um override ToString (como eu acabei fazendo);


                // Console.WriteLine($"Endereço de entrega: {cliente.EndercoDeEntrega}");

                var produto = contexto
                    .Produtos
                    //.Include(c => c.Compras)
                    .Where(c => c.Id == 3002)
                    .FirstOrDefault();


                //foreach(var item in produto.Compras)
                //{
                //    Console.WriteLine(item.Produto);
                //}

                // populando Coleções após a carga da entidade principal.

                contexto.Entry(produto)
                    .Collection(p => p.Compras)
                    .Query()
                    .Where(c => c.Preco > 10)
                    .Load();





            }


        }





        public static void IncluirPromocao()
        {
            using (var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Queima Total - Agosto 2023";
                var inicio = promocao.DataInicio = new DateTime(2023, 1, 1);
                promocao.DataTermino = inicio.AddDays(30);


                var produtos = contexto.Produtos.Where(p => p.Categoria == "Bebidas").ToList();

                foreach (var item in produtos)
                {
                    promocao.IncluirProdutos(item);
                }

                //contexto.Promocoes.Add(promocao);
                //contexto.SaveChanges();

            }

        }

        public static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            foreach (var entity in entries)
            {
                Console.WriteLine(entity.Entity.ToString() + " - " + entity.State);
            }
        }

        public static void UmParaUm()
        {
            var cliente = new Cliente();
            cliente.Nome = "Camila";
            cliente.EndercoDeEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro = "Rua dos anjos",
                Complemento = "Sobrado",
                Bairro = "Centro",
                Cidade = "SP"
            };

            //contexto.Clientes.Add(cliente);
            //contexto.SaveChanges();
        }

        public static void ExibeProdutosDaPromocao()
        {
            using (var context2 = new LojaContext())
            {


                var promocao = context2
                    .Promocoes
                    .Include(p => p.Produtos)
                    .ThenInclude(pp => pp.Produto)
                    .FirstOrDefault();


                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }

            }
        }



    }
}
