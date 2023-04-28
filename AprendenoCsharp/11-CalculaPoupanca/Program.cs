using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 11 - While");


        double investimento = 1000;


        // rendimento de 0.005 ou 0.5%


        //investimento += investimento * 0.005;
        // Console.WriteLine(investimento);

        int mes = 1;
        while (mes <= 12)
        {
            investimento += investimento * 0.005;
            Console.WriteLine("No mês " + mes +  " vc tem R$ " + investimento);
            // mes = mes + 1;
            mes++;
        }



        Console.WriteLine("Aperte enter para sair");
        Console.ReadLine();

    }
}
