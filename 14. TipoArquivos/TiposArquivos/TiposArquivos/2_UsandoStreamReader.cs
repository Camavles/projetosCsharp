using bytebank.Modelos.Conta;

partial class Program
{
    // TestandoStream();
    static void TestandoStream()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        using (var leitor = new StreamReader(fluxoDoArquivo))
        {
            // enquanto eu não chegar no fim do arquivo(endOfStream) quero escrever meu arquivo na tela;

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);

                //Console.WriteLine($"Agência: {contaCorrente.Numero_agencia} / Conta: {contaCorrente.Conta} / Saldo R$: {contaCorrente.Saldo} / Titular {contaCorrente.Titular.Nome}");

                foreach (var conta in contaCorrente)
                {
                    Console.WriteLine($"Agência: {conta.Numero_agencia} / Conta: {conta.Conta} / Saldo R$: {conta.Saldo} / Titular {conta.Titular.Nome}");
                }
            }

        }

        Console.ReadLine();
    }

    // aqui se eu devolvo um List, da forma como eu fiz, eu preciso criar uma lista e ir colocando cada item nela;
    static List<ContaCorrente> ConverterStringParaContaCorrente(string linha)
    {
        //não esquecer dos métodos;
        var campos = linha.Split(',');
        //var separa = campos.Split(',');

        var agencia = campos[0];
        var numero = campos[1];
        var saldo = campos[2].Replace('.', ',');
        var nome = campos[3];

        var agenciaInt = int.Parse(agencia);
        var saldoDouble = double.Parse(saldo);


        ContaCorrente resultado = new ContaCorrente(agenciaInt, numero);
        resultado.Depositar(saldoDouble);
        resultado.Titular = new Cliente();
        resultado.Titular.Nome = nome;

        List<ContaCorrente> lista = new List<ContaCorrente>();
        lista.Add(resultado);

        return lista;
    }
}