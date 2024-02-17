using System;

namespace _04ExercicioIMC
{
    public class Pessoa
    {
        public double Peso { get; set; }
        public double Altura { get; set; }

        public double CalcularIMC()
        {
            return Peso / (Altura * Altura);
        }

        public void ResultadoIMC()
        {
            var imc = CalcularIMC();
            switch (imc)
            {
                //n Representa o imc
                case double n when n < 18.5:
                    Console.WriteLine($"Abaixo do peso, seu imc é {Math.Round(n, 2)}");
                    break;
                case double n when n >= 18.5 && n < 24.9:
                    Console.WriteLine($"Peso normal, seu imc é {Math.Round(n, 2)}");
                    break;
                case double n when n >= 24.9 && n < 29.9:
                    Console.WriteLine($"Sobrepeso, seu imc é {Math.Round(n, 2)}");
                    break;
                case double n when n >= 29.9 && n < 34.9:
                    Console.WriteLine($"Obesidade grau 1, seu imc é {Math.Round(n, 2)}");
                    break;
                case double n when n >= 34.9 && n < 39.9:
                    Console.WriteLine($"Obesidade grau 2, seu imc é {Math.Round(n, 2)}");
                    break;
                default:
                    Console.WriteLine($"Obesidade grau 3 (mórbida), seu imc é aceima de 39,90");
                    break;
            }
        }
    }
}
