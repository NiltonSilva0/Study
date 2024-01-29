using Canil.Models;

Cachorro cachorro1 = new Cachorro(nome: "Laica", raca:"Vira-Lata", idade: 2, cor: "Branca");//INSTANCIANDO CLASSE colocando os parametros do construtor.
Cachorro cachorro2 = new Cachorro(nome: "Mileide", raca: "Vira-Lata", idade: 3, cor: "Preta");
Cachorro cachorro3 = new Cachorro(nome: "Meg", raca: "Pastor Belga", idade: 9, cor: "Preta");

Servico tosa = new Servico(nome:"Tosa");
tosa.Cachorros = new List<Cachorro>();

tosa.AdicionarCachorro(cachorro1);
tosa.AdicionarCachorro(cachorro2);

tosa.ListarCachorro();

Servico vacinacao = new Servico(nome:"Vacinacao");
vacinacao.Cachorros = new List<Cachorro>();

vacinacao.AdicionarCachorro(cachorro3);

vacinacao.ListarCachorro();



