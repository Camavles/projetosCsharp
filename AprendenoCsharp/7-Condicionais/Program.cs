using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7");

        int idade = 16;
        int qtdPessoas = 2;

        if (idade >= 18 || qtdPessoas >= 1)
        {
            Console.WriteLine("Você pode entrar");
        }
        else
        {
            Console.WriteLine("Não pode entrar");
        }


        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}