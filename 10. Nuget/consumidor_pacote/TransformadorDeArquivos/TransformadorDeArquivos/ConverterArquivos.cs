using Newtonsoft.Json;
using System.Reflection.Metadata;
using System.Xml;
using System.Xml.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace TransformadorDeArquivos
{
    public static class ConverterArquivos <T>
    {

        public static bool GetListEmXML(List<T> list)
        {
            if (list == null)
            {
                Console.WriteLine("Não há dados para conversão");
            }
            else
            {
                try
                {
                    var serializer = new XmlSerializer(typeof(List<T>));

                    var enderecoDoNovoArquivo = "novoArquivoEmXml.xml";
                    using (var fs = new FileStream(enderecoDoNovoArquivo, FileMode.Create))
                    using (var escritor = new StreamWriter(fs))
                    {

                        serializer.Serialize(escritor, list);

                    }
                    Console.WriteLine("Arquivo salvo e convertido em XML");
                    Console.ReadKey();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                
                
            }

            return true;
        }


        public static bool GetListJson(List<T> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Não há dados para conversão");
            }
            else
            {
                string json = JsonConvert.SerializeObject(list, Formatting.Indented);


                try
                {

                    var endereco = "novoArquivoJson.json";
                    using (var fs = new FileStream(endereco, FileMode.Create))
                    using (var escritor = new StreamWriter(fs))
                    {
                        escritor.WriteLine(json);
                    }
                    Console.WriteLine("Arquivo salvo e convertido em json");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

               
            }

            return true;

        }
    }
}