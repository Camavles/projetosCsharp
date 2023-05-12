

//************************************ AULA SOBRE ARRAYS ****************************

string aulaIntro = "Introduções às Coleções";
string aulaModelando = "Modelando a Classe Aula";
string aulaSets = "Trabalhando com Conjuntos";



// primeiro eu tenho que dizer quantos elementos minha array tem;
//string[] aulas = new string[] // declaração implícita
//{
//    aulaIntro,
//    aulaModelando,
//    aulaSets
//};

string[] aulas = new string[3];
aulas[0] = aulaIntro;
aulas[1] = aulaModelando;
aulas[2] = aulaSets;

// quando eu dou um cw em aulas, ele apenas mostra que existe um array, mas não mostra os elementos;

Imprimir(aulas);

// vai receber um array de strings
Console.WriteLine(aulas[0]);
Console.WriteLine(aulas.Length); // o tamanho vai ser a quantidade de elementos
Console.WriteLine(aulas[aulas.Length - 1]); // length - 1 vai pegar quase que pelo índice;
// mofificando o valor de um elemento da array;

aulas[0] = "Trabalhando com Arrays";

Imprimir(aulas);
static void Imprimir(string[] array)
{
    //foreach (string aula in array)
    //{
    //    Console.WriteLine(aula);
    //}

    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

//método statico da classe Array = IndexOf
Console.WriteLine("A aula Modelando está no índice: " + Array.IndexOf(aulas,aulaModelando));
Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

Array.Reverse(aulas); // não precisa passar o reverse no cw
Imprimir(aulas);

Array.Reverse(aulas); // desrevertendo
Imprimir(aulas);

Array.Resize(ref aulas, 2);
Imprimir(aulas); // faz uma cópia interna para mudar o tamanho da array;

Array.Resize(ref aulas, 3); // refiz o tamanho, mas não tem nada na última posição
Imprimir(aulas);

aulas[aulas.Length - 1] = "Aula de Conclusão";
Imprimir(aulas);

Console.WriteLine();
Array.Sort(aulas);
Imprimir(aulas);


string[] copia = new string[2];
// array copiado, índice que inicia a cópia, array de destino, ínicio da cópia, quantos elementos quero copiar;
Array.Copy(aulas, 0, copia, 0, 2);

Console.WriteLine();
Imprimir(copia);


//se eu quiser copiar todos os elementos: utilizo um método de clonagem 
// faço uma conversão para array de strings;
string[] clone = aulas.Clone() as string[];
Imprimir(clone);

// se eu quiser retirar ou "limpar" elementos do meu array:
// array, indice, a quantidade de elementos;
Console.WriteLine();
Array.Clear(clone, 1, 2);
Imprimir(clone);