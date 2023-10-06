using System.Collections.Generic;

//TESTAR OVERRRIDE COM DICTIONARY


TestandoDicionario();
static void TestandoDicionario()
{
    Dictionary<int, string> dicionario = new Dictionary<int, string>();
    dicionario.Add(1, "Maria");
    dicionario.Add(2, "Pedro");
    dicionario.Add(3, "Roberta");

    // essa forma de acesso é diferente de um array, pois eu estou acessando pela chave e não pelo indice;
    //Console.WriteLine(dicionario["3"]);


    // a parte mais importante não é a Key e sim o value;
    // essa string resultado é uma variável que armazena o resultado.
    //if (dicionario.TryGetValue(1, out string resultado))
    //{
    //    Console.WriteLine(resultado);
    //}
    //else
    //{
    //    Console.WriteLine("Deu ruim");
    //}


    foreach(KeyValuePair<int, string> item  in dicionario)
    {
        // é uma forma de exibir os valores fazendo com que eles sejam preenchidos dentrp da string, porém por que dessa forma?
        
        Console.WriteLine("chave: {0}, valor: {1}", item.Key, item.Value);
       
    }

}

    

    



