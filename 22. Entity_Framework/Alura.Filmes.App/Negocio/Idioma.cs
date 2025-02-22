﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Idioma
    {
        public byte Id { get; set; }
        public string Nome { get; set; }

        //nav
        public ICollection<Filme> FilmesFalados { get; set; }
        public ICollection<Filme> FilmesOriginais { get; set; }
        public override string ToString()
        {
            return $"Nome: {Nome}";
        }
    }
}
