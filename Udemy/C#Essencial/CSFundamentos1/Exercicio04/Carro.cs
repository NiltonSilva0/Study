namespace Exercicio04
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Montadora { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public int Potencia { get; set; }
        public Carro(string modelo, string montadora)
        {
            Modelo = modelo;
            Montadora = montadora;
         

        }

        public void Acelerar(string marca)
        {
            Console.WriteLine($"Acelerando o meu {marca}");
        }

        public double VelocidadeMaxima(int potencia)
        {
            double velocidade = potencia * 1.75;
            return velocidade;
        }
    }
}
