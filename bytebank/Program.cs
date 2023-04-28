using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;
contaDoAndre.moeda = "R$";

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.moeda + contaDoAndre.saldo);

Console.WriteLine("Tecle enter para fechar ...");
Console.ReadLine();