using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;

        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
        var buffer = new byte[1024];
        

        while(numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }

        
        Console.ReadLine();


        //public override int Read(byte[] array, int offset, int count);
        // esse array é chamador de buffer;
        // vai pegando pedaços do arquivo e armazenando
        //var buffer = new byte[1024]; // 1KB

        //fluxoDoArquivo.Read(buffer, 0, 1024);
        // Devoluções:
        /* O número total de bytes lidos do buffer. Isso poderá ser menor que o número de bytes solicitado se esse número de bytes não estiver disponível no momento, ou zero, se o final do fluxo for atingido. */


    }


    static void EscreverBuffer(byte[] buffer)
    {
        foreach(var meuByte in buffer) 
        {
            Console.Write(meuByte);
            Console.WriteLine(" ");
        }
    }
}