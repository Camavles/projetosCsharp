
using ExercicioDois.Funcionarios;
using ExercicioDois.GerenciadorDeBonificacao;

Diretor carol = new Diretor("123.456-00", 5000);
carol.Nome = "Carol Lima";
//Console.WriteLine(carol.Salario);
Console.WriteLine("Bonificação Carol: " + carol.GetBonificacao());

Funcionario raul = new Funcionario("156.475- 00", 2000);
raul.Nome = "Raul Matias";
Console.WriteLine("Bonificação Raul " + raul.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(carol);
gerenciador.Registrar(raul);


Console.WriteLine("Total da Bonificação: " + gerenciador.TotalBonificacao);
Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

raul.AumentarSalario();
carol.AumentarSalario();
Console.WriteLine(carol.Salario);
Console.WriteLine(raul.Salario);
