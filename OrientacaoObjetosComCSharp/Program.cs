using OrientacaoObjetosComCSharp.Cliente;
using OrientacaoObjetosComCSharp.Conta;

ContaBancaria conta_1 = new ContaBancaria(1, "123-a", "Eve");
ContaBancaria conta_2 = new ContaBancaria(2, "1234-a", "Eva");
Titular cliente_1 = new Titular();
cliente_1.id = 1;
cliente_1.profissao = "professora";
cliente_1.renda = 4000;
conta_1.depositarSaldo(300);
//conta_1.numero_agencia = 15;
//conta_1.conta = "123567";
conta_1.cadastroCliente = cliente_1;   //faz a ligação entre as classes
conta_1.cadastroCliente.nome = cliente_1.nome;
conta_1.cadastroCliente.profissao = cliente_1.profissao;
conta_1.cadastroCliente.setTipoClienteCliente();

//conta_2.numero_agencia = 15;
//conta_2.saldo = 155;
//conta_2.conta = "conta_2";
//conta_1.chavePix.cpf = "15154848";
//conta_1.cadastroCliente.profissao = "professor";
//conta_1.cadastroCliente.renda = 4000;


//conta_1.depositarSaldo(50);
//Console.WriteLine($"saldo: {conta_1.saldo}");
//conta_1.sacarSaldo(350);
//Console.WriteLine($"saldo: {conta_2.saldo}");
//conta_2.transferirSaldo(100, conta_1);
//Console.WriteLine($"saldo: {conta_2.saldo}");
//conta_1.transferirSaldo(300, conta_2);
//Console.WriteLine($"saldo: {conta_1.saldo}");
//Console.WriteLine(conta_1.chavePix.cpf);
//conta_1.getTransferencia();
//Console.WriteLine(conta_1.cadastroCliente.is_premium);
//Console.WriteLine(conta_1.cadastroCliente.is_gold);
//Console.WriteLine(conta_1.cadastroCliente.is_standard);
Console.WriteLine($"{conta_1.cadastroCliente.nome} {conta_1.cadastroCliente.profissao} {conta_1.cadastroCliente.renda} {conta_1.Saldo} {ContaBancaria.TotalDeContas}" );

Console.ReadLine();

