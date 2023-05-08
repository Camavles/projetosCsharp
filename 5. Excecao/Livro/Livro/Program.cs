using Arquivo;

LeitorDeArquivo leitor = new LeitorDeArquivo("conts.txt");

try
{
    
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    
}
catch(IOException)
{
    Console.WriteLine("Leitura interrompida!");
    
}
finally
{
    // finally para continuar a execução dos comandos;
    leitor.Fechar();
}