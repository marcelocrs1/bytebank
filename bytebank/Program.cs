using bytebank.Contas;
using bytebank.Titular;

//Dados pessoais dos clientes
Cliente clienteAndre = new Cliente();
clienteAndre.Nome = "André Silva";
clienteAndre.Cpf = "12332332405";
clienteAndre.Profissao = "Analista";

Cliente clienteMariaLuiza = new Cliente();
clienteMariaLuiza.Nome = "Maria Luiza";
clienteMariaLuiza.Cpf = "15625678689";
clienteMariaLuiza.Profissao = "Engenheira Civil";

Cliente clientePedro = new Cliente();
clientePedro.Nome = "Pedro Silva";
clientePedro.Cpf = "14556787678";
clientePedro.Profissao = "Software Developer";

//Dados das contas dos clientes
ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.Titular = clienteAndre;
contaDoAndre.Numero_agencia = 15;
contaDoAndre.Conta = "1010-X";
contaDoAndre.SetSaldo(100);
contaDoAndre.Moeda = "R$";

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.Titular = clienteMariaLuiza;
contaDaMaria.Numero_agencia = 17;
contaDaMaria.Conta = "1010-5";
contaDaMaria.SetSaldo(350);
contaDaMaria.Moeda = "R$";

ContaCorrente contaDoPedro = new ContaCorrente();
contaDoPedro.Titular = clientePedro;
contaDoPedro.Numero_agencia = 17;
contaDoPedro.Conta = "1010-8";
contaDoPedro.SetSaldo(100);
contaDoPedro.Moeda = "R$";

//Saldo inicial contas
Console.WriteLine("Saldo da conta do " + contaDoAndre.Titular.Nome + " = " + contaDoAndre.Moeda + contaDoAndre.GetSaldo());
Console.WriteLine("Saldo da conta do " + contaDaMaria.Titular.Nome + " = " + contaDaMaria.Moeda + contaDaMaria.GetSaldo());


//Movimentos do André


contaDoAndre.Depositar(100);

Console.WriteLine("Saldo da conta do André pós-deposito = " + contaDoAndre.Moeda + contaDoAndre.GetSaldo());

if (contaDoAndre.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta do André pós-saque =" + contaDoAndre.GetSaldo());
}
else
{
    Console.WriteLine("Saldo insuficiente para saque.");
}

contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo da conta do André pós-transferência = " + contaDoAndre.Moeda + contaDoAndre.GetSaldo());
Console.WriteLine("Saldo da conta da Maria pós-transferência Recebida = " + contaDaMaria.Moeda + contaDaMaria.GetSaldo());



//Movimentos da Maria


Console.WriteLine("Tecle enter para fechar ...");
Console.ReadLine();