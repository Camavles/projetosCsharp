using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 6");

        int idade = 30;
        int idadeAna = idade;


        Console.WriteLine(idadeAna);


        idade = 25;
        //idadeAna = idade; --> nessa linha eu reatribuo de novo

        Console.WriteLine(idadeAna);


        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}