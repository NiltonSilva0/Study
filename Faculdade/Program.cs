using Faculdade.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //COMANDO usado para setar a região no código, formando a moeda e tudo mais para o lugar escolhido.

Aluno aluno1 = new Aluno(nome: "Nilton Silva", sexo: "Masculino", idade: 39);
Aluno aluno2 = new Aluno(nome: "Karla Carvalho", sexo: "Feminino", idade: 28);
Aluno aluno3 = new Aluno(nome: "Luiz Silva", sexo: "Masculino", idade: 37);

Curso medicina = new Curso(nome: "Medicina", valor: 7800.00M);

medicina.AlunosList = new List<Aluno>();

medicina.AdicionarAluno(aluno2);
medicina.ListarAlunos();

Curso sistemas = new Curso(nome: "Sistemas de Informação", valor: 978.50M);//DECIMAL precisa do M no final pra ser representado.

sistemas.AlunosList = new List<Aluno>();

sistemas.AdicionarAluno(aluno1);
sistemas.AdicionarAluno(aluno3);
sistemas.ListarAlunos();





////FORMATAÇÕES
//double porcentagem = .3422;
//Console.WriteLine(porcentagem.ToString("P"));
//int numero = 123123;
//Console.WriteLine(numero.ToString("##-##-##"));
//DateTime data = DateTime.Now;
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
//DateTime data = DateTime.Now;
//Console.WriteLine(data.ToShortDateString());