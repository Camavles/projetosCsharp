using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario; // casting --> vai desconsiderar a parte com vírgula
        Console.WriteLine(salarioInteiro);
        
        long x = 2000000000000000000;
        Console.WriteLine(x);

        short y = 1500;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}