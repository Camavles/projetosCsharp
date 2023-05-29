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
}
