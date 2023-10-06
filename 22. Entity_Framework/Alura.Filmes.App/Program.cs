using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {


            using(var contexto = new AluraFilmesContexto())
            {
                // é possível aplicar inserts, updates e deletes no banco também;
                var sql = "INSERT INTO language (name) VALUES ('Coreano'), ('Yorubá')";

               // var retorno = contexto.Database.ExecuteSqlCommand(sql); // aqui tem retorno que é a quantidade de linahs afetadas;
              //  Console.WriteLine($"A quantidade de linhas afetadas é {retorno}");
              // o In é o mesmo que fazer um || ou;
                var deleteSql = "DELETE FROM Language Where name In ('Coreano', 'Yorubá' )";

                var retornoDelete = contexto.Database.ExecuteSqlCommand(deleteSql);

                Console.WriteLine($"O retorno de linhas afetadas {retornoDelete}");


                /*
                 //executando uma procedure: precisa fazer isso no SQL
                declare @total int
                execute total_actors_from_given_category 'Action', @total OUT
                select @total
                 */
            }



        }


        public static void AplicandoComandosSQLNoBanco()
        {

        }

        public static void ExecutandoProcedures()
        {
            using (var contexto = new AluraFilmesContexto())
            {
                var categ = "Action";

                var paramCateg = new SqlParameter("category_name", categ);
                var paramTotal = new SqlParameter
                {
                    ParameterName = @"total_actors",
                    Size = 4,
                    Direction = System.Data.ParameterDirection.Output
                };


                // essa propriedade do entity é a que executa a procedure
                // esses comandos são enviados para o banco, não dá para executar select;
                contexto.Database.ExecuteSqlCommand(" total_actors_from_given_category @category_name, @total_actors OUT",
                    paramCateg,
                    paramTotal);


                Console.WriteLine($"O total de atores na categora é {categ} é de {paramTotal.Value}");
            }
        }
        public static void PrimeiraParte()
        {

            // A partir do Entity 2.1 já exite a opção HasConvertion:
            //select * from actor

            using (var contexto = new AluraFilmesContexto())
            {


                var filme = contexto.Filmes
                    .Include(c => c.Atores)
                    .ThenInclude(fa => fa.Ator)
                    .First();

                Console.WriteLine(filme);


                foreach (var ator in filme.Atores)
                {
                    Console.WriteLine(ator.Ator);
                }

                var atores = contexto.Atores.OrderByDescending(a => EF.Property<DateTime>(a, "last_update")).Take(10);


                foreach (var ator in atores)
                {
                    Console.WriteLine(ator);
                }

                //Console.WriteLine(ator);
                //Console.WriteLine(contexto.Entry(ator).Property("last_update").CurrentValue);


                //var idiomas = contexto.Idiomas.Include(i => i.FilmesFalados);



                //foreach(var idioma in idiomas)
                //{
                //    Console.WriteLine(idioma);
                //}


                //var conversao = ClassificacaoIndicativa.MaioresQue18;
                //Console.WriteLine(conversao.ParaString());




                //var filme = new Filme();
                //filme.Titulo = "Senhor dos Aneis";
                //filme.Duracao = 120;
                //filme.AnoDeLancamento = "2000";
                //filme.Classificacao = ClassificacaoIndicativa.Livre;
                //filme.Descricao = "Um anel é perdido e depois recuperado";
                //filme.IdiomaOriginal = contexto.Idiomas.First();
                //contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;



                //contexto.Filmes.Add(filme);
                //contexto.SaveChanges();


                //var cliente = new Cliente()
                //{
                //    PrimeiroNome = "Camis",
                //    UltimoNome = "Silvs",
                //    Email = "camis.silvs@gmail.com",
                //    Ativo = true 
                //};

                //contexto.Clientes.Add(cliente);
                //contexto.SaveChanges();


                //Console.WriteLine(contexto.Clientes.First()); 



                // using (var contexto = new AluraFilmesContexto())
                //{

                //    //antes de usar uma view

                //    //var sql = @"select a.*
                //    //            from actor a 
                //    //             inner join 
                //    //            (select top 5 a.actor_id, count(*) as total
                //    //            from actor a 
                //    //             inner join film_actor fa on a.actor_id = fa.actor_id
                //    //            group by a.actor_id
                //    //            order by total desc) filmes on filmes.actor_id = a.actor_id";

                //    //usando view
                //    var sql = @"select a.* from actor a
                //                    inner join top5_most_starred_actors filmes on filmes.actor_id = a.ctor_id";

                //    // passando o SQL diretamente:
                //    var atoresMaisAtuantes = contexto.Atores
                //        .FromSql(sql)
                //        .Include(a => a.Filmes);



                //    //var atoresMaisAtuantes = contexto
                //    //    .Atores
                //    //    .Include(c => c.Filmes)
                //    //    .OrderByDescending(c => c.Filmes.Count)
                //    //    .Take(5);

                //    foreach (var ator in atoresMaisAtuantes)
                //    {
                //        Console.WriteLine($"O ator {ator.PrimeiroNome} atuou em {ator.Filmes.Count} ");
                //    }


            }
        }


    }

}