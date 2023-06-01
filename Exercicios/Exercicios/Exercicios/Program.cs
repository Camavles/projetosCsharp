
using Exercicios.Cliente;
using Exercicios.Contas;
using Exercicios.Excecoes;
using System.Reflection.Metadata;
using System.Xml.Serialization;

//ContaCorrente conta1 = new ContaCorrente(15, "1010-X");
//ContaCorrente conta2 = new ContaCorrente(18, "1010-Y");
//conta1.titular = new Titular();
//conta1.titular.Nome = "Camila";
//conta1.Depositar(500);
//Console.WriteLine("Saldo da conta1 R$ " + conta1.Saldo);
//conta1.Transferir(conta2, 200);
//Console.WriteLine("Saldo da conta1 R$ " + conta1.Saldo);
//Console.WriteLine("Saldo da conta2 R$ " + conta2.Saldo);

// Exceções
//TestaMetodos();

void TestaMetodos()
{
    try
    {
        ContaCorrente conta1 = new ContaCorrente(10, "1010-X");
        ContaCorrente conta2 = new ContaCorrente(18, "1010-Y");
        Console.WriteLine("Conta criada com sucesso!");
        // conta1.Transferir(conta2, -50);
        Console.WriteLine("Esse é o total de contas: " + ContaCorrente.TotalDeContas);
        Console.WriteLine(ContaCorrente.TaxaOperacao);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Não foi possível criar a sua conta");
        Console.WriteLine("=============");
        Console.WriteLine(ex.ParamName);
        Console.WriteLine(ex.Message);
    }
    catch (OperacoesException ex)
    {
        Console.WriteLine("Erro na operação");
        Console.WriteLine("========");
        Console.WriteLine(ex.Message);
    }


}

//Sistema de Login

TestaDesafio();

void TestaDesafio()
{
    List<ContaCorrente> _listaDeContas = new List<ContaCorrente>(){
          new ContaCorrente(95, "123456-X"){Saldo=100,titular = new Titular{Cpf="11111",Nome ="Henrique"}},
          new ContaCorrente(95, "951258-X"){Saldo=200,titular = new Titular{Cpf="22222",Nome ="Pedro"}},
          new ContaCorrente(94, "987321-W"){Saldo=60,titular = new Titular{Cpf="33333",Nome ="Marisa"}}
        };


    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("Não há dados para serem exportados!");
    }
    else
    {

            var arquivo = new XmlSerializer(typeof(List<ContaCorrente>));

            var enderecoDoNovoArquivo = "contasEmXml.xml";
            using (var fs = new FileStream(enderecoDoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fs))
            {
                arquivo.Serialize(escritor, _listaDeContas);

            }
            Console.WriteLine("Aquivo saldo e convertido em XML");
            Console.ReadKey();


    }



}