using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 12 - For");


        double investimento = 1000;
        //int mes = 1;

        for(int mes = 1; mes <= 12 ; mes++)
        {
            investimento *= 0.005;
            Console.WriteLine(investimento);
        }

        Console.WriteLine("Aperte enter para sair");
        Console.ReadLine();

    }
}
