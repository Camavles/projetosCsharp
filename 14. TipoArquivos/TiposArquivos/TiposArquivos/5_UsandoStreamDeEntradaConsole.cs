

partial class Program
{
    static void UsarStreamDeEntrada()
    {
        using(var fluxoDeEntrada = Console.OpenStandardInput())
        using(var fs = new FileStream("entradaConsole.txt", FileMode.Create))
        {
            var buffer = new byte[1024];

            while (true)
            {
                var bytesLidos = fluxoDeEntrada.Read(buffer, 0, buffer.Length);

                fs.Write(buffer, 0, bytesLidos);
                fs.Flush();
                Console.WriteLine($"Nº de Bytes Lidos {bytesLidos}");
            }
            
        }
    }
}