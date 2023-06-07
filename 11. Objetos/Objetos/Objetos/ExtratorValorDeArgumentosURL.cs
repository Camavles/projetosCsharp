using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class ExtratorValorDeArgumentosURL
    {

        
        // com o readonly, eu só posso atribuir diretamente ou no construtor;
        private readonly string _argumentos;
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            // método estático da classe
            if(String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento URL não pode ser nulo ou vazio", nameof(url));
            }

            //no meu _argumentos está guardada a parte da URL q eu quero recuperar;

            int indexQuestionMark = url.IndexOf('?');
            _argumentos = url.Substring(indexQuestionMark + 1);
            
            // tive que setar
            this.URL = url;
        }

        public string GetValue(string nomeParamentro)
        {
            nomeParamentro = nomeParamentro.ToUpper();

            string argumentosEmCaixaAlta = _argumentos.ToUpper();

            string termo = nomeParamentro + "=";

            int indexParam = argumentosEmCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indexParam + termo.Length);

            int indexEComercial = resultado.IndexOf('&');
            
            if(indexEComercial == -1)
            {
                return resultado;
            }
            return resultado.Remove(indexEComercial);
        }

 
    }
}
