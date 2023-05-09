//using bytebank_ATENDIMENTO.bytebank.Atendimento;
//Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();


//TestarArrayInt();
//TestaBuscarPalavra();
using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

// 1º primeira parte
#region
void TestarArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    double acumulador = 0;
    ;

    for (int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine($" Indíce {i} = {idades[i]}");
        acumulador += idades[i];

    }

    double media = acumulador / idades.Length;
    Console.WriteLine("A média é: " + media);
}


void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1} Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca)) // como já estou denrto da array, posso usar um método de string
        {
            Console.WriteLine("Palavra encontrada = " + busca);
            break;

        }
    }

}

// classe array;
//Array amostra = Array.CreateInstance(typeof(double), 5);
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(6.9, 4);

//TestaMediana(amostra);
void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array está vazio ou nulo!");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
         numerosOrdenados[meio] + numerosOrdenados[meio - 1] / 2;
    Console.WriteLine($"Com base na amostra a media é = {mediana}");

}


//int[] valores = { 10, 58, 36, 47 };

//for(int i = 0; i < valores.Length; i++)
//{
//    Console.WriteLine(valores[i]);
//}



Array valores = Array.CreateInstance(typeof(double), 5);
valores.SetValue(1.5, 0);
valores.SetValue(2.2, 1);
valores.SetValue(3.3, 2);
valores.SetValue(4.4, 3);
valores.SetValue(5.5, 4);

//TestaMedia(valores);

void TestaMedia(Array array)
{
    double acumulador = 0;

    foreach(double item in array)
    {
        acumulador += item;
    }

    double media = acumulador / array.Length;
    Console.WriteLine("Está é a média = " + media);
}



// formas de criar uma array:
// tipo1:
//int[] idades = new int[4];
//idades[0] = 20;
//idades[1] = 30;
//idades[2] = 40;
//idades[3] = 50;

////tipo 2:
//Array palavras = Array.CreateInstance(typeof(string), 4);
//palavras.SetValue("Olá", 0); // preciso passar o valor e a posição;
//palavras.SetValue("meu", 1);
//palavras.SetValue("nome", 2);
//palavras.SetValue("é", 3);
//palavras.SetValue("Camila", 4);

//// tipo 3:
//string[] frases = { "camila", "é", "inteligênte!" };
//int[] numeros = { 1, 2, 3, 4 };

#endregion


// 2º parte

void TestaAraayContasCorrentes()
{

    //ContaCorrente[] listaContas = new ContaCorrente[]
    //{
    //    new ContaCorrente(874, "5456-A"),
    //    new ContaCorrente(874, "5557-B"),
    //    new ContaCorrente(874, "5658-C")
    //};

    //for(int i = 0; i < listaContas.Length; i++)
    //{
    //    // esse ContaCorrente só define o tipo da variável contaAtual; ou seja, um objeto que recebe essa lista 
    //    ContaCorrente contaAtual = listaContas[i];
    //    Console.WriteLine($"Indíce {i} - Conta {contaAtual.Conta}");

    //    // outra possibilidade
    //    //Console.WriteLine($"Número da Conta - {listaContas[i].Conta}");
        
    //}

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5456-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "5557-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "5658-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "2255-D"));
    listaDeContas.Adicionar(new ContaCorrente(874, "2255-D"));
    listaDeContas.Adicionar(new ContaCorrente(874, "2255-D"));


}

//TestaAraayContasCorrentes();


TestaSaldo();

void TestaSaldo()
{
    ListaDeContasCorrentes lista = new ListaDeContasCorrentes();
    

}