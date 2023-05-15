using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeObjetos
{
    public class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        // construtor
        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get { return titulo; } set { titulo = value; } }
        public int Tempo { get { return tempo; } set { tempo = value; } }

        public int CompareTo(object? obj)
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(that.titulo);
            //return this.tempo.CompareTo(that.tempo);
        }

        public override string ToString()
        {
            return $"[Título: {this.titulo}, Tempo: {this.tempo}minutos]"; 
        }
    }
}
