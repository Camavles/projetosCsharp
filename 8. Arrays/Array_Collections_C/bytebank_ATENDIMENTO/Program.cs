using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();

// **************** ARRAYS **************

//TestaArrayInt();

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array: {idades.Length}");

    int acumulador = 0;
    double media = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        acumulador += idades[i];
        Console.WriteLine(idades[i]);
    }

    media = acumulador / idades.Length;
    Console.WriteLine($"Esta é a média: {media}");
}



//TestaArrayString();
void TestaArrayString()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1} Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();

    }


    Console.WriteLine("Digite a palavra a ser buscada: ");
    var busca = Console.ReadLine();

    foreach (var palavra in arrayDePalavras)
    {
        //palavra.Equals();

        if (palavra == busca)
        {
            Console.WriteLine($"Palavra encontrada! {busca}");
            break;
        }

    }
}


//ClasseArray();
void ClasseArray()
{
    // outra possibilidade: Array pesquisa = new double [6];
    Array amostra = Array.CreateInstance(typeof(double), 5);
    // método
    amostra.SetValue(5.9, 0);
    amostra.SetValue(1.8, 1);
    amostra.SetValue(7.1, 2);
    amostra.SetValue(10, 3);
    amostra.SetValue(6.9, 4);

    TestaMetodo(amostra);

    void TestaMetodo(Array array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("Array não pode ser nulo ou vazio!");
        }

        // fiz o cast
        double[] numerosOrdenados = (double[])array.Clone();
        Array.Sort(numerosOrdenados);

        int tamanho = numerosOrdenados.Length;
        int meio = tamanho / 2;
        double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
        Console.WriteLine($"Com base na amostra a mediana = {mediana}");

    }
}



TestaArrayContasCorrentes();
void TestaArrayContasCorrentes()
{
    //crio uma classe para encapsular o comportamento da minha lista
    //ContaCorrente[] listaDeContas = new ContaCorrente[]
    //{
    //    new ContaCorrente(14, "5654-A"),
    //    new ContaCorrente(15, "5755-B"),
    //    new ContaCorrente(16, "5856-C")

    //};

    //for(int  i = 0; i < listaDeContas.Length; i++)
    //{
    //    Console.WriteLine($"índice {i} - Conta {listaDeContas[i]}");
    //}

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(14, "5654-A"));
    listaDeContas.Adicionar(new ContaCorrente(15, "5755-B"));
    listaDeContas.Adicionar(new ContaCorrente(16, "5856-C"));
       

    
}



//TestaSolucao();
void TestaSolucao()
{
    Array contas = new ContaCorrente[3];
    contas.SetValue(new ContaCorrente(14, "5654-A"), 0);
    contas.SetValue(new ContaCorrente(15, "5755-B"), 1);
    contas.SetValue(new ContaCorrente(16, "5856-C"), 2);

    Imprimir(contas);

    // funcionou!!!
    void Imprimir(Array array)
    {

        if (array.Length == 0) { Console.WriteLine("Array não pode ser nulo!!"); };

        var novaArray = (ContaCorrente[])array;

        var arrayOrganizada = (double[])array;

        for (int i = 0; i < array.Length; i++)
        {

            novaArray[i].Saldo = (novaArray[i].Saldo + 20) / (i + 1);

            for (int j = 0; j < arrayOrganizada.Length; j++)
            {
                arrayOrganizada[j] = novaArray[i].Saldo;
            }

        }



        foreach (var conta in arrayOrganizada)
        {
            Console.WriteLine(conta);
        }






    }





}