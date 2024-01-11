using Fundamentos_c_.Models;


//Datas
DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyy HH:mm"));

//Instanciando a classe pessoa

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Marta";
pessoa.Idade = 28;
pessoa.Apresentar();
