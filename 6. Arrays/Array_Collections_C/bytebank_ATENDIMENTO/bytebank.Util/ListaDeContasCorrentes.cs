using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {

        // O objetivo dessa classe é encapsular os comportamentos da minha array:
        // adicionar, remover ou buscar um objeto;

        // defini um campo do tipo ContaCorrente que recebe um array nulo;
        private ContaCorrente[] _itens = null;


        //chamei o construtor da classe e passei como parametro uma valor inicial

       
        public ListaDeContasCorrentes(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }


        // aqui eu recebo apenas um item do tipo conta corrente e coloco esse item na lista de _itens

        private int _proximaPosicao = 0;

        public void Adicionar(ContaCorrente item)
        {

            //forma como o prof fez:
            Console.WriteLine($"Adiconando item na posição {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;

           
        }


        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            Console.WriteLine("Aumentando a capacidade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }



        public void Remover(ContaCorrente conta)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _itens[i];

                if (contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao-1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }



        public void ExibirLista()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    var conta = _itens[i];
                    Console.WriteLine($"Indice [{i}] = Conta: {conta.Conta} - Nº da Agência: {conta.Numero_agencia}");
                }
            }
        }

        // um método que eu consiga acessar um objeto espeícifico do meu array, através do índice 


        public ContaCorrente RecuperarContaNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];

        }

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        // indexadores
        public ContaCorrente this[int indice]
        {
            get
            {
                return RecuperarContaNoIndice(indice);
            }
        }
    }
}
