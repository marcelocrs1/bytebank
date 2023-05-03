using bytebank.Contas;
using bytebank.Titular;

//Dados pessoais dos clientes
Cliente clienteAndre = new Cliente();
clienteAndre.nome = "André Silva";
clienteAndre.cpf = "12332332405";
clienteAndre.profissao = "Analista";

Cliente clienteMariaLuiza = new Cliente();
clienteMariaLuiza.nome = "Maria Luiza";
clienteMariaLuiza.cpf = "15625678689";
clienteMariaLuiza.profissao = "Engenheira Civil";

Cliente clientePedro = new Cliente();
clientePedro.nome = "Pedro Silva";
clientePedro.cpf = "14556787678";
clientePedro.profissao = "Software Developer";

//Dados das contas dos clientes
ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = clienteAndre;
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.SetSaldo(100);
contaDoAndre.moeda = "R$";

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = clienteMariaLuiza;
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.SetSaldo(350);
contaDaMaria.moeda = "R$";

ContaCorrente contaDoPedro = new ContaCorrente();
contaDoPedro.titular = clientePedro;
contaDoPedro.numero_agencia = 17;
contaDoPedro.conta = "1010-8";
contaDoPedro.SetSaldo(100);
contaDoPedro.moeda = "R$";

//Saldo inicial contas
Console.WriteLine("Saldo da conta do " + contaDoAndre.titular.nome + " = " + contaDoAndre.moeda + contaDoAndre.GetSaldo());
Console.WriteLine("Saldo da conta do " + contaDaMaria.titular.nome + " = " + contaDaMaria.moeda + contaDaMaria.GetSaldo());


//Movimentos do André


contaDoAndre.Depositar(100);

Console.WriteLine("Saldo da conta do André pós-deposito = " + contaDoAndre.moeda + contaDoAndre.GetSaldo());

if (contaDoAndre.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta do André pós-saque =" + contaDoAndre.GetSaldo());
}
else
{
    Console.WriteLine("Saldo insuficiente para saque.");
}

contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo da conta do André pós-transferência = " + contaDoAndre.moeda + contaDoAndre.GetSaldo());
Console.WriteLine("Saldo da conta da Maria pós-transferência Recebida = " + contaDaMaria.moeda + contaDaMaria.GetSaldo());



//Movimentos da Maria


Console.WriteLine("Tecle enter para fechar ...");
Console.ReadLine();