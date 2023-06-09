using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Linq;


//Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();

// ARRAY

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


TestaLista();
void TestaLista()
{
    // a ideia é criar uma classe com métodos que possam manipular a minha array, já que a manipulação dela por si só não é algo intutitivo;


    ListaDeContaCorrente lista = new ListaDeContaCorrente();
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


    for(int i = 0; i < lista.Tamanho; i++)
    {
        Console.WriteLine($"Item: {i} / Conta: {lista[i].Conta} / Agência: {lista[i].Numero_agencia} ");
    }


}