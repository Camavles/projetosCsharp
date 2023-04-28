using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5");

        char letra = 'a'; // utilizado para apenas uma letra com aspas simples''
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string frase = "Camilinha estudiosa";
        Console.WriteLine(frase + " " + 2023);

        string listaDeCursos = @"Cursos alura:
        - Go
        - C#
        - Python
        - Java";

        Console.WriteLine(listaDeCursos);

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}