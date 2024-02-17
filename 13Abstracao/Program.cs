using _13Abstracao;

PessoaFisica pessoaFisica = new PessoaFisica();
pessoaFisica.TaxaEmprestimo(1000);

PessoaJuridica pessoaJuridica = new PessoaJuridica();

pessoaJuridica.TaxaEmprestimo(1000);

//Abstracao

//É uma classe que pode conter métodos obrigratórios para todas as classes que a herdarem

//É possível criar métodos convencionais (não obrigatórios), para que as classes herdem e consigam utilizar

//Não é possivel instanciar uma classe abstrata

//Cada classe pode herdar somente uma classe abstrata