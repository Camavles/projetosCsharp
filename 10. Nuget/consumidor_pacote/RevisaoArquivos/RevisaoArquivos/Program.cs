using RevisaoArquivos.Clientes;
using RevisaoArquivos.Contas;








TestaAplicacao();
void TestaAplicacao()
{
    ContaCorrente conta1 = new ContaCorrente(23, "1010-X");
    conta1.titular = new Cliente{ Nome = "Camila" , Cpf = "12345"};
    conta1.Depositar(50);

    ContaCorrente conta2 = new ContaCorrente(24, "2020-Z");
    conta2.titular = new Cliente {  Nome = "Rapha", Cpf = "5892"};
    conta1.Transfere(conta2, 25);

    Console.WriteLine(conta1);
    Console.WriteLine(conta2);
}