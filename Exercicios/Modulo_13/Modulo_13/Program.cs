using Modulo_13;
using System.Text.RegularExpressions;


Pessoa pessoa = new Pessoa();
pessoa.Nome = "Camila";
pessoa.Data_Nascimento = "21/01/1997";
pessoa.Altura = 1.62;


//Pessoa pessoa = new Pessoa("21/01/1997", "Camila Alves", 1.62);
var idade = pessoa.CalcularIdade(2023);
Console.WriteLine($"{pessoa}, idade:{idade} ");




//var data = new DateTime();
//data = DateTime.Now;
//data.ToString();

//Console.WriteLine(data);


