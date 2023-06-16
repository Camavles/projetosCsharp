

partial class Program
{
    static void Iteracao()
    {

        //A instrução for deve ser usada quando você sabe o número de vezes que precisa iterar por meio de um bloco de código antes do tempo.
        //A instrução for permite que você controle a maneira como cada iteração é manipulada.

        //for(int i = 0; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}


        //Console.WriteLine("Diferença");


        //for (int i = 10; i >= 0 ; i--)
        //{
        //    Console.WriteLine(i);
        //}

        // se eu qusier sair do laço com base em alguma condição:

        //for(int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(i);
        //    if (i == 7) break;
        //}

        string[] names = { "Alex", "Eddie", "David", "Michael" };
        //for (int i = names.Length - 1; i >= 0; i--)
        //{
        //    Console.WriteLine(names[i]);
        //}

        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "Eddie")
            {
                names[i] = "Camila";
                break; // botei o break para sair do laço assim que achar;
            }

        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}