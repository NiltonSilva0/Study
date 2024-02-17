//Instaciando um objeto
using OOPCourse;
using OOPCourse.Agentes;

Pessoa obj = new Pessoa();
obj.nome = "Nilton";
obj.idade = 39;
obj.Apresentar();

Aluno aluno = new Aluno(true, "Estudante");
aluno.nome = "Karla";
aluno.idade = 28;
aluno.Apresentar();

Professor professor = new Professor(false, "Professor");
professor.nome = "Luiz";
professor.idade = 37;
professor.Apresentar();