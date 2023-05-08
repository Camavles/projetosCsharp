
using ExercicioTres;
using ExercicioTres.Contas;
using ExercicioTres.Titular;

try
{
    ContaCorrente conta1 = new ContaCorrente(20, "1010-x");
    //conta1.Sacar(200);
    //conta1.Depositar(0);
    Console.WriteLine(conta1.GetSaldo());
}
catch(ArgumentException ex) 
{
    // pega o parametro que está lançando essa exceção;
    Console.WriteLine("Parametro com erro: " + ex.ParamName);
    Console.WriteLine("Não é possível criar conta com número de agência menor ou igual a zero!");
    // StackTrace --> mostra a linha em que estamos tratando uma exceção | e  qual linha a gente encontra essa exceção
    //Console.WriteLine(ex.StackTrace);
    // trazendo a mensagem que está no throw para cá;
    Console.WriteLine(ex.Message);
}
catch(SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação negada! Saldo Insuficiente!");
    Console.WriteLine(ex.Message);
} 
catch(DepositoException ex)
{
    Console.WriteLine("Operação incorreta! Seu deposito precisa ser maior que zero!");
    // trazendo a mensagem que está no throw para cá;
    Console.WriteLine(ex.Message);
}