
string aulaIntro = "Introdução às Coleções";



string aulaModelando = "Modelando a Classe aula";
string aulaSets = "Trabalhando com Conjuntos";


//List<string> aulas = new List<string>
//{
//    aulaIntro, aulaModelando, aulaSets
//};

// quando eu não defino a minha lista logo de cara;
// array dinamico
List<string> aulas = new List<string>();
aulas.Add(aulaIntro);
aulas.Add(aulaModelando);
aulas.Add(aulaSets);


Imprimir(aulas);
Console.WriteLine("Primeira aula: " + aulas[0]);
Console.WriteLine("Primeira aula: " + aulas.First());

Console.WriteLine("Última aula: " + aulas[aulas.Count - 1]);
Console.WriteLine("Primeira aula: " + aulas.Last());

Console.WriteLine();
aulas[0] = "Trabalhando com Listas";
Imprimir(aulas);

// encontra a primeira ocorrencia de trabalhando
Console.WriteLine("A primeira aulas 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));
// encontra a última aula que tenha a palavra trabalhando
Console.WriteLine("A última aulas 'Trabalhando' é: " + aulas.Last(aula => aula.Contains("Trabalhando")));


// retorna o primeiro elemento de uma sequencia o um default, caso não tenha esse elemento.
Console.WriteLine("A primeira aulas 'Conclusão' é: " + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

aulas.Reverse();
Imprimir(aulas);

Console.WriteLine();

// remover o último item a partir do índice
// remove pelo índice
aulas.RemoveAt(aulas.Count - 1);
Imprimir(aulas);

Console.WriteLine();
aulas.Add("Conclusão");
Imprimir(aulas);

Console.WriteLine();
aulas.Sort();
Imprimir(aulas);

// fazendo uma cópia de uma lista a partir do penultimo elemento
List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
Imprimir(copia);
Console.WriteLine();
Console.WriteLine("Clone");
List<string> clone = new List<string>(aulas);
Imprimir(clone);

Console.WriteLine();
clone.RemoveRange(clone.Count - 2, 2);
Imprimir(clone);


static void Imprimir(List<string> aulas)
{
    //for (int i = 0; i < aulas.Count; i++)
    //{
    //    Console.WriteLine(aulas[i]);
    //}

    aulas.ForEach((aula) => 
    {
        Console.WriteLine(aula);
    });

}