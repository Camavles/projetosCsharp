using System.Text;



partial class Program
{

    static void LidandoComFileStreamDiretamente()
    {

        //Console.WriteLine("Camila");

        // como fazer quebra de linha em string usando \n;
        //var textoComQuebraDeLinha = "minha primeira linha \n minha segunda linha";
        //Console.WriteLine(textoComQuebraDeLinha);
        //Console.ReadLine();
        var endereco = "contas.txt";

        // using cria um try/catch/finally e vai verificar se não está vindo nulo e vai liberar o arquivo no final;

        using (var fluxoDoArquivo = new FileStream(endereco, FileMode.Open))
        {
            var buffer = new byte[1024]; // 1KB;
            var numeroDeBytesLidos = -1;

            // como o arquivo tem 25KB e eu só tô lendo 1KB por vez, eu passei o leitor de arquivo 25x até chegar no final;
            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, buffer.Length);
                EscreverBuffer(buffer, numeroDeBytesLidos);

            }

            //fluxoDoArquivo.Close(); // para fechar o arquivo;

        }

        Console.ReadLine();
    }



    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {

        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, bytesLidos);

        Console.Write(texto);

        //foreach (var item in buffer)
        //{
        //    Console.Write(item);
        //    Console.Write(" ");
        //}
    }

}


