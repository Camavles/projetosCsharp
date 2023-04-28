using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 14 - Encademento de For/Break");
        //*
        //**
        //***
        //****

        

        for(int linha = 0; linha < 10; linha++)
        {
            for(int coluna = 0; coluna <= linha; coluna++)
            {
                Console.Write("*"); // nesse caso usei o Write para ele não pular a linha;
            }
            Console.WriteLine();
        }




        // Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.


        for(int i = 1; i <= 100; i++)
        {
           if(i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}