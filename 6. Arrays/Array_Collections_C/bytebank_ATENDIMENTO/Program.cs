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



TestarMetodos();
void TestarMetodos()
{
    // ***********************************************   1ª PARTE: Montando um array;   ************************************************

    //int[] idades = new int[5];
    //idades[0] = 30;
    //idades[1] = 40;
    //idades[2] = 17;
    //idades[3] = 21;
    //idades[4] = 18;

    //Console.WriteLine($"Essa é a extensão da sua lista: {idades.Length}");

    //int acumulador = 0;
    //double media;

    //for(int i = 0; i < idades.Length; i++)
    //{
    //    Console.WriteLine($"Idade = {idades[i]} Indíce = {i} ");
    //    acumulador += idades[i];
    //}

    //media = acumulador / idades.Length;
    //Console.WriteLine($"Sua média é {media}");


    // *********************************************    2ª PARTE: Array de Strings;    ************************************************


    //string[] arrayDePalavras = new string[5];

    //for(int i = 0; i < arrayDePalavras.Length; i++)
    //{
    //    Console.Write("Informe uma palavra: ");
    //    arrayDePalavras[i] = Console.ReadLine();
    //    //Console.ReadLine() --> retorna uma string
    //}


    //Console.WriteLine("Digite uma palavra a ser buscada!");
    //var busca =  Console.ReadLine(); // bota dentro da minha variavel a palavra que eu digitei;

    //foreach(string item in arrayDePalavras)
    //{
    //    if(item.Equals(busca))
    //    {
    //        Console.WriteLine($"Palavra encontrada = {busca} ");
    //        break;
    //    }
    //}

    // ************************************   3ª PARTE: classe Array;   *************************************

    /* Poderia fazer:
     * double[] amostra = new double[5];
     * amostra[0] = 5.9;
     * amostra[1] = 1.8;
     * 
     * ou 
     * double[] amostra = new double[5];
     * amostra.SetValue(5.9, 0);
     * amostra.SetValue(1.8, 1);
     * 
    
     */
    //Array amostra = Array.CreateInstance(typeof(double), 5);
    //amostra.SetValue(5.9, 0);
    //amostra.SetValue(1.8, 1);
    //amostra.SetValue(7.1, 2);
    //amostra.SetValue(10, 3);
    //amostra.SetValue(6.9, 4);

    //TestaMediana(amostra);
    //void TestaMediana(Array array)
    //{
    //    if(array == null || array.Length == 0)
    //    {
    //        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo!");
    //    }

    //    //FIZ O CAST PARA TRANSFORMAR ESSA ARRAY EM DOUBLE JÁ QUE ESTAVA VINDO OBJECT
    //    double[] numerosOrdem = (double[])array.Clone();


    //    // Chamo a classe e o método e passo a minha array;
    //    Array.Sort(numerosOrdem); // modifica a array;

    //    int tamanho = numerosOrdem.Length;
    //    int meio = tamanho / 2;
    //    // ?true 
    //    // : else
    //    double mediana = (tamanho % 2 != 0) ? numerosOrdem[meio] : (numerosOrdem[meio] + numerosOrdem[meio - 1]) / 2;
    //    Console.WriteLine($"Com base na amostra a mediana é = {mediana}");


    //}

    //******************************************************** 4ª PARTE:  ARRAY DE OBJETOS; *****************************************************
    // Sempre tomar cuidado em percorrer a array por completo
    

    TestaArrayContas();

    void TestaArrayContas()
    {
        ContaCorrente[] listaDeContas = new ContaCorrente[]
        {
            new ContaCorrente(14, "5654-A"),
            new ContaCorrente(15, "5755-B"),
            new ContaCorrente(16, "5856-C")
        };


        for(int i = 0; i < listaDeContas.Length; i++)
        {
            // outra forma: ContaCorrente contaAtual = listaDeContas[i];
            Console.WriteLine($"Agência {listaDeContas[i].Conta}, Conta: {listaDeContas[i].Numero_agencia} ");
        }
       
        // classe ListaDeContas
    }


}

