using OrientacaoObjetosComCSharp;

ContaBancaria conta_1 = new ContaBancaria();
conta_1.titular = "André Silva";
conta_1.numero_agencia = 15;
conta_1.saldo = 125.50;
conta_1.conta = "12356";
conta_1.chavePix.cpf = "0125893454";

Console.WriteLine($"saldo: {conta_1.saldo}");
Console.ReadLine();