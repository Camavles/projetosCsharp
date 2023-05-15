

using Excercicios;


// aqui eu criei o curso; que recebe como parametro o nome do curso e o nome da instrutora;
//Aula aulaIntro = new Aula("Entendendo o básico do C#", 20);
//Aula aulaMeio = new Aula("Aprofundando no C#", 25);

//List<Aula> aulas = new List<Aula>();
//aulas.Add(aulaIntro);
//aulas.Add(aulaMeio);

Curso cSharp = new Curso("Introdução ao C#", "Camila Alves");
cSharp.Adiciona(new Aula("Entendendo o C#", 35));
cSharp.Adiciona(new Aula("Aprofundando o C#", 20));
cSharp.Adiciona(new Aula("Lidando com listas", 45));


//Imprimir(aulas);


void Imprimir(List<Aula> lista)
{
    Console.Clear();
    foreach (var aula in lista)
    {
        Console.WriteLine(aula);
    }
}


Imprimir(cSharp.Aulas);

// essa expressão é para quando eu quiser comprar uma propriedade/atributo da minha classe; mas se eu quiser comparar outro campo/atributo
// entender essa parte do icomparable;
// rever aula. 
cSharp.Aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
Imprimir(cSharp.Aulas);
