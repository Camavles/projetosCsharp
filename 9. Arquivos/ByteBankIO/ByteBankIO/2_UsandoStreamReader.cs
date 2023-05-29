using ByteBankIO;


partial class Program
{
    static void UsandoStreamReader()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            // classe inntermediaria que faz a manipulação e a leitura dos nossos bytes;
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine(); // lê a 1ª linha do meu arquivo;
            //Console.WriteLine(linha);

            // precisa tomar cuidado com esse método, pq ele carrega o arquivo de uma única vez.
            //var texto = leitor.ReadToEnd();
            //Console.WriteLine(texto);

            // traz o 1º byte do nosso arquivo
            //var numero = leitor.Read();
            //Console.WriteLine(numero);

            // EndOfStream --> pegar até o final de um fluxo, usando ele aliado ao ReadLine();
            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);
                var msg = $"Titulat: {contaCorrente.Titular.Nome}, Conta Agencia: {contaCorrente.Agencia}, Número: {contaCorrente.Numero}, Saldo: R${contaCorrente.Saldo}";

                Console.WriteLine(msg);
            }
        }

    }


    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        //375,4644,2483.13,Jonatan Silva
        var campos = linha.Split(',');
        // usei o Parse para fazer a transformação;
        var agencia = campos[0];
        var numero = campos[1];
        // convertendo os valores, e trocando o ponto por vírgula;
        string saldo = campos[2].Replace('.', ',');
        var nomeTitular = campos[3];


        var agenciaInt = int.Parse(agencia);
        var numeroInt = int.Parse(numero);
        var saldoComDouble = double.Parse(saldo);


        var titular = new Cliente();
        titular.Nome = nomeTitular;

        var resultado = new ContaCorrente(agenciaInt, numeroInt);
        resultado.Depositar(saldoComDouble);
        resultado.Titular = titular;

        return resultado;
    }
}
