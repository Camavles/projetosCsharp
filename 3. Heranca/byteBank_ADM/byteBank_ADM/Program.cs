using byteBank_ADM.Funcionarios;
using byteBank_ADM.Utilitario;

Funcionario carol = new Funcionario("123.456.789-00", 2000);
carol.Nome = "Carol Silveira";

Console.WriteLine(carol.Nome);
Console.WriteLine(carol.GetBonificacao());


Diretor roberta = new Diretor("50.697-00", 5000);
roberta.Nome = "Roberta Silva";


Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

// sobrecarga de método;
GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(carol);
gerenciador.Registrar(roberta);
Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);

// sempre que inicio um contrutor de uma classe herdada; o contrutor que executa primeiro é o da classe base;
Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

carol.AumentarSalario();
roberta.AumentarSalario();
Console.WriteLine("Salário: " + roberta.Salario);
Console.WriteLine("Salário: " + carol.Salario);