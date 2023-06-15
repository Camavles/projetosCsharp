

using System.Runtime.Intrinsics.X86;
using System.Text;
using System;

partial class Program
{
    // esse método é para pegar um arquivo que está em bytes e criar outro arquivo de maneira gráfica para q eu possa usar no excel, por exemplo.
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "novoExportadas.csv";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456,1010-X,4000.50,Camila Alves";
            var enconding = Encoding.UTF8;
            var bytes = enconding.GetBytes(contaComoString); // recebi a contaComoString como bytes;
            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("123,2020-Y,130.0,Rapha");
        }
    }

    static void TestaEscrita()
    {
        var caminhoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 1000000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); // Despeja o buffer para o Stream; faz com que esse registro vá direto no HD;

                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                Console.ReadLine();
            }
        }
    }


}