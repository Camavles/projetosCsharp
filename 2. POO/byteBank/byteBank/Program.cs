using byteBank.Conta;
using byteBank.Titular;
using System.Xml;

//ContaCorrente contaDoAndre = new ContaCorrente();

// valor padrão é 0
//Console.WriteLine(contaDoAndre.saldo);
//Console.WriteLine(contaDoAndre.titular); // não aparece nada

//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta R$ " + contaDoAndre.saldo);

//contaDoAndre.Depositar(100);

//Console.WriteLine("Saldo da conta pós-deposito R$ " + contaDoAndre.saldo);

//if (contaDoAndre.Sacar(300) == true)
//{
//    Console.WriteLine("Saldo da conta pós-saque R$ " + contaDoAndre.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente");
//}


//ContaCorrente contaDaMaria = new ContaCorrente();

//contaDaMaria.titular = "Maria Sena";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;


//if (contaDoAndre.Transferir(50, contaDaMaria) == true)
//{
//    Console.WriteLine("Tranferencia efetuada com sucesso");
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente");
//}

//Console.WriteLine("Conta da Maria, saldo R$ " + contaDaMaria.saldo + " | Conta do André R$ " + contaDoAndre.saldo);

//Console.WriteLine("Escreva CW em maísculo");


//Console.WriteLine(contaDaMaria.ToString());


// TESTANDO COMPOSIÇÃO DE CLASSE // RELAÇÃO ENTRE CLASSES

//Cliente cliente = new Cliente();

//cliente.nome = "Camila Alves";
//cliente.cpf = "123.456.789-0";
//cliente.profissao = "Programadora";

//ContaCorrente contaCamila = new ContaCorrente();

//contaCamila.titular = cliente; // aponta para o mesmo endereço de memória q cliente
//contaCamila.conta = "1010-X";
//contaCamila.numero_agencia = 15;
//contaCamila.saldo = 100;

//Console.WriteLine(contaCamila.titular.nome);
//Console.WriteLine(contaCamila.titular.cpf);
//Console.WriteLine(contaCamila.titular.profissao);
//Console.WriteLine(contaCamila.conta);
//Console.WriteLine(contaCamila.numero_agencia);
//Console.WriteLine(contaCamila.saldo);


//ContaCorrente conta = new ContaCorrente();

////Cliente cliente2 = new Cliente();
////conta.titular.nome = "Eduardo"; // não posso fazer isso pq vai dar null; é como se eu estivesse usando o objetoo conta para definir o objeto cliente


//conta.titular = new Cliente();
//conta.titular.nome = "Eduardo";
//Console.WriteLine(conta.titular.nome);



//ContaCorrente conta3 = new ContaCorrente();
//conta3.SetSaldo(20);

//conta3.Numero_agencia = 32;
// propriedade auto implementada
//conta3.Conta = "1010-Y";
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.GetSaldo());


// Propriedade auto implementada
//conta3.Titular = new Cliente();
//conta3.Titular.Nome = "Camila Alves";
//conta3.Titular.Cpf = "123.456.789-00";
//conta3.Titular.Profissao = "Programadora";
//conta3.Conta = "1010-P";
//conta3.Numero_agencia = 1263;
//conta3.SetSaldo(90);

//Console.WriteLine("Titular: " + conta3.Titular.Nome);
//Console.WriteLine("CPF: " + conta3.Titular.Cpf);
//Console.WriteLine("PROFISSÃO: " + conta3.Titular.Profissao);
//Console.WriteLine();
//Console.WriteLine("Conta: " + conta3.Conta);
//Console.WriteLine("Agencia: " + conta3.Numero_agencia);
//Console.WriteLine("Saldo: " + conta3.GetSaldo());


//// Método construtor:
//ContaCorrente conta4 = new ContaCorrente(18, "XX10 - 0");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();
//conta4.Titular.Nome = "Maju";
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);
//Console.WriteLine(conta4.Conta);

ContaCorrente conta5 = new ContaCorrente(15, "1215-X");
Console.WriteLine(ContaCorrente.TotalContasCriadas);

ContaCorrente conta6 = new ContaCorrente(16, "1315-Y");
Console.WriteLine(ContaCorrente.TotalContasCriadas);