using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Util;
using bytebank_ATENDIMENTO.Extensoes;
using System.Linq;


//Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();

//***************************** ARRAY ***********************************************

void TestaArrayInt()
{
    // tipo[] nome = new tipo[quantidade de posições];
    int[] idades = new int[4];
    idades[0] = 5;
    idades[1] = 10;
    idades[2] = 15;
    idades[3] = 20;

    //Console.WriteLine(idades[1+2]);
    //O valor padrão do inteiro é zero;


    int acumulador = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        acumulador += idades[i];
    }

    int media = acumulador / idades.Length;
    Console.WriteLine(media);
    //Console.WriteLine(idades.Contains(50));

    // sempre prestar atenção aos tipos por referência x tipos por valor;
}


// ARRAY DE OBJETOS CONTACORRENTE
void TestaArrayObj()
{
    ContaCorrente[] contas = new ContaCorrente[] {
 new ContaCorrente(20, "2010-X"),
 new ContaCorrente(21, "2011-Y"),
 new ContaCorrente(22, "2012-Z"),
 new ContaCorrente(23, "2013-W"),
};


    for (int i = 0; i < contas.Length; i++)
    {
        Console.WriteLine(contas[i]);
    }

    // Quando temos um tipo por referência como é o caso de um obj contaCorrente, quando não tem valor nenhum, ele recebe um null, porque não há lugar na memória;
}


//TestaLista();
void TestaLista()
{
    // a ideia é criar uma classe com métodos que possam manipular a minha array, já que a manipulação dela por si só não é algo intutitivo;


    Lista<ContaCorrente> lista = new Lista<ContaCorrente>();
    lista.Adicionar(new ContaCorrente(874, "5679787"));
    lista.Adicionar(new ContaCorrente(874, "5679754"));
    lista.Adicionar(new ContaCorrente(874, "5679745"));
    lista.Adicionar(new ContaCorrente(874, "5679745"));



    //Console.WriteLine(lista.Testar());
    //// forma de alterar apenas um argumento opcional;
    //Console.WriteLine(lista.Testar(numero: 9));



    //ContaCorrente camila = new ContaCorrente(24, "2010");
    //lista.Adicionar(camila);
    //lista.EscreverListaNaTela();

    //Console.WriteLine("Removendo");
    //lista.Remover(camila);
    //lista.EscreverListaNaTela();


    for (int i = 0; i < lista.Tamanho; i++)
    {
        Console.WriteLine($"Item: {i} / Conta: {lista[i].Conta} / Agência: {lista[i].Numero_agencia} ");
    }

    // a última coisa que eu fiz foi transformar a classe Lista em uma lista genérica, usando o T e na hora de invocar eu passo para a minha instância qual é o tipo de lista que eu desejo criar;





}


// ************************** LIST ****************************


//TestaListGenerica();
void TestaListGenerica()
{
    List<int> idades = new List<int>()
    {
        3, 4, 5, 6
    };

    idades.Add(1);
    idades.Add(2);
  
    
    //for(int i = 0; i < idades.Count;i++)
    //{
    //    Console.WriteLine(idades[i]);
    //}

    ListExtensoes.AdicionarVarios(idades, 7, 8, 9, 10);

    //Console.WriteLine("mudando");
    //for (int i = 0; i < idades.Count; i++)
    //{
    //    Console.WriteLine(idades[i]);
    //}

    //problema para resolver: ao invés de criar uma classe de extensões, eu quero que a minha instancia "idades", consiga acessar um método de seja capaz de adicionar vários itens de uma única vez; 
    // resolvido colocando o this no parametro;

    idades.AdicionarVarios(11, 12, 13, 14);
    Console.WriteLine();
    //for (int i = 0; i < idades.Count; i++)
    //{
    //    Console.WriteLine(idades[i]);
    //}


    // aqui eu já tinha transformado o meu método em genérico:

    //List<string> palavras = new List<string>();
    //palavras.AdicionarVarios("Camila", "Isabel", "Lia"); // assim funciona;
    //palavras.AdicionarVarios<string>("Lua", "Mel"); // assim também funciona, mas o <string> é dispensável;
    //foreach (string nome in palavras)
    //{
    //    Console.WriteLine(nome);
    //}

    // quando eu declaro var e dou nome e não atribuo, o compilador dá erro;

    idades.Sort();
    for (int i = 0; i < idades.Count; i++)
    {
        Console.WriteLine(idades[i]);
    }

}



TestaMetodosList();

void TestaMetodosList()
{


    var idades = new List<int>();
    idades.AdicionarVarios(4, 5, 8, 9, 16, 1, 2, 6, 3, 7);
    idades.Sort();

    foreach(var idade in idades)
    {
        Console.WriteLine(idade);
    }

    //var nomes = new List<string>
    //{
    //    "camila", "debora", "lisa", "leila"
    //};

    //foreach (var nome in nomes) {  Console.WriteLine(nome); }
    // usar o método sort() em objetos eu preciso ter uma classe/objeto implementando o IComparable;
    // desvantagem do IComátable é que eu, dev, digo de que forma será organizada a lista; Eu posso implementar uma forma do usuário fazer essa implementação, ou seja, fazer essa escolha sobre a forma como ele quer organizar;
}
