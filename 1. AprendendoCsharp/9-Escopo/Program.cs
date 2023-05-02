using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 9");

        int idade = 18;
        bool acompanhado = true;

        string textoAdicional;

        if (idade >= 18 || acompanhado == true)
        {
            textoAdicional = "Você pode entar";
            Console.WriteLine(textoAdicional);
        } 
        else
        {
            textoAdicional = "Você não pode entrar";
            Console.WriteLine(textoAdicional);
        }

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}