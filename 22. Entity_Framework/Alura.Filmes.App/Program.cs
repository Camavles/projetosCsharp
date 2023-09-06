using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var contexto = new AluraFilmesContexto())
            {
                
                foreach(var idioma in contexto.Idiomas)
                {
                    Console.WriteLine(idioma);
                }
    

            }


           
        }

        public static void PrimeiraParte()
        {
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
            }
        }


    }

}