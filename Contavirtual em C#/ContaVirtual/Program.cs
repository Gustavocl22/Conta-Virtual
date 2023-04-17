using ContaVirtual;
using ContaVirtual.ContaCorrente;

ContaCorrente conta = new ContaCorrente();
conta.saldo = 100;
conta.numero_agencia = "1245-x";

ContaCorrente conta1 = new ContaCorrente();
conta1.saldo = 50;
conta1.numero_agencia = "5875-x";

conta.Transferir(50,conta1);

System.Console.WriteLine("Saldo pos tranferencia = " + conta.saldo);
System.Console.WriteLine("saldo pos tranferencia = " + conta1.saldo);


Console.ReadLine();

