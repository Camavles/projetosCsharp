using Newtonsoft.Json;
using RevisaoArquivos.Contas;
using System.Xml.Serialization;

TestaAplicacao();
void TestaAplicacao()
{
    ContaCorrente conta1 = new ContaCorrente(23, "1010-X");
    conta1.titular = new Cliente { Nome = "Camila", Cpf = "12345" };
    //conta1.Depositar(50);

    ContaCorrente conta2 = new ContaCorrente(24, "2020-Z");
    conta2.titular = new Cliente { Nome = "Rapha", Cpf = "5892" };
    //conta1.Transfere(conta2, 25);

    List<ContaCorrente> listaDeContas = new List<ContaCorrente>() { conta1, conta2, new ContaCorrente(25, "4040-W") };

    //foreach(var conta in listaDeContas)
    //{
    //    Console.WriteLine(conta);
    //}

    //serializando um arquivo em XML
    //var serializer = new XmlSerializer(listaDeContas.GetType());

    //var caminho = "arquivoTesteXML.xml";
    //using (var fs = new FileStream(caminho, FileMode.Create))
    //using (var escritor = new StreamWriter(fs))
    //{
    //    serializer.Serialize(escritor, listaDeContas);
    //}
    //Console.WriteLine("Arquivo Convertido");
    //Console.ReadKey();


    // Convertendo em Json
    var json = JsonConvert.SerializeObject(listaDeContas, Formatting.Indented);
    var endereco = "novoArqEmJson.json";

    using(var fs = new FileStream(endereco, FileMode.Create))
    using(var escritor = new StreamWriter(fs))
    {
        escritor.Write(json);
    }
    Console.WriteLine("Arquivo salvo em json");
    Console.ReadKey();


}