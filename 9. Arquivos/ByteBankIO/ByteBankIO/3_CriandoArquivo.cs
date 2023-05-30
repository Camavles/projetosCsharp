using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static void CriarArquivo()
    {
        // esse é o caminho da volta;
        var caminhoNovoArquivo = "contasExportadas.csv";
        // criar um novo arquivo
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Camila Alves";

            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);

        }

    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
        //existe o FileMode.CreateNew --> só cria um arquivo que não existe;
        //Create --> arquivo já existe e eu só quero substituir;
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using(var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("123,78980,450.6,Pedro");
        }
       
    }

    // método que verifica se o arquivo é atualizado assim que rodar;
    // quanto tempo demora para ser gravado;
    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for(int i = 0; i < 100; i++)
            {
                // método Flush --> pega o buffer e despeja no Stream; 
                // faz com que a escrita das informações no meu arquivo seja mais rápida;
                // método WriteLine do StreamWriter é parecido com o método WriteLine do Console
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); 
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter..");
                Console.ReadLine();
            }
           
            
        }
    }
}
