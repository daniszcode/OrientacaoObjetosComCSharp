using OrientacaoObjetosComCSharp;

ContaBancaria conta_1 = new ContaBancaria();
ContaBancaria conta_2 = new ContaBancaria();

conta_1.numero_agencia = 15;
conta_1.saldo = 125;
conta_1.conta = "123567";
conta_2.numero_agencia = 15;
conta_2.saldo = 155;
conta_2.conta = "conta_2";
//conta_1.chavePix.cpf = "15154848";
//conta_1.cadastroCliente.profissao = "professor";
//conta_1.cadastroCliente.renda = 4000;
//conta_1.cadastroCliente.setClienteGold();
//conta_1.cadastroCliente.setClientePremium();
//conta_1.cadastroCliente.setClienteStandard();

conta_1.depositarSaldo(50);
Console.WriteLine($"saldo: {conta_1.saldo}");
conta_1.sacarSaldo(350);
Console.WriteLine($"saldo: {conta_2.saldo}");
conta_2.transferirSaldo(100, conta_1); 
//conta_1.getTransferencia();



//Console.WriteLine(conta_1.cadastroCliente.is_premium);
//Console.WriteLine(conta_1.cadastroCliente.is_gold);
//Console.WriteLine(conta_1.cadastroCliente.is_standard);

Console.ReadLine();

