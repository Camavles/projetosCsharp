//using bytebank_ATENDIMENTO.bytebank.Atendimento;
//Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();


//TestarArrayInt();
//TestaBuscarPalavra();
using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using System;
using System.Collections;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;



#region // parte 1 a 4 - Arrays
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


    // *****************************************************    2ª PARTE: Array de Strings;    **************************************************


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

    // ****************************************************   3ª PARTE: classe Array;   *******************************************

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


    //TestaArrayContas();

    //void TestaArrayContas()
    //{
    //    ContaCorrente[] listaDeContas = new ContaCorrente[]
    //    {
    //        new ContaCorrente(14, "5654-A"),
    //        new ContaCorrente(15, "5755-B"),
    //        new ContaCorrente(16, "5856-C")
    //    };




    //    for (int i = 0; i < listaDeContas.Length; i++)
    //    {
    //        // outra forma: ContaCorrente contaAtual = listaDeContas[i];
    //        Console.WriteLine($"Agência {listaDeContas[i].Conta}, Conta: {listaDeContas[i].Numero_agencia}");
    //        //Console.WriteLine($"Saldo {listaDeContas[i].Titular.Nome}");
    //        //listaDeContas[i].Saldo += 40;
    //        //Console.WriteLine(listaDeContas[i].Saldo);
    //    }

    //    //isso não é uma lista e sim, UMA CLASSE COM MÉTODOS
    //    ListaDeContasCorrentes lista = new ListaDeContasCorrentes();
    //    lista.Adicionar(new ContaCorrente(14, "5654-A"));
    //    lista.Adicionar(new ContaCorrente(15, "5755-B"));
    //    lista.Adicionar(new ContaCorrente(16, "5856-C"));
    //    lista.Adicionar(new ContaCorrente(17, "5957-D"));
    //    lista.Adicionar(new ContaCorrente(18, "6058-E"));
    //    lista.Adicionar(new ContaCorrente(19, "6059-F"));


    //    //classe ListaDeContas
    //    // saldo: criar uma lista fora do método com os objetos ContaCorrente;
    //    //no método fazer um for para setar os saldos das contas;
    //    //fazer um sort para ordenar as posições do array;


    //    var contaDooAndre = new ContaCorrente(20, "1010-X");
    //    lista.Adicionar(contaDooAndre);
    //    //lista.ExibirLista();
    //    //Console.WriteLine("======");
    //    //lista.Remover(contaDooAndre);
    //    //lista.ExibirLista();

    //    for (int i = 0; i < lista.Tamanho; i++)
    //    {
    //        ContaCorrente conta = lista[i]; /*lista.RecuperarContaNoIndice(i);*/
    //        Console.WriteLine($"índice [{i}] =  {conta.Conta} / {conta.Numero_agencia}");
    //    }

    //}
    
}

#endregion




ArrayList _listaDeContas = new ArrayList();

//AtendimentoCliente();

void AtendimentoCliente()
{
    char opcao = '0';
    while (opcao !='6')
    {

        Console.Clear();
        Console.WriteLine("=============================");
        Console.WriteLine("===      ATENDIMENTO      ===");
        Console.WriteLine("=== 1 - Cadastrar Contas  ===");
        Console.WriteLine("=== 2 - Listar Contas     ===");
        Console.WriteLine("=== 3 - Remover Contas    ===");
        Console.WriteLine("=== 4 - Ordenar Contas    ===");
        Console.WriteLine("=== 5 - Pesquisar Contas  ===");
        Console.WriteLine("=== 6 - Sair do Sistema   ===");
        Console.WriteLine("=============================");
        Console.WriteLine("\n\n");
        Console.WriteLine("Digite a opção desejada: ");
        opcao = Console.ReadLine()[0];
        switch(opcao)
        {
            case '1': CadastrarConta();
                break;
            case '2': ListarContas();
                break;
            default:
                Console.WriteLine("Opção não implementada!");
                break;
        }

    }
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if(_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in _listaDeContas) 
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Saldo da Conta : " + item.Saldo);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
    
}

void CadastrarConta()
{
    void CadastrarConta()
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===   CADASTRO DE CONTAS    ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.WriteLine("===  Informe dados da conta ===");
        Console.Write("Número da conta: ");
        string numeroConta = Console.ReadLine();

        Console.Write("Número da Agência: ");
        int numeroAgencia = int.Parse(Console.ReadLine());

        ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

        Console.Write("Informe o saldo inicial: ");
        conta.Saldo = double.Parse(Console.ReadLine());

        Console.Write("Infome nome do Titular: ");
        conta.Titular.Nome = Console.ReadLine();

        Console.Write("Infome CPF do Titular: ");
        conta.Titular.Cpf = Console.ReadLine();

        Console.Write("Infome Profissão do Titular: ");
        conta.Titular.Profissao = Console.ReadLine();

        _listaDeContas.Add(conta);
        Console.WriteLine("... Conta cadastrada com sucesso! ...");
        Console.ReadKey();
    }
}


