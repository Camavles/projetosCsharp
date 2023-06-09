using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bytebank_ATENDIMENTO;

public class Lista <T>
{
    private T[] _itens;

    private int _proximaPosicao;

   

    public int Tamanho
    {
        get
        {
            return _proximaPosicao;
        }
    }

   

    // argumento opcional
    public Lista(int capacidadeInicial = 5)
    {
        _itens = new T[capacidadeInicial];
        _proximaPosicao = 0;
    }



    public void Adicionar(T item)
    {
        VerificarCapacidade(_proximaPosicao + 1);

        //Console.WriteLine("");
        _itens[_proximaPosicao] = item;
        _proximaPosicao++;
    }

    // usando o params eu declaro que vou usar vários parametros;  
    public void AdicionarVarios(params T[] itens)
    {
        foreach(var item in itens)
        {
            Adicionar(item);
        }
    }

    public T GetItem(int indice)
    {
        if (indice < 0 || indice >= _proximaPosicao)
        {
            throw new ArgumentOutOfRangeException(nameof(indice));
        }

        return _itens[indice];
    }

    private void VerificarCapacidade(int tamanhoNecessario)
    {
        if (_itens.Length >= tamanhoNecessario)
        {
            return;
        }
        else
        {

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            // aqui eu crio um novo array passando o array antigo para ocupar algumas posições;
            T[] novoArray = new T[novoTamanho];

            Console.WriteLine("Aumentando a capacidade da lista");
            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }
    }



    public void Remover(T item)
    {
        int indiceItem = -1; // é um valor ilegal dentro da array, então estou sinalizando que é um valor invalido;
        for (int i = 0; i < _proximaPosicao; i++)
        {
            // diferente do == o Equals compara equivalência; o == compara a referência na memória
            if (_itens[i].Equals(item))
            {
                indiceItem = i;
                break;
            }
        }


        for (int i = indiceItem; i < _proximaPosicao - 1; ++i)
        {
            _itens[i] = _itens[i + 1];

        }

        _proximaPosicao--;
        //_itens[_proximaPosicao] = default(T);
    }

    // INDEXADOR;

    public T this[int indice]
    {
        get
        {
            return GetItem(indice);
        }

    }




    //metodos com argumentos opcionais;
    //public bool Testar(string texto = "Olá", int numero = 5)
    //{
    //    Console.WriteLine(texto);
    //    Console.WriteLine(numero);
    //    return true;
    //}



}
