// See https://aka.ms/new-console-template for more information
using Objetos;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");


TestaMetodo();
void TestaMetodo()
{
    // Objetivo: recuperar informações que estão na URL;
    // Recuperar os argumentos que estão na minha URL
    // os argumentos ficam depois do ponto de interrogação: question mark

    string url = "pagina?argumentos";
    // método que pega uma string dentro de outra; se eu quiser pegar só um caractere tbm dá;
    // esse método aceita como argumento o inicio e o fim do indíce de onde está a string
    // n modifica a string original;
    // A CLASSE STRING NÃO DEIXA MUDAR A STRING QUE EU CRIO, AS OPERAÇÕES PRECISAM SER ARMAZENADAS EM UMA NOVA VARIÁVEL;
    var resultado = url.Substring(7);
    //Console.WriteLine(resultado);

    // Em tempo de execução como descobrir o índice da execução?
    // pegando a interrogação
    var indice = url.IndexOf('?');
    // Console.WriteLine(indice);

    // passando o indice do argumento dinamicamente;
    var argumentos = url.Substring(indice + 1);
    //Console.WriteLine(argumentos);

    //REMOVER
    string testeRemocao = "primeiraParte&parteParaRemover";

    int indexEComercial = testeRemocao.IndexOf('&');

    //O método Remove --> traz como retorno aqui que sobra da string
    string remover = testeRemocao.Remove(indexEComercial);

    //Console.WriteLine(remover);

    // StartsWith EndsWith e Contains

    string urlTeste = "http://www.bytebank.com/cambio";
    //urlTeste.ToUpper();

    var comeca = urlTeste.StartsWith("http://www.bytebank.com/cambio");
    var termina = urlTeste.EndsWith("/cambio");
    var contem = urlTeste.Contains("bytebank");

    //Console.WriteLine(comeca);
    //Console.WriteLine(termina);
    //Console.WriteLine(contem);

    //REGEX
    string padrao = "[0-9]{4,5}-?[0-9]{4}";
    string textoDeTeste = "Meu nome é Camila, me ligue em 946145598";

    // IsMatch retorna um bool;
    var teste = Regex.IsMatch(textoDeTeste, padrao);
    Console.WriteLine(teste);

    //Match retorna o que foi encontrado
    var testa = Regex.Match(textoDeTeste, padrao);
    Console.WriteLine(testa);

    // Classe Object
    // Quando a gente consegue usar um método fora da classe, ele é público;
    // Console.WriteLine("Olá, mundo") 
    // WriteLine é um método público estático;
    // Console é uma classe pública
    // todas as classes derivam de object no C#/ .Net


    Cliente cliente1 = new Cliente();
    cliente1.Nome = "Camila";
    cliente1.CPF = "1234";

    Cliente cliente2 = new Cliente();
    cliente2.Nome = "Cibele";
    cliente2.CPF = "12345";

    Console.WriteLine(cliente1.CPF.Equals(cliente2.CPF));


}



//TestaClasse();

void TestaClasse()
{
    string urlParams = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

    ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParams);

    Console.WriteLine("Valor de moedaOrigem: " + extratorDeValores.GetValue("moedaOrigem"));
    Console.WriteLine("Valor de moedaDestino: " + extratorDeValores.GetValue("moedaDestino"));
    Console.WriteLine("Valor de valor: " + extratorDeValores.GetValue("VALOR"));
    Console.ReadLine();

    //moedaDestino

}