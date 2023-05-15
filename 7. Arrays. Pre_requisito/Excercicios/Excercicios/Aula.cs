using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercicios
{
    public class Aula
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get { return titulo; } set { titulo = value; } }

        public int Tempo { get {  return tempo; } set {  tempo = value; } }

        // retorna uma string que representa o objeto;
        // método da classe Object que retorna o que eu peço; faço uma sobrescrita 
        public override string ToString()
        {
            return $"[Título: {this.titulo}, Tempo: {this.tempo} minutos]";
        }

    }
}
