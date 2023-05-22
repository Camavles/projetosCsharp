using System.Security.Cryptography.X509Certificates;

class Program
{
    static Queue<string> pedagio = new Queue<string>();
    private static void Main(string[] args)
    {
        // numa fila, o primeiro que entra é o primeiro que sai;

        Enfileirar("van");
        Enfileirar("kombi");
        Enfileirar("guincho");
        Enfileirar("pickup");
        Desenfileirar(); // não recebe nenhum parametro
        Desenfileirar();
        Desenfileirar();
        Desenfileirar();
        Desenfileirar();
    }

    private static void Desenfileirar()
    {

        if(pedagio.Any())
        {
            if (pedagio.Peek() == "guincho")
            {
                Console.WriteLine("guincho está fazendo o pagamento");
            }



            string veiculo = pedagio.Dequeue();
            Console.WriteLine($"Saiu da fila {veiculo}");
            ImprimirFila();

        }
        
        
    }


    private static void Enfileirar(string veiculo)
    {
        pedagio.Enqueue(veiculo); // enfileirar 
        Console.WriteLine($"Entrou na fila: {veiculo}");
        ImprimirFila();
    }

    private static void ImprimirFila()
    {
        Console.WriteLine("Fila:");

        foreach (var v in pedagio)
        {
            Console.WriteLine(v);
        }
    }
}