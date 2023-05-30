using ByteBankIO;
using System.Text;
using System.Xml;

partial class Program
{
    // quando eu uso o partial, ele vai entender que essa classe está separada em diversos arquivos.

    static void Main(string[] args)
    {
        //CriarArquivoComWriter();
        //TestaEscrita();
        //EscritaBinario();
        //LeituraBinaria();
        UsarStreamDeEntrada();
        Console.WriteLine("Aplicação finalizada!");
        Console.ReadLine();



    }


    // teste --> caso eu queira ver denovo preciso colocar dentro do método main
    //var caminhoNovoArquivo = "TestaEscrita.txt";
    //using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
    //using (var escritor = new StreamWriter(fluxoDeArquivo))
    //{
    //    // para arquivos grandes, podemos usar a escrita binária;
    //    escritor.WriteLine(true);
    //    escritor.WriteLine(false);
    //    escritor.WriteLine(454545454545);
    //}
    //Console.WriteLine("Aplicação Finalizada!");
    //Console.ReadLine();



}


