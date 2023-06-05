
using Revisao;
using Revisao.Gerencidores;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

// Listas Dinâmicas
//Imprimir();
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


// Listas HashSet
//Mostrar();
void Mostrar()
{
    // 1. Listas do tipo HashSet não permitem duplicidade;
    // 2. Não são mantidas em ordem específica, então não consigo percorrer com for;
    // 3. Se eu adicionar um elemento que já existe não adiciona, mas tbm não dá erro. 
    // Vantagens: O Conjunto é mais rápido para buscar elementos; 
    //

    ContaCorrente conta1 = new ContaCorrente(10, "1010-A");
    ContaCorrente conta2 = new ContaCorrente(20, "2020-B");
    ContaCorrente conta3 = new ContaCorrente(30, "3030-C");
    ContaCorrente conta4 = new ContaCorrente(30, "3030-C");


    GerenciadorConta gerenciador = new GerenciadorConta();

    gerenciador.Registrar(conta2);
    gerenciador.Registrar(conta1);
    gerenciador.Registrar(conta3);

    foreach (var conta in gerenciador.ListaDeContasCorrentes)
    {
        Console.WriteLine(conta);
    }

    Console.Clear();

    List<ContaCorrente> copia = new List<ContaCorrente>(gerenciador.ListaDeContasCorrentes);
    copia.Sort((este, outro) =>  este.NumeroAgencia.CompareTo(outro.NumeroAgencia));

    foreach(var conta in copia)
    {
        Console.WriteLine(conta);
    }
  

    // Problema para resolver: Não é possível fazer esse tipo de busca em uma lista HashSet
    // Pq como essa lista utiliza a tabela de espalhamento ela precisa comparar objetos e pegar o HashCode gerado para esse objeto. 
    // Preciso dar um override no Equals() e no GetHashCode | Consultar Class Aluno da ListaDeObjetos; 
    Console.WriteLine(gerenciador.BuscarConta(conta3));

    // eu posso passar a conta direto, porque o que vai ser usado de comparação vai ser o NumeroDaConta
    Console.WriteLine(conta3.Equals(conta4));


    // Preciso revidar os assuntos de lista ligada, pilha e fila.  


}



ImprimirDicionario();
void ImprimirDicionario()
{
    // Imprimentando o dicionario para fazer uma busca prlo numero da conta;



    ContaCorrente conta1 = new ContaCorrente(10, "1010-A");
    ContaCorrente conta2 = new ContaCorrente(20, "2020-B");
    ContaCorrente conta3 = new ContaCorrente(30, "3030-C");
    ContaCorrente conta4 = new ContaCorrente(30, "3030-C");


    GerenciadorConta gerenciador = new GerenciadorConta();

    gerenciador.Registrar(conta2);
    gerenciador.Registrar(conta1);
    gerenciador.Registrar(conta3);

    foreach (var conta in gerenciador.ListaDeContasCorrentes)
    {
        Console.WriteLine(conta);
    }

    var encontra = gerenciador.EncontrarConta("1010-A");
    Console.WriteLine("Conta encontrada: " + encontra);
    // terminar a revisão sobre dicionário; 

}