using ByteBankIO;
using System.Text;
using System.Xml;

partial class Program
{
    // quando eu uso o partial, ele vai entender que essa classe está separada em diversos arquivos.
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine();
            //Console.WriteLine(linha);

            // precisa tomar cuidado com esse método, pq ele carrega o arquivo de uma única vez.
            //var texto = leitor.ReadToEnd();
            //Console.WriteLine(texto);

            // traz o 1º byte do nosso arquivo
            //var numero = leitor.Read();
            //Console.WriteLine(numero);

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha);
            }
        }
       
    }

}


