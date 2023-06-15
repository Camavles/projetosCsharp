

using bytebank.Modelos.Conta;
using System.Globalization;
using System.Text;

//Console.WriteLine("Camila");

//TestandoStream();


//CriarArquivo();
//CriarArquivoComWriter();
//EscritaBinaria();
//LeituraBinaria();
//UsarStreamDeEntrada();

// Existe a classe File que pode abstrair as funções do FileStream, então tbm posso usá-la quando eu não preciso ler um arquivo muito grande;

var linhas = File.ReadAllLines("contas.txt");
Console.WriteLine(linhas.Length);

foreach (var linha in linhas)
{
    Console.WriteLine(linha);
}


Console.WriteLine("Aplicação Finalizada . . .");
Console.ReadLine();