

using FastFood;

Cliente cliente1 = new Cliente();
cliente1.endereco = new Endereco();
cliente1.pedido = new Pedido();

cliente1.Nome = "Camila";
cliente1.Cpf = "123.456.789-0";
cliente1.Telefone = "13 9925-1230";
cliente1.Email = "cami@lilili";

Console.WriteLine(cliente1.Email);

//cliente1.pedido.qtdItens = 6;
//cliente1.pedido.valorUnitario = 15;
//cliente1.pedido.CalcularValorTotal(6, 15);


//cliente1.endereco.rua = "Rua Allili";
//cliente1.endereco.cep = "0788-00";
//cliente1.endereco.bairro = "Jd. das Graças";
//cliente1.endereco.cidade = "Cotia";
//cliente1.endereco.estado = "Pernambuco";


//Console.WriteLine("Nome: " + cliente1.Nome);
//Console.WriteLine("CPF: " + cliente1.Cpf);
//Console.WriteLine();

//Console.WriteLine("O Valor Total do seu pedido é R$ " + cliente1.pedido.CalcularValorTotal(6, 15));
//Console.WriteLine();
//Console.WriteLine("Este é o endereço de entregra: ");
//Console.WriteLine("Rua: " + cliente1.endereco.rua);
//Console.WriteLine("Cep: " + cliente1.endereco.cep);
//Console.WriteLine("Bairro: " + cliente1.endereco.bairro);
//Console.WriteLine("Cidade: " + cliente1.endereco.cidade);
//Console.WriteLine("Estado: " + cliente1.endereco.estado);











