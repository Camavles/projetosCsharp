using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario = 5600.20;
        string texto;

        if(salario >= 1900.0 && salario <= 2800.0)
        {
            texto = "Pode deduzir R$142";
            Console.WriteLine(texto);
        }
        else
        if(salario >= 2800.01 && salario <= 3751.0)
        {
            texto = "Pode deduzir R$350";
            Console.WriteLine(texto);
        } 
        else
        {
            texto = "Pode deduzir R$636";
            Console.WriteLine(texto);
        }
    }
}
