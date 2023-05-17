internal class Navegador
{
    private readonly Stack<string> hitoricoAnterior = new Stack<string>();

    private readonly Stack<string> historicoProximo = new Stack<string>();

    private string atual = "vazia";
    public Navegador()
    {
        Console.WriteLine($"Página atual {atual}");
    }

    internal void Anterior()
    {

        if (this.hitoricoAnterior.Any())
        {
            historicoProximo.Push(atual);
            // pega o próximo elemento de uma pilha
            atual = this.hitoricoAnterior.Pop();
            Console.WriteLine($"Página atual {atual}");
        }
    }


    internal void NavegarPara(string url)
    {
        //adiciona um elemento em uma pilha;
        this.hitoricoAnterior.Push(atual);
        atual = url;

        Console.WriteLine($"Página atual: {atual}");
    }

    internal void Proximo()
    {
        if (historicoProximo.Any())
        {
            this.hitoricoAnterior.Push(atual);
            atual = this.historicoProximo.Pop();
            Console.WriteLine($"Página atual: {atual}");
        }
    }
}