partial class Program
{
    static void EscritaBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {


            escritor.Write(23);
            escritor.Write("1010-Y");
            escritor.Write(4000.50);
            escritor.Write("Camila Alves");
        }
    }


    static void LeituraBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
        using (var leitor = new BinaryReader(fs))
        {
            var agencia = leitor.ReadInt32();
            var conta = leitor.ReadString();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();


            Console.WriteLine($" Ag: {agencia} / Conta: {conta} / Saldo: {saldo} / Titular: {titular}");
        }
    }
}