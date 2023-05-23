using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
//using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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



//TestaArrayContasCorrentes();
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
    var contadoAndre = new ContaCorrente(54, "1010-X");
    listaDeContas.Adicionar(contadoAndre);


    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Índice [{i}] = {conta.Conta} / {conta.Numero_agencia}");
    }

    Console.WriteLine(listaDeContas[0]);



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


// ************************* ArrayLIST | List Coleções ********************************

//ArrayList
//ArrayList _listaDeContas = new ArrayList() {
//    new ContaCorrente(95, "123456-X") {Saldo=100},
//    new ContaCorrente(95, "951258-X") {Saldo=200},
//    new ContaCorrente(94, "987321-W") {Saldo=60}
//};
//List
// o list nos ajuda a manter a segurança no código quando eu digo que tipo de objeto eu quero receber na lista;
List<ContaCorrente> _listaDeContas = new List<ContaCorrente>() {
    new ContaCorrente(95, "123456-X") {Saldo=100},
    new ContaCorrente(94, "987321-W") {Saldo=60},
    new ContaCorrente(95, "951258-X") {Saldo=200}
};




AtendimentoCliente();
void AtendimentoCliente()
{

    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do Sistema      ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            // desse retorno eu quero a primeira posição do que foi digitado

            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }
           
            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverConta();
                    break;
                case '4':
                    OrdenarContas();
                    break;
                default:
                    Console.WriteLine("Opcao não implementada.");
                    break;
            }
        }

    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }
    
}

void OrdenarContas()
{
    // uma forma de fazer o sort
    //_listaDeContas.Sort((este, outro) => este.Conta.CompareTo(outro.Conta));
    _listaDeContas.Sort();
    Console.WriteLine("Lista de contas ordenadas");
    Console.ReadKey();

}

void RemoverConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===      REMOVER CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Informe o número da Conta: ");
    string numeroConta = Console.ReadLine();
    ContaCorrente conta = null;

    foreach(var item in _listaDeContas)
    {
        if(item.Conta.Equals(numeroConta)) {
            conta = item;
        }
    }
    if(conta != null)
    {
        _listaDeContas.Remove(conta);
        Console.WriteLine("Conta Removida da Lista!");
    }
    else
    {
        Console.WriteLine("Conta para remoção não encontrada!");
    }
    Console.ReadKey();
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");

    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("Não há contas cadastradas!");
        Console.ReadKey();
        return;
    }
    foreach (var conta in _listaDeContas)
    {
        Console.WriteLine(conta);
        Console.ReadKey();
    }
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    // pegando o valor e transformando em um int
    int numeroAgencia = int.Parse(Console.ReadLine());

    Console.Write("Informe o saldo inicial: ");


    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Informe o nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Informa o  CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Innforme a Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);

    Console.WriteLine("Conta cadastrada com sucesso!");
    Console.ReadKey();
}


//TestandoMetodosList();

void TestandoMetodosList()
{
    List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
    {
        new ContaCorrente(10, "1010-X"),
        new ContaCorrente(20, "2020-Y"),
        new ContaCorrente(30, "3030-Z")
    };

    List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
    {
        new ContaCorrente(40, "4040-A"),
        new ContaCorrente(50, "5050-B"),
        new ContaCorrente(60, "6060-C")
    };

    // MÉTODOS:
    // AddRange() --> pega uma lista e adiciona na outra
    _listaDeContas2.AddRange(_listaDeContas3);
    _listaDeContas2.Reverse();

    for (int i = 0; i < _listaDeContas2.Count; i++)
    {
        Console.WriteLine($"índice: [{i}], Conta: {_listaDeContas2[i].Conta}");
    }

    Console.WriteLine("\n\n"); // quebrar duas linhas

    //GetRange(inicio, fim)-- > faz uma cópia dos elementos da lista
    var range = _listaDeContas3.GetRange(0, 1);
    for (int i = 0; i < range.Count; i++)
    {
        Console.WriteLine($"índice: [{i}], Conta: {_listaDeContas2[i].Conta}");
    }

    Console.WriteLine("\n\n");

    _listaDeContas3.Clear();
    for (int i = 0; i < _listaDeContas3.Count; i++)
    {
        Console.WriteLine($"índice: [{i}], Conta: {_listaDeContas2[i].Conta}");
    }


}

//Desafio();
void Desafio()
{
    List<string> nomesDosEscolhidos = new List<string>()
    {
        "Bruce Wayne",
        "Carlos Vilagran",
        "Richard Grayson",
        "Bob Kane",
        "Will Farrel",
        "Lois Lane",
        "General Welling",
        "Perla Letícia",
        "Uxas",
        "Diana Prince",
        "Elisabeth Romanova",
        "Anakin Wayne"
    };


    //TestaDesafio(nomesDosEscolhidos);

    void TestaDesafio(List<string> lista)
    {
        Console.WriteLine("Digite o nome que deseja buscar: ");
        var busca = Console.ReadLine();

        if (lista.Count() == 0 || lista.Count == null)
        {
            Console.WriteLine("Lista não pode ser nula ou vazia");
        }

        foreach (var item in lista)
        {
            if (item.Equals(busca))
            {
                Console.WriteLine($"Nome encontrado = {busca}");
                break;
            }
        }



    }

}



