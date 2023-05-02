using Clinica;
using System.Reflection.PortableExecutable;

Pessoa pessoa = new Pessoa();

pessoa.nome = "Camila";
pessoa.altura = 1.62;
pessoa.peso = 54;
pessoa.idade = 26;

Console.WriteLine("Nome: " + pessoa.nome);
Console.WriteLine("Idade: " + pessoa.idade);
Console.WriteLine("Peso: " + pessoa.peso);
Console.WriteLine("Altura: " + pessoa.altura);