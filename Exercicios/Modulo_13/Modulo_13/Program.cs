using Modulo_13;


Pessoa pessoa = new Pessoa();
pessoa.Nome = "Camila";
pessoa.Data_Nascimento = "21/01/1997";
pessoa.Altura = 1.62;
var idade = pessoa.CalcularIdade(2023);

Console.WriteLine($"{pessoa} / Essa é a idade: {idade}");

