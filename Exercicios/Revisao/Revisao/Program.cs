
using Revisao;

ContaCorrente c1 = new ContaCorrente(14, "1010-X");
ContaCorrente c2 = new ContaCorrente(15, "2020-Y");


Cliente camila = new Cliente();
Cliente rapha = new Cliente();

camila.Nome = "Camila Alves";
rapha.Nome = "Raphael Vieira"; 
c1.Titular = camila;
c2.Titular = rapha;

GerenciadorClientes gerenciador = new GerenciadorClientes();
gerenciador.Adiciona(camila);
gerenciador.Adiciona(rapha);

Console.WriteLine(gerenciador.Encontra("Camila Alves")); 



