﻿using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }

        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; set; }

        public virtual IList<PromocaoProduto> Promocoes { get; set; }
        public virtual IList<Compra> Compras { get; set; }


        public override string ToString()
        {
            return $"Nome: {this.Nome}, Categoria: {this.Categoria}, Preco: {this.PrecoUnitario} ";
        }
    }
}