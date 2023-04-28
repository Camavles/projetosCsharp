using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 8");

        int idade = 16;
        int qtdPessoas = 2;
        bool grupo = true;

        // || ou && e
        if (idade >= 18 || grupo == true)
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