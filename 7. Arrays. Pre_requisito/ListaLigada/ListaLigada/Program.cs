List<string> frutas = new List<string>();
frutas.Add("Abacate");
frutas.Add("Banana");
frutas.Add("Caqui");
frutas.Add("Damasco");
frutas.Add("Figo");


frutas.ForEach((fruta) =>
{
    Console.WriteLine(fruta);
});

/*Numa lista temos um problema quando precisamos adicionar ou remover elementos que estão no meio da lista. Porque isso exige maior esforço computacional, de processamento, para dislocar os elementos da lista uma posição para frente ou para trás.
 * Em uma lista pequena isso é feito em um tempo curto, mas em listas grandes, a operação começa a perder em desempenho. 
 * 
 * Uma lista ligada os elementos não precisam estar memorizados em sequência para representar a ordem desejada.
 * Cada elemento contém sua posição anterior, a atual e a seguinte, e chamamos isto de nó, cada elemento é um nó que contém um valor.
 */

LinkedList<string> dias = new LinkedList<string>();
// Adicionando elementos:
// o d4 é um nó que contém a informação que eu passei; o valor está encapsulado
var d4 = dias.AddFirst("Quarta-feira");
// como acessar o valor que está armazenado nesse nó?
Console.WriteLine("d4.Value " + d4.Value);

//adicionar um item anterior ao item já criado;
// preciso de 2 parametros;
var d2 = dias.AddBefore(d4, "Segunda");
// - d2.Nest é igual a d4;
// d4.Previus é igual a d2;

var d3 = dias.AddAfter(d2, "Terça");

var d6 = dias.AddAfter(d4, "Sexta");
var d7 = dias.AddAfter(d6, "Sábado");
var d5 = dias.AddBefore(d6, "Quinta");
var d1 = dias.AddBefore(d2, "Domingo");


// na lista ligada não dá para usar o for
// LINKEDLIST NÃO DÁ SUPORTE PARA O ACESSO DE ÍNDICE!! Não permite = Dias[0];
var quarta = dias.Find("Quarta-feira");
// remover
dias.Remove("Quarta-feira");

foreach (var dia in dias)
{
    Console.WriteLine(dia);
}