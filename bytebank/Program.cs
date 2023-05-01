using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;
contaDoAndre.moeda = "R$";

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Luiza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;
contaDaMaria.moeda = "R$";

ContaCorrente contaDoPedro = new ContaCorrente();
contaDoPedro.titular = "Pedro Silva";
contaDoPedro.numero_agencia = 17;
contaDoPedro.conta = "1010-8";
contaDoPedro.saldo = 100;
contaDoPedro.moeda = "R$";

//Saldo inicial contas
Console.WriteLine("Saldo da conta do André = " + contaDoAndre.moeda + contaDoAndre.saldo);
Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.moeda + contaDaMaria.saldo);

//Movimentos do André


contaDoAndre.Depositar(100);

Console.WriteLine("Saldo da conta do André pós-deposito = " + contaDoAndre.moeda + contaDoAndre.saldo);

if (contaDoAndre.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta do André pós-saque =" + contaDoAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para saque.");
}

contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo da conta do André pós-transferência = " + contaDoAndre.moeda + contaDoAndre.saldo);
Console.WriteLine("Saldo da conta da Maria pós-transferência Recebida = " + contaDaMaria.moeda + contaDaMaria.saldo);



//Movimentos da Maria


Console.WriteLine("Tecle enter para fechar ...");
Console.ReadLine();