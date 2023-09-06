using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            using(var contexto = new LojaContext())
            {
                var promocao = contexto
                    .Promocoes
                    .Include(p => p.Produtos)
                    .ThenInclude(pp => pp.Produto)
                    .FirstOrDefault();


                Console.WriteLine("=====================");
                foreach(var produto in promocao.Produtos)
                {
                    Console.WriteLine(produto.Produto);
                }
                    
            }
          

        }

        private static void IncluirPromocao()
        {
            using (var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Queima Total Setembro 2023";
                promocao.DataInicio = new DateTime(2023, 9, 4);
                promocao.DataTermino = promocao.DataInicio.AddDays(26);

                //Console.WriteLine(promocao);

                var produtos = contexto
                    .Produtos
                    .Where(c => c.Categoria == "Bebidas")
                    .ToList();

                foreach (var produto in produtos)
                {
                    promocao.IncluirProduto(produto);
                    //Console.WriteLine(produto);
                }
                //contexto.Promocoes.Add(promocao);
                //contexto.SaveChanges();
            }
        }

        private static void UmParaUm()
        {
            var cliente = new Cliente();
            cliente.Nome = "Camila";
            cliente.EnderecoDeEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro = "Rua Feliz",
                Complemento = "Sobrado",
                Bairro = "Centro",
                Cidade = "Rosas"
            };

            using (var contexto = new LojaContext())
            {
                //contexto.Clientes.Add(cliente);
                //contexto.SaveChanges();
            }
        }

        private static void MuitosParaMuitos()
        {
            // JOINS
            var p1 = new Produto() { Nome = "Suco de Laranja", Categoria = "Bebidas", PrecoUnitario = 8.79, Unidade = "Litros" };
            var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 12.45, Unidade = "Gramas" };
            var p3 = new Produto() { Nome = "Macarrão", Categoria = "Alimentos", PrecoUnitario = 4.23, Unidade = "Gramas" };


            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);
            promocaoDePascoa.IncluirProduto(p1);
            promocaoDePascoa.IncluirProduto(p2);
            promocaoDePascoa.IncluirProduto(p3);

            //RELACIONAMENTOS
            //compra de 6 pães

            var pao = new Produto();
            pao.Nome = "Pão Francês";
            pao.PrecoUnitario = 0.40;
            pao.Unidade = "Unidade";
            pao.Categoria = "Padaria";

            var compra = new Compra();

            compra.Quantidade = 6;
            compra.Produto = pao;
            compra.Preco = pao.PrecoUnitario * compra.Quantidade;

            using (var contexto = new LojaContext())
            {
                //contexto.Promocoes.Add(promocaoDePascoa);
                //contexto.SaveChanges();
                //contexto.Compras.Add(compra);
                //contexto.SaveChanges();


                //var promocao = contexto.Promocoes.Find(1);
                //contexto.Promocoes.Remove(promocao);
                //contexto.SaveChanges();
            }
        }

        private static void ResumoDeTodasOperacoes()
        {
            // métodos que estavam na Main:

            // TERCEIRA PARTE: criando loggers, logando SQL na aplicação

            //using (var contexto = new LojaContext())
            //{
            //    var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
            //    var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            //    loggerFactory.AddProvider(SqlLoggerProvider.Create());
            //}




            // SEGUNDA PARTE 
            //using (var contexto = new LojaContext())
            //{
            //    var produtos = contexto.Produtos.ToList();

            //    foreach (var produto in produtos)
            //    {
            //        Console.WriteLine(produto);
            //    }

            //    var p1 = contexto.Produtos.First();
            //    p1.Nome = "Novo Filme";

            //    Console.WriteLine("=============");

            //    foreach (var produto in produtos)
            //    {
            //        Console.WriteLine(produto);
            //    }

            //    // o entries guarda uma lista de entidades 
            //    Console.WriteLine("=============");
            //    foreach (var entidade in contexto.ChangeTracker.Entries())
            //    {
            //        //Console.WriteLine(entidade.Entity); // minha entidade

            //        Console.WriteLine(entidade.State); // meu estado
            //    }
            //}


            // PRIMEIRA PARTE
            //GravarUsandoAdoNet();
            //GravarUsandoEntity();
            // RecuperarProdutos();
            //RemoverProduto();
            // AtualizarProduto();
            // RecuperarProdutos();


        }
        // primeira parte
      
        //Atualizando Produtos
        private static void AtualizarProduto()
    {
        using (var contexto = new ProdutoDAOEntity())
        {
            //IList<Produto> produtosList = contexto.Produtos.ToList();

            //for (int i = 0; i < produtosList.Count; i++)
            //{
            //    produtosList[i].Id = i + 1;
            //    contexto.Produtos.Update(produtosList[i]);
            //}
            //contexto.SaveChanges();

            Produto produto = contexto.Produtos().First();
            produto.Nome = "Cassino Royale";
            contexto.Atualizar(produto);

        }
    }


        //Recuperando Proddutos
        private static void RecuperarProdutos()
    {
        using (var contexto = new ProdutoDAOEntity())
        {
            IList<Produto> produtos = contexto.Produtos();

            foreach (var produto in produtos)
            {
                Console.WriteLine(produto.Nome);
            }
        }
    }


         // Gravando
        private static void GravarUsandoEntity()
    {
        Produto p = new Produto();
        p.Nome = "Harry Potter e a Ordem da Fênix";
        p.Categoria = "Livros";
        p.PrecoUnitario = 19.89;


        Produto p2 = new Produto();
        p2.Nome = "Senhor dos Anéis 1";
        p2.Categoria = "Livros";
        p2.PrecoUnitario = 19.89;

        Produto p3 = new Produto();
        p3.Nome = "O Monge e o Executivo";
        p3.Categoria = "Livros";
        p3.PrecoUnitario = 19.89;

        using (var contexto = new ProdutoDAOEntity())
        {
            //contexto.Produtos.Add(p);
            contexto.Adicionar(p);
            //contexto.SaveChanges();
        }
    }


        // Removendo produtos;
        private static void RemoverProduto()
    {
        using (var contexto = new ProdutoDAOEntity())
        {
            IList<Produto> produtos = contexto.Produtos();

            foreach (var produto in produtos)
            {
                contexto.Remover(produto);
            }
            //contexto.SaveChanges();

        }
    }

        //private static void GravarUsandoAdoNet()
        //{
        //    Produto p = new Produto();
        //    p.Nome = "Harry Potter e a Ordem da Fênix";
        //    p.Categoria = "Livros";
        //    p.Preco = 19.89;

        //    using (var repo = new ProdutoDAO())
        //    {
        //        repo.Adicionar(p);
        //    }
        //}
       

    }




}
