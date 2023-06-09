using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bytebank_ATENDIMENTO;

public class ListaDeContaCorrente
{
    private ContaCorrente[] _itens;

    private int _proximaPosicao;

   

    public int Tamanho
    {
        get
        {
            return _proximaPosicao;
        }
    }

   

    // argumento opcional
    public ListaDeContaCorrente(int capacidadeInicial = 5)
    {
        _itens = new ContaCorrente[capacidadeInicial];
        _proximaPosicao = 0;
    }



    public void Adicionar(ContaCorrente conta)
    {
        VerificarCapacidade(_proximaPosicao + 1);

        //Console.WriteLine("");
        _itens[_proximaPosicao] = conta;
        _proximaPosicao++;
    }

    // usando o params eu declaro que vou usar vários parametros;  
    public void AdicionarVarios(params ContaCorrente[] itens)
    {
        foreach(var conta in itens)
        {
            Adicionar(conta);
        }
    }

    public ContaCorrente GetContaCorrente(int indice)
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
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            Console.WriteLine("Aumentando a capacidade da lista");
            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }
    }



    public void Remover(ContaCorrente conta)
    {
        int indiceConta = -1; // é um valor ilegal dentro da array, então estou sinalizando que é um valor invalido;
        for (int i = 0; i < _proximaPosicao; i++)
        {
            // diferente do == o Equals compara equivalência; o == compara a referência na memória
            if (_itens[i].Equals(conta))
            {
                indiceConta = i;
                break;
            }
        }


        for (int i = indiceConta; i < _proximaPosicao - 1; ++i)
        {
            _itens[i] = _itens[i + 1];

        }

        _proximaPosicao--;
        _itens[_proximaPosicao] = null;
    }

    // INDEXADOR;

    public ContaCorrente this[int indice]
    {
        get
        {
            return GetContaCorrente(indice);
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
