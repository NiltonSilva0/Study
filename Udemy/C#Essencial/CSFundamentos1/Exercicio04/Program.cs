using Exercicio04;

Carro chevrolet = new Carro(modelo: "Sedan", montadora: "Chevrolet");
chevrolet.Marca = "Onix";
chevrolet.Ano = 2018;
chevrolet.Potencia = 110;
Console.WriteLine(chevrolet.Modelo);
Console.WriteLine(chevrolet.Montadora);
Console.WriteLine(chevrolet.Marca);
Console.WriteLine(chevrolet.Ano);
Console.WriteLine(chevrolet.Potencia);
chevrolet.Acelerar("Onix");
Console.WriteLine(chevrolet.VelocidadeMaxima(110));

Carro ford = new Carro(modelo: "SUV", montadora: "Ford");
ford.Marca = "EcoSport";
ford.Ano = 2019;
ford.Potencia = 120;
Console.WriteLine(ford.Modelo);
Console.WriteLine(ford.Montadora);
Console.WriteLine(ford.Marca);
Console.WriteLine(ford.Ano);
Console.WriteLine(ford.Potencia);
ford.Acelerar("EcoSport");
Console.WriteLine(ford.VelocidadeMaxima(120));
