using ListaDeObjetos;

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
void Imprimir(IList<Aula> aulas)
{

    foreach (var aula in aulas)
    {
        Console.WriteLine(aula);
    }

}




Curso cSharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
// code smells - estou manipulando diretamente os campos de uma classe;
// exposição indecente 
cSharpColecoes.Adiciona(new Aula("Working with lists", 21));
Imprimir(cSharpColecoes.Aulas);