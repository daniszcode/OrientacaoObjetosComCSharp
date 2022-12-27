﻿using OrientacaoObjetosComCSharp.Cliente;
using OrientacaoObjetosComCSharp.Conta;

ContaBancaria conta_1 = new ContaBancaria(1, "123-a", new Titular("Eve", 4000, "professora"));
ContaBancaria conta_2 = new ContaBancaria(2, "1234-a", new Titular("Eva", 18000, "medica"));

conta_1.depositarSaldo(300);
conta_1.cadastroCliente.setTipoClienteCliente();

conta_1.chavePix = new ChavePix();
conta_2.chavePix = new ChavePix();

conta_1.chavePix.Cpf = "012345678";
conta_2.chavePix.Email = "Eva@hotmail.com";
conta_1.setPix(15, conta_2);
//conta_1.sacarSaldo(350);
//conta_2.transferirSaldo(100, conta_1);
//conta_1.transferirSaldo(300, conta_2);
//Console.WriteLine($"saldo: {conta_1.saldo}");
//Console.WriteLine(conta_1.chavePix.cpf);
//conta_1.getTransferencia();
//Console.WriteLine(conta_1.cadastroCliente.is_premium);
//Console.WriteLine(conta_1.cadastroCliente.is_gold);
//Console.WriteLine(conta_1.cadastroCliente.is_standard);
//Console.WriteLine($"{conta_1.cadastroCliente.nome} {conta_1.cadastroCliente.profissao} {conta_1.cadastroCliente.Renda} {conta_1.Saldo} {ContaBancaria.TotalDeContas}" );
Console.WriteLine(conta_2.Saldo);
Console.ReadLine();

