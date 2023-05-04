using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Utilitario;

//Funcionarios da Empresa
Funcionario mSantos = new Funcionario();
mSantos.Nome = "Marcelo Santos";
mSantos.Cpf = "99999999999";
mSantos.Salario = 2200;
mSantos.Moeda = "EUR";

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "00000000000";
roberta.Salario = 5000;

//Informações em tela funcionarios
Console.WriteLine(mSantos.Nome);
Console.WriteLine(mSantos.GetBonificacao());

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(mSantos);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de Bonificações: " + gerenciador.TotalDeBonificacao);