using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;


namespace bytebank_ATENDIMENTO.bytebank.Atendimento
{
 //#nullable disable --> retira os alertas em verde;
    internal class ByteBankAtendimento
    {
        //List
        // o list nos ajuda a manter a segurança no código quando eu digo que tipo de objeto eu quero receber na lista;
        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>() {
        new ContaCorrente(95, "123456-X") {Saldo=100, Titular = new Cliente{Cpf="123.456", Nome = "Camila"}},
        new ContaCorrente(94, "987321-W") {Saldo=60, Titular = new Cliente{Cpf="785.321", Nome = "Maria"}},
        new ContaCorrente(95, "951258-X") {Saldo=200, Titular = new Cliente{Cpf="212.354", Nome = "Gabi"}}
        };


        public void AtendimentoCliente()
        {

            try
            {
                char opcao = '0';
                while (opcao != '6')
                {
                    Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("===       Atendimento       ===");
                    Console.WriteLine("===1 - Cadastrar Conta      ===");
                    Console.WriteLine("===2 - Listar Contas        ===");
                    Console.WriteLine("===3 - Remover Conta        ===");
                    Console.WriteLine("===4 - Ordenar Contas       ===");
                    Console.WriteLine("===5 - Pesquisar Conta      ===");
                    Console.WriteLine("===6 - Sair do Sistema      ===");
                    Console.WriteLine("===============================");
                    Console.WriteLine("\n\n");
                    Console.Write("Digite a opção desejada: ");
                    // desse retorno eu quero a primeira posição do que foi digitado

                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch (Exception excecao)
                    {
                        throw new ByteBankException(excecao.Message);
                    }

                    switch (opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarContas();
                            break;
                        case '3':
                            RemoverConta();
                            break;
                        case '4':
                            OrdenarContas();
                            break;
                        case '5':
                            PesquisarContas();
                            break;
                        case '6':
                            EncerrarAplicacao();
                            break;
                        default:
                            Console.WriteLine("Opcao não implementada.");
                            break;
                    }
                }

            }
            catch (ByteBankException excecao)
            {
                Console.WriteLine($"{excecao.Message}");
            }

        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("Encerrando a aplicação!");
            Console.ReadKey();
        }

        private void PesquisarContas()
        {

            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===    PESQUISAR CONTAS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA ou (2)CPF TITULAR  ou (3) Nº Agência? ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Write("Informe o número da Conta: ");
                        string _numeroConta = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Informe o CPF do Titular: ");
                        string _cpf = Console.ReadLine();
                        ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                        Console.WriteLine(consultaCpf.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Informe o Nº da Agência: ");
                        int _numeroAgencia = int.Parse(Console.ReadLine());
                        var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
                        ExibirListaDeContas(contasPorAgencia);
                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("Opção não implementada.");
                    break;
            }

        }

        private void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
        {
            if (contasPorAgencia == null)
            {
                Console.WriteLine("A consulta não retornou dados!");
            }
            else
            {
                foreach (var conta in contasPorAgencia)
                {
                    Console.WriteLine(conta.ToString());
                }
            }
        }


        private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
        {
            // sintaxe de consulta Linq
            var consulta = (
                from conta in _listaDeContas
                where conta.Numero_agencia == numeroAgencia
                select conta).ToList();
            return consulta;
        }

        private ContaCorrente ConsultaPorCPFTitular(string? cpf)
        {
            //ContaCorrente conta = null;
            //for (int i = 0; i < _listaDeContas.Count; i++)
            //{
            //    if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
            //    {
            //        conta = _listaDeContas[i];
            //    }
            //}
            //// eu salvo o meu resultado em uma variável nula e depois pego essa varivável e devolvo;
            //return conta;

            // Sintaxe de consulta Linq
            var conta = _listaDeContas.Where((conta) => conta.Titular.Cpf.Equals(cpf)).FirstOrDefault();

            //var conta =  _listaDeContas.Where(conta => conta.Titular.Cpf == informacao || conta.Conta == informacao).FirstOrDefault();
            return conta;
        }

        private ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
        {
            //ContaCorrente conta = null;
            //for (int i = 0; i < _listaDeContas.Count; i++)
            //{
            //    if (_listaDeContas[i].Conta.Equals(numeroConta))
            //    {
            //        conta = _listaDeContas[i];
            //    }
            //}

            var conta = _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();

            return conta;

        }


        private void OrdenarContas()
        {
            // uma forma de fazer o sort
            //_listaDeContas.Sort((este, outro) => este.Conta.CompareTo(outro.Conta));
            _listaDeContas.Sort();
            Console.WriteLine("Lista de contas ordenadas");
            Console.ReadKey();

        }

        private void RemoverConta()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===      REMOVER CONTAS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.Write("Informe o número da Conta: ");
            string numeroConta = Console.ReadLine();
            ContaCorrente conta = null;

            foreach (var item in _listaDeContas)
            {
                if (item.Conta.Equals(numeroConta))
                {
                    conta = item;
                }
            }
            if (conta != null)
            {
                _listaDeContas.Remove(conta);
                Console.WriteLine("Conta Removida da Lista!");
            }
            else
            {
                Console.WriteLine("Conta para remoção não encontrada!");
            }
            Console.ReadKey();
        }

        private void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===     LISTA DE CONTAS     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");

            if (_listaDeContas.Count <= 0)
            {
                Console.WriteLine("Não há contas cadastradas!");
                Console.ReadKey();
                return;
            }
            foreach (var conta in _listaDeContas)
            {
                Console.WriteLine(conta.ToString());
                Console.ReadKey();
            }
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===   CADASTRO DE CONTAS    ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.WriteLine("=== Informe dados da conta ===");
            //Console.Write("Número da conta: ");
            //string numeroConta = Console.ReadLine();

            Console.Write("Número da Agência: ");
            // pegando o valor e transformando em um int
            int numeroAgencia = int.Parse(Console.ReadLine());
            ContaCorrente conta = new ContaCorrente(numeroAgencia);

            Console.WriteLine($"Número da Conta [NOVA] : {conta.Conta}");

            Console.Write("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.Write("Informe o nome do Titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.Write("Informa o  CPF do Titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.Write("Innforme a Profissão do Titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(conta);

            Console.WriteLine("Conta cadastrada com sucesso!");
            Console.ReadKey();
        }
    }
}
