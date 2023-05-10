
using SistemaInterno.Autenticacao;
using SistemaInterno.Funcionarios;
using SistemaInterno.Utilitarios;

TestarMetodos();
void TestarMetodos()
{
    Auxiliar claudio = new Auxiliar("Claudio Heleno", "123.456-00");
    Console.WriteLine("Funcionário " +  claudio.Nome);
    Console.WriteLine("Esse é o Salário R$ " + claudio.Salario);
    //Console.WriteLine("Este é o aumento de salario R$ " + claudio.AumentarSalario());

    Console.WriteLine();

    Diretor camila = new Diretor("Camila Alves", "456.789-00");
    Console.WriteLine("Funcionário " + camila.Nome);
    Console.WriteLine("Esse é o Salário R$ " + camila.Salario);
    //Console.WriteLine("Este é o aumento de salario R$" + camila.AumentarSalario());


    // gerenciador
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    gerenciador.Registrar(camila);
    gerenciador.Registrar(claudio);
    Console.WriteLine("Total de bonifcações: " + gerenciador.TotalBonificacao);


    //login no sistema
    Login sistema = new Login();
    camila.Senha = "12";
    sistema.Logar(camila, "123");


}





