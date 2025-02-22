﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank_ADM.Funcionarios
{
    // classe abstrata
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }

        // utilizando a visibilidade protected;
        public double Salario { get; protected set; }


        // utilizando o virtual eu consigo dizer q eu posso reecrever esse método pela classe derivada;
        //public virtual double GetBonificacao()
        //{
        //    return this.Salario * 0.1 /*+ this.Salario*/; 
        //}


        // como é um método abstrato, toda classe que herda esse método tem a obrigação de fazer a implementação;
        public abstract double GetBonificacao();


        //static --> propriedade da classe e não do objeto;
        public static int TotalFuncionarios { get; private set; }

        
        // obrigando a passagem do cpf
        public Funcionario(string cpf, double salario)
        {
            TotalFuncionarios++;
            this.Cpf = cpf;
            this.Salario = salario;

            // testando a ordem de execução; da classe base vem primeiro;
            // Console.WriteLine("Criando um funcionário");
            //** mesmo sendo uma classe abstrata, ela pode possuir métodos concretos; 
        }


        public abstract void AumentarSalario();

        //herança
 


    }
}
