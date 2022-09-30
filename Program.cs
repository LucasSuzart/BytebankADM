
using bytebank_ADM.Funcionarios;

Console.WriteLine("Hello, World!");

Funcionario Pedro = new Funcionario();

Pedro.Nome = "João";
Pedro.cpf = "1234678";
Pedro.salario = 2000;

Console.WriteLine("Bonificação: " + Pedro.getBonificacao());
