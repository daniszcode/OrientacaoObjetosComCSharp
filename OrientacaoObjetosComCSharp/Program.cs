using OrientacaoObjetosComCSharp;

ContaBancaria conta_1 = new ContaBancaria();
conta_1.titular = "André Silva";
conta_1.numero_agencia = 15;
conta_1.saldo = 125;
conta_1.conta = "12356";

Console.WriteLine(conta_1.saldo);
conta_1.DepositarSaldo(50);
Console.WriteLine($"saldo: {conta_1.saldo}");

Console.ReadLine();