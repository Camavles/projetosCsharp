using ByteBankIO;
using System.Text;


partial class Program
{
    static void EscritaBinario()
    {
        // armazenando um arquivo em formato binário;
        // armazendo um testo em binário consome bem menos memória do que armazenar um testo puro;
        using(var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using(var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);            // numero da Agencia
            escritor.Write(2321);           // número conta
            escritor.Write(4000.50);        // Saldo
            escritor.Write("Camila Silva");
        }
    }


    static void LeituraBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
        using (var leitor = new BinaryReader(fs))
        {
            var agencia = leitor.ReadUInt32();
            var numero = leitor.ReadUInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();

            Console.WriteLine($"Ag: {agencia}/ nº: {numero} / saldo: {saldo}/ Titular: {titular}");


        }
    }
}