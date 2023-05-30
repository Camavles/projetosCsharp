using ByteBankIO;
using System.Text;





partial class Program
{
    static void UsarStreamDeEntrada()
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
        {
            var buffer = new byte[1024]; //1kb

            while(true)
            {
                var byteslidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                // com esses comandos eu escrevo instantaneamente no meu arquivo;
                fs.Write(buffer, 0, byteslidos);
                fs.Flush();
                Console.WriteLine($"Byttes lidos na console: {byteslidos}");
            }
            
        }
    }
}

