using ByteBankIO;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";

        // using ajuda a tratar uma exception;

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;


            var buffer = new byte[1024];


            while (numeroDeBytesLidos != 0)
            {
                Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            fluxoDoArquivo.Close();
            Console.ReadLine();
        }




        //public override int Read(byte[] array, int offset, int count);
        // esse array é chamador de buffer;
        // vai pegando pedaços do arquivo e armazenando no array
        //var buffer = new byte[1024]; // 1KB

        //fluxoDoArquivo.Read(buffer, 0, 1024);
        // Devoluções:
        /* O número total de bytes lidos do buffer. Isso poderá ser menor que o número de bytes solicitado se esse número de bytes não estiver disponível no momento, ou zero, se o final do fluxo for atingido. */

        //var enderecoDoArquivoTeste = "texto.txt";
        //var numeroLido = -1;
        //var fluxoCaminhoDoAqruivo = new FileStream(enderecoDoArquivoTeste, FileMode.Open);
        //var buffer = new byte[1024];

        //while(numeroLido != 0)
        //{
        //    numeroLido = fluxoCaminhoDoAqruivo.Read(buffer, 0, 1024);
        //    EscreverBuffer(buffer); // PRECISA TER O NOME BUFFFER
        //}

        //Console.ReadLine();

    }


    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        // aqui eu interpreto o texto e mostro;
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, bytesLidos);

        Console.Write(texto);



        /*
        foreach(var meuByte in buffer) 
        {
            Console.Write(meuByte);
            Console.Write(" ");
        } */


    }



}
