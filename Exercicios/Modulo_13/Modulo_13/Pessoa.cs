using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modulo_13
{
    public class Pessoa
    {
        private string nome;

        private string data_Nascimento;

        private double altura;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Data_Nascimento
        {
            get { return data_Nascimento; }
            set { data_Nascimento = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        // método para imprimir todos os dados;
        public override string ToString()
        {
            return $"Nome: {nome}, Data de Nascimento: {data_Nascimento}, Altura: {altura}";
        }

        //método para calcular idade

        public int CalcularIdade(int anoAtual)
        {
            var data = data_Nascimento;
            var separaPorBarra = data.Split('/');
            var anoNascimento = separaPorBarra[2];
            var converteAnoNascimento = int.Parse(anoNascimento);

            var idade = anoAtual - converteAnoNascimento;

            return idade;
        }

        #region 
        // outra forma de resolver: passando os campos para serem setados no construtor;

        //private string nome;

        //private string data_Nascimento;

        //private double altura;


        //public string Nome
        //{
        //    get { return nome; }
        //    protected set { nome = value; }
        //}

        //public string Data_Nascimento
        //{
        //    get { return data_Nascimento; }
        //    protected set { data_Nascimento = value; }
        //}

        //public double Altura
        //{
        //    get { return altura; }
        //    protected set { altura = value; }
        //}




        //// testando construtor com Regex;
        //public Pessoa(string data, string name, double height)
        //{
        //    var padrao = "[0-9]{2}/[0-9]{2}/[0-9]{4}";
        //    var verifica = Regex.IsMatch(data, padrao);

        //    if (verifica == true)
        //    {
        //        data_Nascimento = data;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Argumento inválido!");
        //    }

        //    this.nome = name;
        //    this.altura = height;


        //}

        #endregion




    }




}
