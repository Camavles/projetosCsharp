using ExercicioUm.Contas;
using ExercicioUm.Titular;
using System;
using System.Runtime.CompilerServices;
using System.Xml;

// REVISÃO
//ContaCorrente conta1 = new ContaCorrente();
//Cliente cliente1 = new Cliente();

//cliente1.Nome = "Camila Alves";
//cliente1.Profissao = "Programadora";
//cliente1.Cpf = "123.456.890-00";


//conta1.titular = cliente1;
//conta1.DepositarSaldo(150);
//conta1.numero_agencia = 2029;
//conta1.conta = "1020-X";


//Console.WriteLine("Titular: " + conta1.titular.Nome);
//Console.WriteLine("CPF: " + conta1.titular.Cpf);
//Console.WriteLine("Profissão " + conta1.titular.Profissao);
//Console.WriteLine();
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Agência: " + conta1.numero_agencia);
//Console.WriteLine("Você tem R$ " + conta1.saldo);


// GET E SET - Método
// Posso usar Métodos ou Propriedades;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.SetSaldo(50);
//conta2.GetSaldo();

//Console.WriteLine(conta2.GetSaldo());


// GET SET - PROPRIEDADE;
//ContaCorrente conta3 = new ContaCorrente();
//conta3.Titular = new Cliente();
//conta3.Titular.Nome = "Raphael Vieira";
//conta3.Titular.Cpf = "123.456.789-99";
//conta3.Titular.Profissao = "Economista";
//conta3.Numero_agencia = 125;
//conta3.Conta = "101-XY";
//conta3.DepositarSaldo(300);


//Console.WriteLine("Informações da Conta");
//Console.WriteLine();
//Console.WriteLine("Titular: " + conta3.Titular.Nome);
//Console.WriteLine("CPF: " + conta3.Titular.Cpf);
//Console.WriteLine("Profissão: " + conta3.Titular.Profissao);
//Console.WriteLine();
//Console.WriteLine("Agência: " +  conta3.Numero_agencia);
//Console.WriteLine("Conta: " + conta3.Conta);
//Console.WriteLine("Saldo: " + conta3.Saldo);


// Método Contrutor; static; propriedades auto implementadas;

ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
ContaCorrente conta5 = new ContaCorrente(19, "1020-Y");
Console.WriteLine(ContaCorrente.TotalContasCriadas);


