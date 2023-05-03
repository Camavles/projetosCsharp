using byteBank_ADM.Funcionarios;
using byteBank_ADM.Parceria;
using byteBank_ADM.SistemaInterno;
using byteBank_ADM.Utilitario;


#region
//Funcionario carol = new Funcionario("123.456.789-00", 2000);
//carol.Nome = "Carol Silveira";

//Console.WriteLine(carol.Nome);
//Console.WriteLine(carol.GetBonificacao());


//Diretor roberta = new Diretor("50.697-00");
//roberta.Nome = "Roberta Silva";


//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//// sobrecarga de método;
//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(carol);
//gerenciador.Registrar(roberta);
//Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);

//// sempre que inicio um contrutor de uma classe herdada; o contrutor que executa primeiro é o da classe base;
//Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

//carol.AumentarSalario();
//roberta.AumentarSalario();
//Console.WriteLine("Salário: " + roberta.Salario);
//Console.WriteLine("Salário: " + carol.Salario);
#endregion

//CalcularBonificacao();

UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    
    Designer raphael = new Designer("999.888-77");
    raphael.Nome = "Raphael Vieira";

    Diretor daniela = new Diretor("123.456-99");
    daniela.Nome = "Daniela Silva";

    Auxiliar igor = new Auxiliar("555.666-22");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("222.333-66");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(daniela);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(raphael);

    Console.WriteLine("Total da Bonificação: " + gerenciador.TotalDeBonificacao);

}


void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();
    Diretor ingrid = new Diretor("123.456-00");
    ingrid.Nome = "Ingrid Souza";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("456.897-00");
    ursula.Nome = "Ursula Ribeiro";
    ursula.Senha = "456";


    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "895";


    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "236");
    sistema.Logar(caio, "895");




}