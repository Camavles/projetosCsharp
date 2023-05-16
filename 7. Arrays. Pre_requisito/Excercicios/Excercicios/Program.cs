

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


//Imprimir(cSharp.Aulas);

// essa expressão é para quando eu quiser comprar uma propriedade/atributo da minha classe sem modificar a classe;
//cSharp.Aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
//Imprimir(cSharp.Aulas);

// sort() após mexer na classe;
cSharp.Aulas.Sort();
//Imprimir(cSharp.Aulas);



cSharp.Matricula(new Aluno("Camila Alves", 5556));
cSharp.Matricula(new Aluno("Raphael Vieira", 5656));

Aluno a3 = new Aluno("José Ribeiro", 2023);
Aluno a4 = new Aluno("Manoel Silva", 2024);

cSharp.Matricula(a3);
cSharp.Matricula(a4);

// comparação com equals
Aluno zezinho = new Aluno("José Ribeiro", 2023);

// esse foreach só funcionou pq eu escrivi um override no ToString();
//foreach(var aluno in cSharp.Alunos)
//{
//    Console.WriteLine(aluno);
//}

Console.WriteLine("José e Zenhinho são iguais?");
Console.WriteLine();
//estou comparando os nomes;
Console.WriteLine(a3.Equals(zezinho));
