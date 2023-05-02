using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 13 - Encademento de For");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for(int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001;
        }

        Console.WriteLine("Despois de 5 anos você terá R$ " + investimento);
        Console.WriteLine("Aperte enter para sair");
        Console.ReadLine();

    }
}