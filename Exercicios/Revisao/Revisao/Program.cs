
using Revisao;
using Revisao.Gerencidores;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Xml;

// Listas Dinâmicas
Imprimir();
void Imprimir()
{
    // Listas dinâmica;
    // modifica o tamanho dinamicamente; 
    ContaCorrente c1 = new ContaCorrente(14, "1010-X");
    ContaCorrente c2 = new ContaCorrente(15, "2020-Y");
    ContaCorrente c3 = new ContaCorrente(16, "3030-Z");


    Cliente camila = new Cliente();
    Cliente rapha = new Cliente();
    Cliente isa = new Cliente();

    camila.Nome = "Camila Alves";
    rapha.Nome = "Raphael Vieira";
    isa.Nome = "Isabel Sena";

    c1.Titular = camila;
    c2.Titular = rapha;
    c3.Titular = isa;

    GerenciadorClientes gerenciador = new GerenciadorClientes();
    gerenciador.Adiciona(camila);
    gerenciador.Adiciona(rapha);
    gerenciador.Adiciona(isa);

    Console.WriteLine("Encontrando alguém na lista");
    Console.WriteLine(gerenciador.Encontra("Camila Alves"));
    Console.WriteLine();
    Console.WriteLine("Buscando por um objeto inexistente:");
    Console.WriteLine(gerenciador.Encontra("Leticia"));

    // Alguns métodos:
    // 1. FirtOrDefault --> é bacana usar pq em caso de não achar a minha busca, ele retorna um null;
    //Console.WriteLine("Digite um nome");
    //var busca = Console.ReadLine();
    //Console.WriteLine(gerenciador.Clientes.FirstOrDefault(cliente => cliente.Nome.Contains(busca))); 
    Console.WriteLine(gerenciador.Clientes.Count());
    // com colchetes eu acesso o indice e nesse caso eu acesso a última pessoa;
    Console.WriteLine(gerenciador.Clientes[gerenciador.Clientes.Count() - 1]);
    Console.WriteLine(gerenciador.Clientes.Last());
    // Além de foreach, eu consigo usar o for nas listas dinâmicas!
    // Fazendo uma cópia e ordenando com Sort();
    // passando como parametro a minha IList
    List<Cliente> copia = new List<Cliente>(gerenciador.Clientes);
    copia.Sort((este, outro) => este.Nome.CompareTo(outro.Nome));

    foreach(var cliente in copia)
    {
        Console.WriteLine(cliente);
    }

}


void Mostrar()
{

}