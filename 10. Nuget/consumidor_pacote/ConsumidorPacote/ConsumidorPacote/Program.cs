using bytebank_Projeto_GeradorChavePix;

Console.WriteLine(GeradorPix.GetChavePix());
// funciocou

var lista = GeradorPix.GetChavesPix(5);

foreach (var chave in lista)
{
    Console.WriteLine(chave);
}