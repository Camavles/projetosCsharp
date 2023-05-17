using ListaDeObjetos;
using System.Collections.Immutable;

// 1ª PARTE
// o var na prente converte a minha declaração no tipo de classe que u tenho 
//var aulaIntro = new Aula("Introdução às Coleções", 20);
//var aulaModelando = new Aula("Modelando a Classe Aula", 18);
//var aulaSets = new Aula("Trabalhando com Conjuntos", 16);


//List<Aula> aulas = new List<Aula>();
//aulas.Add(aulaIntro);
//aulas.Add(aulaSets);
//aulas.Add(aulaModelando);

////aulas.Add("Conlusão"); não é possível fazer assim;

//Imprimir(aulas);

//aulas.Sort();

//Imprimir(aulas);

//// outra forma de ordenação usando o sort e o compareTo
//aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
//Imprimir(aulas);

//void Imprimir(List<Aula> aulas)
//{

//    foreach (var aula in aulas)
//    {
//        Console.WriteLine(aula);
//    }

//}

// *********************************** 2ª PARTE -> LISTA SOMENTE LEITURA  ******************************************

// mudei o método para IList, após implementar o ReadOnlyCollection
//void Imprimir(IList<Aula> aulas)
//{

//    Console.Clear();

//    foreach (var aula in aulas)
//    {
//        Console.WriteLine(aula);
//    }

//}


//Curso cSharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
//// code smells - estou manipulando diretamente os campos de uma classe;
//// exposição indecente 
//cSharpColecoes.Adiciona(new Aula("Working with lists", 21));

//Imprimir(cSharpColecoes.Aulas);

//cSharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
//cSharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));

//Imprimir(cSharpColecoes.Aulas);

////cSharpColecoes.Aulas.Sort();
//// Por que a lista copiada é uma lista que ue posso modificar?
//List<Aula> aulasCopiadas = new List<Aula>(cSharpColecoes.Aulas);

////ordenar a cópia
//aulasCopiadas.Sort();

//Imprimir(aulasCopiadas);

//// Totalizar tempo do curso;
//Console.WriteLine(cSharpColecoes.TempoTotal);

//// imprimir os deltalhes do curso:
//Console.WriteLine(cSharpColecoes);

//************************************************************* 3ª PARTE: CONJUNTOS *****************************************************************
// Duas propriedades do Set;
// 1. Não permite duplicidade
// 2. Não são mantidos em ordem específica;

//ISet<string> alunos = new HashSet<string>();
//alunos.Add("Vanessa Tonini");
//alunos.Add("Ana Losnak");
//alunos.Add("Rafael Nercessian");

//Console.WriteLine(alunos);
//Console.WriteLine(string.Join(",", alunos));

//// Diferenças entre um conjunto e listas?
//alunos.Add("Priscila Stuani");
//alunos.Add("Rafael Rollo");
//alunos.Add("Fabio Gushiken");
//Console.WriteLine(string.Join(",", alunos));

//// removendo a ana e colocando o marcelo
//alunos.Remove("Ana Losnak");
//alunos.Add("Marcelo Oliveira");
//Console.WriteLine(string.Join(",", alunos));

//// adicionando o mesmo aluno; o conjunto ignora e não adiciona
//alunos.Add("Fabio Gushiken");
//Console.WriteLine(string.Join(",", alunos));

//// desempenho de HashSet x List: escalabilidade x memória --> ele consome muita memória
//// passei como parametro alunos que popula o alunosLista;
//List<string> alunosLista = new List<string>(alunos);
//alunosLista.Sort();
//Console.WriteLine(string.Join(",", alunosLista));
//;


// ********************************************** 4ª PARTE: JUNÇÃO ENTRE CONJUNTOS E LISTAS *********************************************
Curso cSharpColecoes = new Curso("C# Coleções", "Marcelo Oliveira");
cSharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
cSharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
cSharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

Aluno a1 = new Aluno("Vanessa Tonini", 34672);
Aluno a2 = new Aluno("Ana Losnak", 5617);
Aluno a3 = new Aluno("Rafael Nercessian", 17645);

cSharpColecoes.Matricula(a1);
cSharpColecoes.Matricula(a2);
cSharpColecoes.Matricula(a3);

foreach (var aluno in cSharpColecoes.Alunos)
{
    Console.WriteLine(aluno);
}

// o aluno está matriculado ou não?
Console.WriteLine($"O(a) aluno(a) {a1.Nome} está matriculado(a)?");
Console.WriteLine(cSharpColecoes.EstaMatriculado(a1));

// criei uma nova instacia com informações que já tinham;
Aluno tonini = new Aluno("Vanessa Tonini", 34672);

Console.WriteLine(cSharpColecoes.EstaMatriculado(tonini));
Console.WriteLine();

//fiz uma verificação:
// ele não reconhece essa comparação como true, pq os espaços na memória são diferentes
// a referencia é diferente, mas o tipo de objeto é o mesmo.
//Aluno tonini = a1; aqui dá true
Console.WriteLine("Aluno a1 é igual a tonini");
Console.WriteLine(a1 == tonini);
Console.WriteLine();

// comparando as informações/ valores;
Console.WriteLine("a1 é equals a Tonini");
Console.WriteLine(a1.Equals(tonini));
Console.Clear();

//********************************************* 5ª PARTE: DICIONÁRIOS *******************************************************
Console.WriteLine("Quem é o aluno com a matricula 5617?");
// Busca usando HashSet
Aluno aluno57 = cSharpColecoes.BuscaMatriculado(5617);
Console.WriteLine("Aluno 5617: " + aluno57);
// Será que essa busca é eficiente? Será que pode ser melhorada?
// dicionário permite associar uma chave(matrícula) a um valor(aluno)
// implementando um dicionário
// Busca através do dicionário;
Console.WriteLine(cSharpColecoes.BuscaMatriculado(5618)); // buscando alguém que não existe

// subistituindo o valor de uma chave; 
Aluno fabio = new Aluno("Fabio Carreira", 5617);
//cSharpColecoes.Matricula(fabio);
cSharpColecoes.SubstituiAluno(fabio);
Console.WriteLine("Quem é o aluno 5617 agora?");
Console.WriteLine(cSharpColecoes.BuscaMatriculado(fabio.NumeroMatricula));
// como o dicionário armazena valores?