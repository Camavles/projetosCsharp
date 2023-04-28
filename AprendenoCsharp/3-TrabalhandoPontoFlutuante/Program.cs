using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 2300.15;

        double idade;
        idade = 7.0 / 5; // para não perder o valor double ele utiliza a casa depois da vírgula no resultado

        Console.WriteLine(salario);
        Console.WriteLine(idade);
        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }

}