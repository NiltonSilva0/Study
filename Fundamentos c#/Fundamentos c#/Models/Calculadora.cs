using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_c_.Models
{
         class Calculadora
    {
        public void Somar(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public void Subtrair(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
        public void Multiplicar(double num1, double num2)
        {
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
        }
        public void Dividir(double num1, double num2)
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
        public void Resto(double num1, double num2)
        {
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
        }
        public void Potencia(double num1, double num2)
        {
            Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");
        }
        public void RaizQuadrada(double num1)
        {
            Console.WriteLine($"{num1} ^ 0.5 = {Math.Sqrt(num1)}");
        }
        public void Seno(double angulo)
        {
            //CALCULA O RADIANO USADO PARA OBTER O SENO EM MATH.SIN
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
            //SELECIONA 4 CASA DEPOS DA VÍRGULA NA FUNÇÃO MATH
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }
    }
}
