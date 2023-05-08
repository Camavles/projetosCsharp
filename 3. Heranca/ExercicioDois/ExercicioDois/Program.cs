
using ExercicioDois.Funcionarios;
using ExercicioDois.Utilitarios;

#region
// trecho relativo a parte de herança
//Diretor carol = new Diretor("123.456-00");
//carol.Nome = "Carol Lima";
////Console.WriteLine(carol.Salario);
//Console.WriteLine("Bonificação Carol: " + carol.GetBonificacao());

//Funcionario raul = new Funcionario("156.475- 00", 2000);
//raul.Nome = "Raul Matias";
//Console.WriteLine("Bonificação Raul " + raul.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(carol);
//gerenciador.Registrar(raul);


//Console.WriteLine("Total da Bonificação: " + gerenciador.TotalBonificacao);
//Console.WriteLine("Total de Funcionários: " + Funcionario.TotalFuncionarios);

//raul.AumentarSalario();
//carol.AumentarSalario();
//Console.WriteLine(carol.Salario);
//Console.WriteLine(raul.Salario);
#endregion

// Classes abstratas
// metodo

//CalcularBonificacao();
//UsarSistema();
//void CalcularBonificacao()
//{
//    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//    Designer ulisses = new Designer("123456-7");
//    ulisses.Nome = "Ulisses Souza";

//    Diretor paula = new Diretor("456789-0");
//    paula.Nome = "Paula Souza";

//    Auxiliar igor = new Auxiliar("78921-3");
//    igor.Nome = "Igor Dias";

//    GerenteDeContas camila = new GerenteDeContas("235869-7");
//    camila.Nome = "Camla Oliveira";

//    gerenciador.Registrar(ulisses);
//    gerenciador.Registrar(paula);
//    gerenciador.Registrar(igor);
//    gerenciador.Registrar(camila);

//    Console.WriteLine("Total de Bonificação: " + gerenciador.TotalBonificacao);

//}

//void UsarSistema()
//{
//SistemaInterno sistema = new SistemaInterno();

//Diretor ingrid = new Diretor("5137-00");
//ingrid.Nome = "Ingrid Silveira";
//ingrid.Senha = "1230";
//sistema.Logar(ingrid, ingrid.Senha);

//GerenteDeContas ivone = new GerenteDeContas("98754-12");
//ivone.Nome = "Ivone Lara";
//ivone.Senha = "456";
//sistema.Logar(ivone, "234");

//ParceiroComercial caio = new ParceiroComercial();
//caio.Senha = "999";

//sistema.Logar(caio, "999");

//Console.WriteLine(34.40m);
//}

TestarBofinicacao();

void TestarBofinicacao()
{



    Auxiliar camila = new Auxiliar("123.456-00");
    camila.Nome = "Camila Silva";
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    gerenciador.Registrar(camila);

   
    Diretor lili = new Diretor("456.789-00");
    lili.Nome = "Lili Silveira";
    gerenciador.Registrar(lili);

    Console.WriteLine(gerenciador.TotalDeBonficacao);
    

}