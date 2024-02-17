//Interfaces

//Utilizada para criar exclusivamente métodos obrigatórios

//Uma classe pode implementar várias interfaces

//Os métodos da interface não contem cálculos, condicionais, laços e demais ações

//No c# por padrão um método criado na interface é abstrato e público

//Nas boas práticas do c#, toda a interface tem a inicial I, em seguida o nome da interface

using _14Interface;

Calculo calculo = new Calculo();

calculo.Somar(10, 20);

calculo.Subtrair(10, 20);